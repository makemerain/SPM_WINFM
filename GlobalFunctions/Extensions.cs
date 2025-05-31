
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM_WINFM.GlobalFunctions
{
    public static class Extensions
    {
        public static double ConvertToDouble(this string InputString)
        {
            if (double.TryParse(InputString, out var result))
            {
                return Convert.ToDouble(InputString);
            }
            else
            {
                throw new Exception($"{InputString} Is a invalid Single precission Number Extension");
            }
        }

        public static Int16 ConvertToInt(this string InputString)
        {
            if (int.TryParse(InputString, out var result))
            {
                return Convert.ToInt16(result);
            }
            else
            {
                throw new Exception($"{InputString} Is a invalid Single precission Number Extension");
            }
        }

        public static DateTime ConvertToDateTime(this string InputString, String InputFormat)
        {
            DateTime Output;
            Boolean IsValidFormat = DateTime.TryParse(InputString, out Output);

            if (IsValidFormat)
            {

                return DateTime.ParseExact(InputString, InputFormat, CultureInfo.InvariantCulture);
            }
            else
            {
                return Output;
            }
        }

        public static TimeSpan ConvertToTimeSpan(this string InputString, String InputFormat)
        {
            TimeSpan Output;
            Boolean IsValidFormat = TimeSpan.TryParse(InputString, out Output);

            if (IsValidFormat)
            {

                Output = TimeSpan.ParseExact(InputString, InputFormat, CultureInfo.InvariantCulture);

            }
            return Output;
        }

        public static int GetThrottle(this string InputString)
        {
            String x = InputString.Replace("TH", "").Trim();

            if (x == "IDLE")
            {
                return 0;
            }
            else if (x == "DB")
            {
                return -1;
            }
            else
            {
                return x.ConvertToInt();
            }
        }

        /// <summary>
        /// Identify the number is Double
        /// </summary>
        /// <param name="InputString"></param>
        /// <returns>Boolean</returns>
        public static Boolean IsNumeric(this String InputString)
        {
            Boolean IsNumeric = false;

            if (Double.TryParse(InputString, out _))
            {
                IsNumeric = true;
            }
            else if (int.TryParse(InputString, out _))
            {
                IsNumeric = true;
            }


            return IsNumeric;
        }

        public static String GetTrainStatus(double prevSpeed, double nextSpeed)
        {
            String status = "None";

            if (prevSpeed > 0 && nextSpeed == 0)
            {
                status = "STOP";
            }
            else if (prevSpeed == 0 && nextSpeed > 0)
            {
                status = "START";
            }
            else if (prevSpeed > 0 && nextSpeed > 0)
            {
                status = "RUN";
            }
            else
            {
                status = "None";
            }

            return status;
        }

        public static Boolean ConvertToBoolean(this String BoolString)
        {
            if (BoolString == "True" || BoolString == "Y" || BoolString == "Yes")
            {
                return true;
            }
            else if (BoolString == "False" || BoolString == "N" || BoolString == "No")
            {
                return false;
            }
            else
            {
                return false;
            }
        }

    }


}
