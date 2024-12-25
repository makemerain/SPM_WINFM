using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MAUI_SPM.DataModels
{
    public class Models
    {
        public class LaxvenSpeedometerModel
        {

            public LaxvenSpeedometerModel(Boolean IsPressureinPSI = true)
            {
                this._IsPressureinPSI = IsPressureinPSI;
            }

            bool _IsPressureinPSI = false;

            public DateTime RunDateAndTime { get; set; }
            public Single TrainSpeed { get; set; }
            public Single DistanceCounter { get; set; }
            public Single TractiveEffort { get; set; }
            public Single GeneratedPower { get; set; }
            public Single BPpressure { get; set; }
            public Single BCpressure { get; set; }
            public Single TL24voltage { get; set; }
            public Boolean GeneraterRequest { get; set; }
            public string ReverserPosition { get; set; }
            public string Throttle { get; set; }
            public Boolean Horn { get; set; }
            public Boolean Headlight1 { get; set; }
            public Boolean Headlight2 { get; set; }
            public Boolean PCS { get; set; }
            public Boolean PENALTY { get; set; }

            public double BPpressureMetric { get { return PressureModifierToMetric(BPpressure, _IsPressureinPSI); } }
            public double BCpressureMetric { get { return PressureModifierToMetric(BCpressure, _IsPressureinPSI); } }
        }

        public class MedhaSpeedometerModel
        {
            public MedhaSpeedometerModel(Boolean IsPressureinPSI = true)
            {
                this._IsPressureinPSI = IsPressureinPSI;
            }

            bool _IsPressureinPSI = false;

            public DateTime Rundate { get; set; }
            public TimeSpan Runtime { get; set; }
            public Single TrainSpeed { get; set; }
            public Single DistanceCounter { get; set; }
            public Single TractiveEffort { get; set; }
            public Single GeneratedPower { get; set; }
            public Single BPpressure { get; set; }
            public Single BCpressure { get; set; }
            public Single TL24voltage { get; set; }

            public string Throttle { get; set; }
            public string ReverserPosition { get; set; }

            public string GeneraterRequest { get; set; }

            public Boolean Horn { get; set; }
            public Boolean Headlight1 { get; set; }
            public Boolean Headlight2 { get; set; }
            public Boolean PCS { get; set; }
            public Boolean PENALTY { get; set; }

            public DateTime RunDateAndTime { get { return Rundate.Add(Runtime); } }

            public double BPpressureMetric { get { return PressureModifierToMetric(BPpressure, _IsPressureinPSI); } }
            public double BCpressureMetric { get { return PressureModifierToMetric(BCpressure, _IsPressureinPSI); } }

        }

        private static double PressureModifierToMetric(Single PressureInPSI, Boolean IsBritishSystem)
        {
            if (IsBritishSystem)
            {
                return Math.Round((PressureInPSI * 0.070307), 2);
            }
            else return PressureInPSI;
        }

        public class TrainInformationModel
        {
            public TrainInformationModel(
                String locopilotName,
                String lPdesignation_Depot,
                String nli_Depot,
                double trainStartKm,
                String trainNumber,
                String trainLoad,
                String majorSection,
                String analysedSection,
                String stockType,
                String brakePower,
                DateTime queryStartFromTime,
                DateTime queryEndTime,
                String spmType,
                double trainStartTolerance,
                int totalLoopLines,
                String excelPath)
            {
                this._LocoPilotName = locopilotName;
                this._LPdesignation_Depot = lPdesignation_Depot;
                this._Nli_Depot = nli_Depot;
                this._TrainStartKmNo = trainStartKm;
                this._TrainNumber = trainNumber;
                this._TrainLoad = trainLoad;
                this._MajorSection = majorSection;
                this._AnalysedSection = analysedSection;
                this._StockType = stockType;
                this._BrakePower = brakePower;
                this._QueryStartFromTime = queryStartFromTime;
                this._QueryEndTime = queryEndTime;
                this._SPMtype = spmType;
                this._TrainStartTolerance = trainStartTolerance;
                this._TotalLoopLines = totalLoopLines;
                this._ExcelFilePath = excelPath;

            }

            private String _LocoPilotName;
            private String _LPdesignation_Depot;
            private String _LPgrade_Experiance;
            private String _Nli_Depot;
            private double _TrainStartKmNo = 0.0;
            private String _TrainNumber;
            private string _TrainLoad;
            private String _MajorSection;
            private String _AnalysedSection;
            private String _StockType;
            private String _BrakePower;
            private DateTime _QueryStartFromTime;
            private DateTime _QueryEndTime;
            private String _SPMtype;
            private double _TrainStartTolerance = 0.0;
            private int _TotalLoopLines = 0;
            private string _ExcelFilePath;

            public String Get_LocoPilotName { get { return _LocoPilotName; } }
            public String Get_LPdesignation_Depot { get { return _LPdesignation_Depot; } }
            public String Get_LPgrade_Experiance { get { return _LPgrade_Experiance; } }
            public String Get_Nli_Depot { get { return _Nli_Depot; } }
            public double Get_TrainStartKmNo { get { return _TrainStartKmNo; } }
            public String Get_TrainNumber { get { return _TrainNumber; } }
            public String Get_TrainLoad { get { return _TrainLoad; } }
            public String Get_MajorSection { get { return _MajorSection; } }
            public String Get_AnalysedSection { get { return _AnalysedSection; } }
            public String Get_StockType { get { return _StockType; } }
            public String Get_BrakePower { get { return _BrakePower; } }
            public DateTime Get_QueryStartFromTime { get { return _QueryStartFromTime; } }
            public DateTime Get_QueryEndTime { get { return _QueryEndTime; } }
            public String Get_SPMtype { get { return _SPMtype; } }
            public double Get_TrainStartTolerance { get { return _TrainStartTolerance; } }
            public int Get_TotalLoopLines { get { return _TotalLoopLines; } }
            public String Get_ExcelPath { get { return _ExcelFilePath; } }



        }

        public class CautionOrderModel
        {
            public Single CautionOrderFrom { get; set; }
            public Single CautionOrderTo { get; set; }
            public int SpeedRestriction { get; set; }
        }
    }
}

