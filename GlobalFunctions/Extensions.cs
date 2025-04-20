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
        public static Single ConvertToSingle(this string InputString)
        {
            if (InputString.IsNumber())
            {
                return Convert.ToSingle(InputString);
            }
            else
                throw new Exception($"{InputString} Is a invalid Single precission Number Extension");
            
        }


    }


}
