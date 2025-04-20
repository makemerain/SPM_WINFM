using LinqToExcel.Extensions;

using System;
using System.Collections.Generic;
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


    }


}
