using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using MAUI_SPM.DataModels;

using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace SPM_WINFM.GlobalFunctions
{
    public static class EpexcelDataManager
    {
        /// <summary>
        /// Returns the MEDHA MRT Series event data
        /// </summary>
        /// <param name="QueryFromTime"></param>
        /// <param name="QueryToTime"></param>
        /// <param name="ExcelPath"></param>
        /// <returns></returns>
        public static async Task<List<Models.MedhaSpeedometerModel>> Get_MedhaEventDataList(
            DateTime QueryFromTime, 
            DateTime QueryToTime,
            string ExcelPath)
        {
            ExcelPackage.License.SetNonCommercialPersonal("BALASUBRAMANYA");
            List<Models.MedhaSpeedometerModel> MedhaEventDataList = new();
            Models.MedhaSpeedometerModel MedhaModel = new();

            using var Excelengine = new ExcelPackage(ExcelPath);

            await Excelengine.LoadAsync(ExcelPath);
            var Ws = Excelengine.Workbook.Worksheets[0];

            if (!File.Exists(ExcelPath))
            {
                Display.InfoMessage($"Event Data file Path {ExcelPath} Is invalid");
                return null;
            }

            int StartRow = 1;
            DateTime runDate; // Col A
            TimeSpan runTime; // Col B
            int speed; // col C
            int rotationalDistance; // Col D
            double tractiveEffort; // Col E
            double bpPressure; // Col G
            double bcPressure; // Col H
            int throttle; // Col J
            String  horn; // Col M
            DateTime ValidationQueryTime;


            for (int i = StartRow; i < 65532; i++)
            {
                if (!String.IsNullOrWhiteSpace(Ws.Cells[1, i].Value?.ToString()))
                {
                    runDate = Ws.Cells[1, i].Value.ToString().ConvertToDateTime("dd/MM/yy");
                    runTime = Ws.Cells[2, i].Value.ToString().ConvertToTimeSpan("HH:mm:ss");
                    speed = Ws.Cells[3, i].Value.ToString().ConvertToInt();
                    rotationalDistance = Ws.Cells[4, i].Value.ToString().ConvertToInt();
                    tractiveEffort = Ws.Cells[5, i].Value.ToString().ConvertToDouble();
                    bpPressure = Ws.Cells[7, i].Value.ToString().ConvertToDouble();
                    bcPressure = Ws.Cells[8, i].Value.ToString().ConvertToDouble();
                    throttle = Ws.Cells[8, i].Value.ToString().GetThrottle();
                    horn = Ws.Cells[8, i].Value.ToString();
                    ValidationQueryTime = runDate.Add(runTime);

                    if (ValidationQueryTime < QueryFromTime)
                    {
                        continue;
                    }
                    else if (ValidationQueryTime > QueryToTime)
                    {
                        break;
                    } else
                    {
                        MedhaModel.Rundate = runDate;
                        MedhaModel.Runtime = runTime;
                        MedhaModel.TrainSpeed = speed;
                        MedhaModel.RotationalDistanceCounter = rotationalDistance;
                        MedhaModel.CumulativeDistanceCounter += rotationalDistance;
                        MedhaModel.BPpressure = bpPressure;
                        MedhaModel.BCpressure = bcPressure;
                        MedhaModel.Throttle = throttle;
                        MedhaModel.Horn = horn;
                        
                        MedhaEventDataList.Add(MedhaModel);
                        
                    }                           
                                       
                }              

            }

            return MedhaEventDataList;

        }

        public static async Task<List<Models.LaxvenSpeedometerModel>> Get_LaxvenEventDataList(
            DateTime QueryFromTime,
            DateTime QueryToTime,
            string ExcelPath)
        {
            ExcelPackage.License.SetNonCommercialPersonal("BALASUBRAMANYA");
            List<Models.LaxvenSpeedometerModel> LaxvenEventDataList = new();
            Models.LaxvenSpeedometerModel LaxvenModel = new();

            using var Excelengine = new ExcelPackage(ExcelPath);

            await Excelengine.LoadAsync(ExcelPath);
            var Ws = Excelengine.Workbook.Worksheets[0];

            if (!File.Exists(ExcelPath))
            {
                Display.InfoMessage($"Event Data file Path {ExcelPath} Is invalid");
                return null;
            }

            int StartRow = 7;
            DateTime runDateAndTime; // Col 1            
            int speed; // col C
            double rotationalDistance;
            double rotationalDistanceNextRow;
            double NetRotation;
            double cumulativelDistance = 0; // Col D
            double tractiveEffort; // Col E
            double bpPressure; // Col G
            double bcPressure; // Col H
            int throttle; // Col J
            String horn; // Col M
            DateTime ValidationQueryTime;


            for (int i = StartRow; i < 65532; i++)
            {
                if (!String.IsNullOrWhiteSpace(Ws.Cells[1, i].Value?.ToString()))
                {
                    runDateAndTime = Ws.Cells[1, i].Value.ToString().ConvertToDateTime("dd/MM/yy HH:mm:ss");                    
                    speed = Ws.Cells[3, i].Value.ToString().ConvertToInt();
                    rotationalDistance = Ws.Cells[4, i].Value.ToString().ConvertToDouble();

                    // Get the next row distance
                    if (!String.IsNullOrWhiteSpace(Ws.Cells[1, i + 1].Value?.ToString()))
                    {
                        rotationalDistanceNextRow = Ws.Cells[4, i].Value.ToString().ConvertToDouble();
                    }
                    else rotationalDistanceNextRow = 0;

                    NetRotation = rotationalDistanceNextRow - rotationalDistance;
                    cumulativelDistance += NetRotation;

                    tractiveEffort = Ws.Cells[5, i].Value.ToString().ConvertToDouble();
                    bpPressure = Ws.Cells[7, i].Value.ToString().ConvertToDouble();
                    bcPressure = Ws.Cells[8, i].Value.ToString().ConvertToDouble();
                    throttle = Ws.Cells[8, i].Value.ToString().GetThrottle();
                    horn = Ws.Cells[8, i].Value.ToString();

                    
                    if (runDateAndTime < QueryFromTime)
                    {
                        continue;
                    }
                    else if (runDateAndTime > QueryToTime)
                    {
                        break;
                    }
                    else
                    {
                        LaxvenModel.RunDateAndTime = runDateAndTime;                       
                        LaxvenModel.TrainSpeed = speed;
                        LaxvenModel.RotationalDistanceCounter = rotationalDistance;
                        LaxvenModel.CumulativeDistanceCounter = cumulativelDistance;
                        LaxvenModel.BPpressure = bpPressure;
                        LaxvenModel.BCpressure = bcPressure;
                        LaxvenModel.Throttle = throttle;
                        LaxvenModel.Horn = horn;

                        LaxvenEventDataList.Add(LaxvenModel);

                    }

                }

            }

            return LaxvenEventDataList;

        }





    }




}
