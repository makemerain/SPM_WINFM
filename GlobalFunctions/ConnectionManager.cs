

using MAUI_SPM.DataModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcelModern;
using System.Reflection;

namespace MAUI_SPM.ApplicationTools
{
    public class ConnectionManager
    {

        public class ExcelConnectionFactory
        {

            public List<Models.MedhaSpeedometerModel> GetMedhaEventList(DateTime QueryFromTime, DateTime QueryToTime, String ExcelPath)
            {
                var excel = new ExcelQueryFactory(ExcelPath);
                excel.SkipEmptyRows = true;
                excel.TrimSpaces = LinqToExcelModern.Query.TrimSpacesType.Both;

                List<Models.MedhaSpeedometerModel> Qmlist = new();
                //DD/MM/YY	hh:mm:ss	SPD(KMPH)	DIST(Mtrs)	TE_EFRT(KN))	POWER(KW))	BK_PIPE_PR(PSI)	BK_CY_PR(PSI)	TRN24T(VDC)(VDC)	THRT_POS	REV_POS	Gen_Req	HORN

                excel.AddMapping<Models.MedhaSpeedometerModel>(x => x.Rundate, "DD/MM/YY");
                excel.AddMapping<Models.MedhaSpeedometerModel>(x => x.Runtime, "hh:mm:ss");
                excel.AddMapping<Models.MedhaSpeedometerModel>(x => x.TrainSpeed, "SPD(KMPH)");
                excel.AddMapping<Models.MedhaSpeedometerModel>(x => x.RotationalDistanceCounter, "DIST(Mtrs)");
                excel.AddMapping<Models.MedhaSpeedometerModel>(x => x.TractiveEffort, "TE_EFRT(KN))");
                excel.AddMapping<Models.MedhaSpeedometerModel>(x => x.BPpressure, "BK_PIPE_PR(PSI)");
                excel.AddMapping<Models.MedhaSpeedometerModel>(x => x.BCpressure, "BK_CY_PR(PSI)");
                excel.AddMapping<Models.MedhaSpeedometerModel>(x => x.Throttle, "THRT_POS");
                excel.AddMapping<Models.MedhaSpeedometerModel>(x => x.Horn, "HORN");


                var Q = (from l in excel.Worksheet<Models.MedhaSpeedometerModel>(0)
                         where
                         l.Runtime != ""
                         select l).ToList();


                var FilterQ = (from l in Q
                               where l.RunDateAndTime <= QueryToTime &&
                               l.RunDateAndTime >= QueryFromTime
                               select l).ToList();
                double runningTotal = 0;

                var CumQ = FilterQ.Select(x =>
                {
                    runningTotal += x.RotationalDistanceCounter;
                    return new
                    {
                        x.RunDateAndTime,
                        x.TrainSpeed,
                        x.RotationalDistanceCounter,
                        V = x.CumulativeDistanceCounter = runningTotal,
                        x.TractiveEffort,
                        x.ThrottleInt,
                        x.BPpressureMetric,
                        x.BCpressureMetric,
                        x.Horn
                    };
                }).ToList();


                return FilterQ;

            }



            public List<Models.LaxvenSpeedometerModel> GetLaxvenEventList(DateTime QueryFromTime, DateTime QueryToTime, String ExcelPath)
            {
                var excel = new ExcelQueryFactory(ExcelPath);
                excel.SkipEmptyRows = true;
                excel.TrimSpaces = LinqToExcelModern.Query.TrimSpacesType.Both;

                List<Models.LaxvenSpeedometerModel> Qmlist = new();
                //Time	Speed	Distance	TE	GenPower	BPP	BCP	TL24T	GF	RV	Th	Hr	H1	H2	PCS	PB	VALIDITY	MF	Evnt


                excel.AddMapping<Models.LaxvenSpeedometerModel>(x => x.RunDateAndTimeInput, "Time");                
                excel.AddMapping<Models.LaxvenSpeedometerModel>(x => x.TrainSpeed, "Speed");
                excel.AddMapping<Models.LaxvenSpeedometerModel>(x => x.CumulativeDistanceCounter, "Distance");
                excel.AddMapping<Models.LaxvenSpeedometerModel>(x => x.TractiveEffort, "TE");
                excel.AddMapping<Models.LaxvenSpeedometerModel>(x => x.BPpressure, "BPP");
                excel.AddMapping<Models.LaxvenSpeedometerModel>(x => x.BCpressure, "BCP");
                excel.AddMapping<Models.LaxvenSpeedometerModel>(x => x.Throttle, "Th");
                excel.AddMapping<Models.LaxvenSpeedometerModel>(x => x.Horn, "Hr");


                var Q = (from l in excel.Worksheet<Models.LaxvenSpeedometerModel>(0)
                         where
                         l.RunDateAndTimeInput != ""
                         select l).ToList();


                var FilterQ = (from l in Q
                               where l.RunDateTime <= QueryToTime &&
                               l.RunDateTime >= QueryFromTime
                               select l).ToList();
                double runningTotal = 0;

                var CumQ = (FilterQ.Select((x, index) => new
                {
                    NextValue = index < FilterQ.Count - 1 ? FilterQ[index + 1].CumulativeDistanceCounter : (double?)null,
                    RotationalDistanceCounter = index < FilterQ.Count - 1 ? (double?)(x.CumulativeDistanceCounter - FilterQ[index + 1].CumulativeDistanceCounter) : null,
                    x.RunDateTime,
                    x.TrainSpeed,
                    x.CumulativeDistanceCounter,
                    x.TractiveEffort,
                    x.ThrottleInt,
                    x.BPpressureMetric,
                    x.BCpressureMetric,
                    x.Horn
                }).Where(x => x.NextValue != null).ToList());
                
     
                return FilterQ;

            }

        }
    }
}
