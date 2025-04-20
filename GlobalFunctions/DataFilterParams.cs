using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_SPM.ApplicationTools
{
    public  class DataFilterParams
    {

       
        public String _excelFilePath { get; set; }
        public String _speedoMeterType { get; set; }
        public DateTime _QueryTime { get; set; }
        public DateTime _QueryToTime { get; set; }
        public TimeSpan _bpContinutyTestPeriod { get; set; }


    }
}
