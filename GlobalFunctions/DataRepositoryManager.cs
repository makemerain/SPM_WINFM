//using Android.Support.CustomTabs;

//using Java.IO;

using LinqToExcel;

using MAUI_SPM.DataModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using Xamarin.Google.Crypto.Tink.Internal;

namespace MAUI_SPM.ApplicationTools
{
    public  class DataRepositoryManager
    {
        
        public DataRepositoryManager(DataFilterParams filterParams) {

           _params = filterParams;
           
        }
        private DataFilterParams _params = new DataFilterParams();
       

        public List<Models.LaxvenSpeedometerModel> GetLaxvenSpeedometerData() { 
        
       
        ConnectionManager.ExcelConnectionFactory ExcelFactory = new ConnectionManager.ExcelConnectionFactory(_params._excelFilePath);

            ExcelFactory.GetExcelQueryFactory.UsePersistentConnection = true;

            var Query = from Q in ExcelFactory.GetExcelQueryFactory.Worksheet<Models.LaxvenSpeedometerModel>(1).ToList()
                        where Q.RunDateAndTime >= _params._QueryTime && Q.RunDateAndTime <= _params._QueryToTime
                        select Q;

            return Query.ToList();


        }

        public  List<Models.MedhaSpeedometerModel> GetMedhaSpeedometerData()
        {


            ConnectionManager.ExcelConnectionFactory ExcelFactory = new ConnectionManager.ExcelConnectionFactory(_params._excelFilePath);

            ExcelFactory.GetExcelQueryFactory.UsePersistentConnection = true;

            var Query = from Q in ExcelFactory.GetExcelQueryFactory.Worksheet<Models.MedhaSpeedometerModel>(1).ToList()
                        where Q.RunDateAndTime >= _params._QueryTime && Q.RunDateAndTime <= _params._QueryToTime
                        select Q;

            return Query.ToList();


        }

       

    }
}
