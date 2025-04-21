using LinqToExcel.Extensions;

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
                throw new Exception($"{InputString} Is a invalid Single precission Number Extension");            
        }

        public static Int16 ConvertToInt(this string InputString)
        {
            if (int.TryParse(InputString, out var result))
            {
                return Convert.ToInt16(result);
            }
            else
                throw new Exception($"{InputString} Is a invalid Single precission Number Extension");
        }

        public static DateTime ConvertToDateTime(this string InputString,String InputFormat)
        {
            DateTime Output;
            Boolean IsValidFormat = DateTime.TryParse(InputString, out Output);
            
            if (IsValidFormat) {

               Output =  DateTime.ParseExact(InputString, InputFormat, CultureInfo.InvariantCulture);
            }
            return Output;
        }

        public static TimeSpan ConvertToTimeSpan(this string InputString, String InputFormat)
        {
            TimeSpan Output;
            Boolean IsValidFormat = TimeSpan.TryParse(InputString, out Output);

            if (IsValidFormat)
            {

                Output = TimeSpan.ParseExact(InputString,InputFormat, CultureInfo.InvariantCulture);
              
            }
            return Output;
        }

        public static int GetThrottle(this string InputString)
        {

            if (InputString == "IDLE")
            {
                return 0;
            }
            else if (InputString == "DB")
            {
                return -1;
            }
            else return InputString.ConvertToInt();
            
        }





    }


}
