using AutoMapper;

using MAUI_SPM.DataModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace SPM_WINFM.GlobalFunctions
{
    public class EventAnalysysOutputMapping
    {
        // String SPMtype, String sectionLable
        public EventAnalysysOutputMapping(List<Models.CommonDieselBindingEventDataModel> commonBindableDieselEventDatalist)
        {
            _commonBindableEventDataList = commonBindableDieselEventDatalist;

        }


        private List<Models.CommonDieselBindingEventDataModel> _commonBindableEventDataList = new();

        // private String _SPMtype = "";
        //  private String _sectionLalble;


        /// <summary>
        /// Returns the BFT / BPT braking pattern list
        /// </summary>
        /// <param name="BFTstarttime"></param>
        /// <param name="BFTendtime"></param>
        /// <param name="SectionLable"></param>
        /// <returns>List<Models.BrakingPatternModel></returns>
        public List<Models.BrakingPatternModel> Get_BrakingTestPatternList(DateTime BFTstarttime, DateTime BFTendtime, String SectionLable)
        {
            List<Models.BrakingPatternModel> blist = new();

            if (_commonBindableEventDataList != null)
            {
                var EventList = (from Q in _commonBindableEventDataList
                                 where Q.RunDateAndTime >= BFTstarttime && Q.RunDateAndTime <= BFTendtime
                                 select Q).ToList();

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Models.CommonDieselBindingEventDataModel, Models.BrakingPatternModel>();
                });

                var mapper = config.CreateMapper();

                blist = mapper.Map<List<Models.BrakingPatternModel>>(EventList);

            }

            return blist;
        }

        /// <summary>
        /// Returns the stoppages list for labeling (NOT THE SELECTED LIST)
        /// </summary>
        /// <returns>List<Models.CommonDieselBindingEventDataModel</returns>
        public List<Models.CommonDieselBindingEventDataModel> Get_StoppagesList()
        {
            if (_commonBindableEventDataList != null)
            {
                var Qlist = from Q in _commonBindableEventDataList
                            where Q.RunStatus == "STOP"
                            select Q;

                return Qlist.ToList();

            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// For each Date & time list, returns the Braking pattern for preceding 1732 Mts
        /// </summary>
        /// <param name="StoppageslList"></param>
        /// <returns>List<Models.BrakindPatternModelLists></returns>
        public List<Models.BrakingPatternModelLists> Get_BrakingPatternStoplist(List<Models.StoppageLablingModel> StoppageslList)
        {

            double cumulativeDistacne = 0;
            List<Models.BrakingPatternModel> UniquePatternList = new(); // Each stop unique
            List<Models.BrakingPatternModelLists> BrakingPatternLists = new(); // List of lists of UniquePatternList


            if (StoppageslList != null && _commonBindableEventDataList != null)
            {
                foreach (var x in StoppageslList)
                {
                    // Filter Stoppage till 0 row
                    var StopDataList = (from Q in _commonBindableEventDataList
                                        where Q.Rowid > 0 && Q.Rowid <= x.StopRowId
                                        select Q).ToList().OrderBy(x => x.Rowid).ToList();


                    // Append each item till 1400 mts to the list UniquePatternList Then add the list to List group StoppagesPatternLists
                    foreach (var Event in StopDataList)
                    {
                        UniquePatternList.Add(new Models.BrakingPatternModel
                        {
                            TrainSpeed = Event.TrainSpeed,
                            TractiveEffort = Event.TractiveEffort,
                            RotationalDistanceCounter = Event.RotationalDistanceCounter,
                            CumulativeDistanceCounter = Event.CumulativeDistanceCounter,
                            BPpressureMetric = Event.BPpressureMetric,
                            BCpressureMetric = Event.BCpressureMetric,
                            Hectometer = Event.Hectometer,
                            ThrottleInt = Event.ThrottleInt,
                            RunDateTime = Event.RunDateAndTime,
                            StopLable = x.StoppageLable
                        });

                        cumulativeDistacne += Event.RotationalDistanceCounter;

                        if (cumulativeDistacne >= 1400)
                        {
                            break;
                        }
                    }

                    // Add the each stop list & reset the counter
                    BrakingPatternLists.Add(new Models.BrakingPatternModelLists
                    {
                        PatternList = UniquePatternList,
                        PaternLabel = x.StoppageLable
                    });

                    cumulativeDistacne = 0;
                    UniquePatternList.Clear();

                }
            }

            return BrakingPatternLists;


        }

        /// <summary>
        /// Returns the run plotter list for each block section
        /// </summary>
        /// <returns></returns>
        public List<Models.RunPlotterListModel> Get_RunplotterList()
        {
            //Get eh block section list
            List<Models.RunPlotterListModel> RunPlotterList = new();



            var Qlist = from Q in _commonBindableEventDataList
                        group Q by Q.BlockSection
                        into Qg
                        select Qg;

            if (Qlist != null)
            {
                foreach (var Q in Qlist)
                {

                    var BlockList = (from El in _commonBindableEventDataList
                                     where El.BlockSection == Q.Key
                                     select El).ToList();

                    // Add the list too Run plotter
                    RunPlotterList.Add(new Models.RunPlotterListModel
                    {
                        BlockRunList = BlockList,

                    });
                }
            }

            return RunPlotterList;

        }

    }
}
