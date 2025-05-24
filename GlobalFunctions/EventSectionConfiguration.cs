using MAUI_SPM.DataModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace SPM_WINFM.GlobalFunctions
{
    /// <summary>
    /// Configure the MEDHA block section, section speed, row id & caution order
    /// </summary>
    public class EventSectionConfiguration
    {

        public EventSectionConfiguration(List<Models.MedhaSpeedometerModel> medhaeventdatalist,
                                               List<Models.BlockSecionModel> blocksectionlist,                                              
                                               List<Models.CautionOrderModel> cautionorderlist,
                                               String SPMtype)
        {
             _medhaEventList = medhaeventdatalist;
            _blockSectionModellist = blocksectionlist;
            _cautionOrderList = cautionorderlist;
            _spmType = SPMtype;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.MedhaSpeedometerModel , Models.CommonDieselBindingEventDataModel>();
            });

            var mapper = config.CreateMapper();

            _commonDieselBindingEventList = mapper.Map<List<Models.CommonDieselBindingEventDataModel>>(_medhaEventList);


        }


        public EventSectionConfiguration(List<Models.LaxvenSpeedometerModel> laxvenventdatalist,
                                               List<Models.BlockSecionModel> blocksectionlist,
                                               List<Models.CautionOrderModel> cautionorderlist,
                                               String SPMtype)
        {
            _laxvelEventlist = laxvenventdatalist;
            _blockSectionModellist = blocksectionlist;
            _cautionOrderList = cautionorderlist;
            _spmType = SPMtype;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.LaxvenSpeedometerModel, Models.CommonDieselBindingEventDataModel>();
            });

            var mapper = config.CreateMapper();

            _commonDieselBindingEventList = mapper.Map<List<Models.CommonDieselBindingEventDataModel>>(_laxvelEventlist);


        }

        private List<Models.MedhaSpeedometerModel> _medhaEventList = new();
        private List<Models.LaxvenSpeedometerModel> _laxvelEventlist = new();

        private List<Models.BlockSecionModel> _blockSectionModellist = new();
        private List<Models.CautionOrderModel> _cautionOrderList = new();
        private List<Models.CommonDieselBindingEventDataModel> _commonDieselBindingEventList = new();
        private String _spmType;
        
        /// <summary>
        /// Configure the Block section , Hecto meter & rowid
        /// </summary>
        private  void  BlockSectionSectionConfiguration()                                                                                
        {  
            // Block sectioning and sectional speed
            double Fromkm = 0;
            double Tokm = 0;
            double Diff = 0;
            double CumDistance = 0;
            int TtlEventCount = _medhaEventList.Count;
            double CurrentRowDistance = 0;
            int eventListRowCounter = 0;
            DateTime LPJdepartureTime, LPJarrivalTime;
            DateTime EventRuntime;

            Boolean IsnextEventExists = false;
            Double CurrentSpeed = 0;
            Double NextSpeed = 0;
            string Status;

            if (_commonDieselBindingEventList != null && _blockSectionModellist != null)
            {

                foreach (var blockSection in _blockSectionModellist)
                {
                    Fromkm = blockSection.BlockStartKms;
                    Tokm = blockSection.BlockEndKms;
                    Diff = Fromkm - Tokm;
                    LPJdepartureTime = blockSection.LpJournal_DepTime;
                    LPJarrivalTime = blockSection.LpJournal_ArrTime;

                   
                    for (int i = eventListRowCounter; i <= TtlEventCount; i++)
                    {
                        IsnextEventExists = eventListRowCounter < (TtlEventCount - 1);
                        

                        // Mark Run status STOP, START, RUN
                        if (IsnextEventExists)
                        {
                            CurrentSpeed = _commonDieselBindingEventList[eventListRowCounter].TrainSpeed;
                            NextSpeed = _commonDieselBindingEventList[eventListRowCounter + 1].TrainSpeed;
                            Status = Extensions.GetTrainStatus(CurrentSpeed, NextSpeed);

                            _commonDieselBindingEventList[eventListRowCounter + 1].RunStatus = Status;                          

                        }

                        // Mark Hecto meter , block section

                        if (IsnextEventExists)
                        {
                            // Mark the Block section name based on LPJ time
                            EventRuntime = _commonDieselBindingEventList[eventListRowCounter].RunDateAndTime;

                            if (EventRuntime > LPJarrivalTime)
                            {
                                break;
                            }

                            if (EventRuntime >= LPJdepartureTime && EventRuntime <= LPJarrivalTime)
                            {
                                _commonDieselBindingEventList[eventListRowCounter].Rowid = eventListRowCounter;
                                _commonDieselBindingEventList[eventListRowCounter].BlockSection = blockSection.BlockSectionName;
                                _commonDieselBindingEventList[eventListRowCounter].SectionalSpeed = blockSection.SectionalSpeed;

                                CurrentRowDistance = (_commonDieselBindingEventList[eventListRowCounter].RotationalDistanceCounter / 1000);

                                if (Diff > 0)
                                {
                                    Fromkm -= CurrentRowDistance;

                                    _commonDieselBindingEventList[eventListRowCounter].Hectometer = Math.Round(Fromkm, 3);

                                   // if (Fromkm <= Tokm) break;
                                }
                                else if (Diff < 0)
                                {
                                    Fromkm += CurrentRowDistance;
                                    _commonDieselBindingEventList[eventListRowCounter].Hectometer = Math.Round(Fromkm, 3);

                                   // if (Fromkm >= Tokm) break;

                                }

                         
                        }
                        }
                        

                        
                        eventListRowCounter++;
                        

                    }


                }
            }

            
        }

        /// <summary>
        /// Configures the Section Caution order
        /// </summary>
        private  void CautionOrderConfiguration()
        {
            double CautionFrom;
            double CautionTo;
            int cautionSpeed;

            if (_commonDieselBindingEventList != null && _cautionOrderList != null)
            {
                foreach (var item in _cautionOrderList)
                {
                    CautionFrom = item.CautionOrderFrom;
                    CautionTo = item.CautionOrderTo;
                    cautionSpeed = item.SpeedRestriction;

                    var Q = (from row in _commonDieselBindingEventList
                             where row.Hectometer >= CautionFrom && row.Hectometer <= CautionTo
                             select row).ToList();

                    foreach (var Qrow in Q)
                    {
                        _commonDieselBindingEventList[Qrow.Rowid].CautionSpeed = cautionSpeed;
                    }

                }
            }
            
        }

        public List<Models.CommonDieselBindingEventDataModel> GetConfigured_EventDataList()
        {
            BlockSectionSectionConfiguration();
            CautionOrderConfiguration();

            return _commonDieselBindingEventList;
        }
    }

 }           

    


