using MAUI_SPM.DataModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace SPM_WINFM.GlobalFunctions
{
    /// <summary>
    /// Configure the MEDHA block section, section speed, row id & caution order
    /// </summary>
    public class EventSectionConfiguration
    {

        public EventSectionConfiguration(List<Models.MedhaSpeedometerModel> medhaeventdatalist,
                                               List<Models.BlockSecionModel> blocksectionlist,                                              
                                               List<Models.CautionOrderModel> cautionorderlist)
        {
             _medhaEventList = medhaeventdatalist;
            _blockSectionModellist = blocksectionlist;
            _cautionOrderList = cautionorderlist;
        }

        private List<Models.MedhaSpeedometerModel> _medhaEventList = new();
        private List<Models.BlockSecionModel> _blockSectionModellist = new();
        private List<Models.CautionOrderModel> _cautionOrderList = new();
        
        /// <summary>
        /// Configure the Block section , Hecto meter & rowid
        /// </summary>
        private  void  MedhaSectionConfiguration()                                                                                
        {  
            // Block sectioning and sectional speed
            double Fromkm = 0;
            double Tokm = 0;
            double Diff = 0;
            double CumDistance = 0;
            int TtlEventCount = _medhaEventList.Count;
            double CurrentRowDistance = 0;
            int eventListRowCounter = 0;

            Boolean IsnextEventExists = false;
            Double CurrentSpeed = 0;
            Double NextSpeed = 0;
            string Status;

            if (_medhaEventList != null && _blockSectionModellist != null)
            {

                foreach (var blockSection in _blockSectionModellist)
                {
                    Fromkm = blockSection.BlockStartKms;
                    Tokm = blockSection.BlockEndKms;
                    Diff = Fromkm - Tokm;

                    for (int i = eventListRowCounter; i <= TtlEventCount; i++)
                    {
                        IsnextEventExists = eventListRowCounter < (TtlEventCount - 1);
                        

                        // Mark Run status STOP, START, RUN
                        if (IsnextEventExists)
                        {
                            CurrentSpeed = _medhaEventList[eventListRowCounter].TrainSpeed;
                            NextSpeed = _medhaEventList[eventListRowCounter + 1].TrainSpeed;
                            Status = Extensions.GetTrainStatus(CurrentSpeed, NextSpeed);

                            _medhaEventList[eventListRowCounter + 1].RunStatus = Status;                          

                        }

                        // Mark Hecto meter , block section

                        if (IsnextEventExists)
                        {
                        CurrentRowDistance = (_medhaEventList[eventListRowCounter].RotationalDistanceCounter / 1000);
                        _medhaEventList[eventListRowCounter].BlockSection = blockSection.BlockSectionName;
                            _medhaEventList[eventListRowCounter].SectionalSpeed = blockSection.SectionalSpeed;
                            _medhaEventList[eventListRowCounter].Rowid = eventListRowCounter;
                            

                            if (Diff > 0)
                        {
                                Fromkm -= CurrentRowDistance;

                                _medhaEventList[eventListRowCounter].Hectometer = Math.Round(Fromkm, 3);

                            if (Fromkm <= Tokm) break;
                        }
                        else if (Diff < 0)
                        {
                                Fromkm += CurrentRowDistance;
                                _medhaEventList[eventListRowCounter].Hectometer = Math.Round(Fromkm, 3);

                                if (Fromkm >= Tokm) break;
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
        private  void MedhaCautionOrderConfiguration()
        {
            double CautionFrom;
            double CautionTo;
            int cautionSpeed;

            if (_medhaEventList != null && _cautionOrderList != null)
            {
                foreach (var item in _cautionOrderList)
                {
                    CautionFrom = item.CautionOrderFrom;
                    CautionTo = item.CautionOrderTo;
                    cautionSpeed = item.SpeedRestriction;

                    var Q = (from row in _medhaEventList
                             where row.Hectometer >= CautionTo && row.Hectometer <= CautionFrom
                             select row).ToList();

                    foreach (var Qrow in Q)
                    {
                        _medhaEventList[Qrow.Rowid].CautionSpeed = cautionSpeed;
                    }

                }
            }
            
        }

        public List<Models.MedhaSpeedometerModel> GetConfigured_MedhaEventDataList()
        {
            MedhaSectionConfiguration();
            MedhaCautionOrderConfiguration();

            return _medhaEventList;
        }
    }

 }           

    


