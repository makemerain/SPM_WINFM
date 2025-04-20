using MAUI_SPM.ApplicationTools;
using MAUI_SPM.DataModels;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM_WINFM
{
    public partial class FrmDataAnalysis : Form
    {
        public FrmDataAnalysis(Models.TrainInformationModel trainInformationModel,
            List<Models.CautionOrderModel> cautionOrderList,
            List<Models.SectionalSpeedModel> sectionalSpeedList,
            List<Models.BlockSecionModel> blockSectionList)
        {
            InitializeComponent();
           
            this._TrainInfoModel = trainInformationModel;
            _CautionOrderList = cautionOrderList;
            _SectionalSpeedList = sectionalSpeedList;
        }

        private Models.TrainInformationModel _TrainInfoModel;
        private List<Models.CautionOrderModel> _CautionOrderList;
        private List<Models.SectionalSpeedModel> _SectionalSpeedList;
        private DataRepositoryManager _dataRepository;
        
        private void FrmDataAnalysis_Load(object sender, EventArgs e)
        {
            Dgv_Analysis.DataSource = _dataRepository.GetMedhaSpeedometerData();
        }
    }
}
