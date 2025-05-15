using MAUI_SPM.ApplicationTools;
using MAUI_SPM.DataModels;

using SPM_WINFM.GlobalFunctions;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM_WINFM
{
    public partial class FrmDataAnalysis : Form
    {
        public FrmDataAnalysis(
            Models.TrainInformationModel trainInformationModel,
            List<Models.CautionOrderModel> cautionOrderList,            
            List<Models.BlockSecionModel> blockSectionList)
        {
            InitializeComponent();
            Dgv_Analysis.AutoGenerateColumns = false;
            Dgv_Analysis.Columns[0].DefaultCellStyle.Format = "dd/MM/yy HH:mm:ss";

            this._TrainInfoModel = trainInformationModel;
            _CautionOrderList = cautionOrderList;    
            _BlockSecionList = blockSectionList;
                        
        }

        private Models.TrainInformationModel _TrainInfoModel;
        private List<Models.CautionOrderModel> _CautionOrderList = new();
        private List<Models.BlockSecionModel> _BlockSecionList = new();

        private List<Models.MedhaSpeedometerModel> _MedhaEventDataList = new();
        private List<Models.LaxvenSpeedometerModel> _LaxvenEventDataList = new();

        private List<Models.MedhaSpeedometerModel> _MedhaBindableEventDataList = new();
        private List<Models.LaxvenSpeedometerModel> _LaxvenBindableEventDataList = new();



        private void InitializeData()
        {
            ConnectionManager.ExcelConnectionFactory excelConnectionFactory = new ConnectionManager.ExcelConnectionFactory();

            if (_TrainInfoModel.Get_SPMtype == "MEDHA-MRT")
            {
                _MedhaEventDataList = excelConnectionFactory.GetMedhaEventList(_TrainInfoModel.Get_QueryStartFromTime,
                                                                                 _TrainInfoModel.Get_QueryEndTime,
                                                                                 _TrainInfoModel.Get_ExcelPath);

                EventSectionConfiguration e = new EventSectionConfiguration(_MedhaEventDataList, _BlockSecionList, _CautionOrderList);
                _MedhaBindableEventDataList =  e.GetConfigured_MedhaEventDataList();

                Dgv_Analysis.DataSource = _MedhaBindableEventDataList;

            }
            


            

            
        }

        private   void FrmDataAnalysis_Load(object sender, EventArgs e)
        {
           
             InitializeData(); 


        }

        private void Btn_IdentifyTrainDeparture_Click(object sender, EventArgs e)
        {

        }
    }
}
