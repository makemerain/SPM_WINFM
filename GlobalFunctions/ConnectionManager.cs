using LinqToExcel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_SPM.ApplicationTools
{
    public  class ConnectionManager
    {

        public class ExcelConnectionFactory
        {
            public ExcelConnectionFactory(String excelFilePath)
            {

                this._ExcelfilePath = excelFilePath;
                this._ExcelQueryFactory = new ExcelQueryFactory(_ExcelfilePath);

            }

            private string _ExcelfilePath = "";
            private ExcelQueryFactory _ExcelQueryFactory;

            public ExcelQueryFactory GetExcelQueryFactory { get { return getExcelQueryFactory(); } }


            private ExcelQueryFactory getExcelQueryFactory()
            {
                if (!File.Exists(_ExcelfilePath))
                {
                    throw new Exception($"The Excel file path {_ExcelfilePath} Not found");
                    return null;
                }
                else if (_ExcelQueryFactory == null)
                {
                    throw new Exception("Excel Query factory is Null");
                }
                else
                    return _ExcelQueryFactory;

            }

        }

    }
}
