using MAUI_SPM.ApplicationTools;
using MAUI_SPM.DataModels;

using SPM_WINFM.GlobalFunctions;
using SPM_WINFM.UI;

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
        private List<Models.CommonDieselBindingEventDataModel> _BindableCommonEventList = new();

        // oUT PUT FOR ANALYSIS
        private List<Models.StoppageLablingModel> _StoppageLablingEventList = new();
        private List<Models.BrakingPatternModel> _BrakeFeelTestModelList = new();
        private List<Models.BrakingPatternModel> _BrakePowerTestModelsList = new();
        private List<Models.RunPlotterListModel> _RunPlotterListModelList = new();


        private void InitializeData()
        {
            ConnectionManager.ExcelConnectionFactory excelConnectionFactory = new ConnectionManager.ExcelConnectionFactory();

            if (_TrainInfoModel.Get_SPMtype == "MEDHA-MRT")
            {
                _MedhaEventDataList = excelConnectionFactory.GetMedhaEventList(_TrainInfoModel.Get_QueryStartFromTime,
                                                                                 _TrainInfoModel.Get_QueryEndTime,
                                                                                 _TrainInfoModel.Get_ExcelPath);

                EventSectionConfiguration e = new EventSectionConfiguration(_MedhaEventDataList, _BlockSecionList, _CautionOrderList, _TrainInfoModel.Get_SPMtype);
                _BindableCommonEventList = e.GetConfigured_EventDataList();

                Dgv_Analysis.DataSource = _BindableCommonEventList;

            }
            else if (_TrainInfoModel.Get_SPMtype == "LAXVEN")
            {
                _LaxvenEventDataList = excelConnectionFactory.GetLaxvenEventList(_TrainInfoModel.Get_QueryStartFromTime,
                                                                                _TrainInfoModel.Get_QueryEndTime,
                                                                                _TrainInfoModel.Get_ExcelPath);

                EventSectionConfiguration e = new EventSectionConfiguration(_LaxvenEventDataList, _BlockSecionList, _CautionOrderList, _TrainInfoModel.Get_SPMtype);
                _BindableCommonEventList = e.GetConfigured_EventDataList();

                Dgv_Analysis.DataSource = _BindableCommonEventList;
            }
        }

        private void FrmDataAnalysis_Load(object sender, EventArgs e)
        {

            InitializeData();

        }



        private void btn_StopaageMarking_Click(object sender, EventArgs e)
        {
            Frm_StoppageFilter f = new(_BindableCommonEventList);
            f.ShowDialog(this);

            if (f.UserConfirmation && f.GetStoppagesList != null)
            {
                this._StoppageLablingEventList = f.GetStoppagesList;
                Lbl_StoppagesMapping.Text = _StoppageLablingEventList.Count().ToString() + "Stops";
            }
            else Lbl_StoppagesMapping.Text = "False";
        }

        private void ValidateBFTcheckValue()
        {
            double t = (Dtp_BftEndTime.Value - Dtp_BftStartTime.Value).TotalMinutes;
            if (t <= 0)
            {
                Chk_IdentifyBFT.Checked = false;
            }

        }

        private void ValidateBPTcheckValue()
        {
            double t = (Dtp_BptendTime.Value - Dtp_BptStartTime.Value).TotalMinutes;
            if (t <= 0)
            {
                Chk_IdentifyBPT.Checked = false;
            }

        }

        private void Dtp_BptStartTime_ValueChanged(object sender, EventArgs e)
        {

            ValidateBPTcheckValue();
        }

        private void Dtp_BptendTime_ValueChanged(object sender, EventArgs e)
        {
            ValidateBPTcheckValue();
        }

        private void Dtp_BftStartTime_ValueChanged(object sender, EventArgs e)
        {
            ValidateBFTcheckValue();
        }

        private void Dtp_BftEndTime_ValueChanged(object sender, EventArgs e)
        {
            ValidateBFTcheckValue();
        }

        private void Chk_IdentifyBPT_CheckStateChanged(object sender, EventArgs e)
        {
            if (Chk_IdentifyBPT.Checked)
            {
                EventAnalysysOutputMapping em = new EventAnalysysOutputMapping(_BindableCommonEventList);
                _BrakePowerTestModelsList = em.Get_BrakingTestPatternList(Dtp_BptStartTime.Value, Dtp_BptendTime.Value, "BPT");

                Lbl_BptMapping.Text = _BrakePowerTestModelsList.Count().ToString();
            }
            else Lbl_BptMapping.Text = "False";
        }

        private void Chk_IdentifyBFT_CheckStateChanged(object sender, EventArgs e)
        {
            if (Chk_IdentifyBFT.Checked)
            {
                EventAnalysysOutputMapping em = new EventAnalysysOutputMapping(_BindableCommonEventList);
                _BrakeFeelTestModelList = em.Get_BrakingTestPatternList(Dtp_BptStartTime.Value, Dtp_BptendTime.Value, "BFT");

                Lbl_BFTmapping.Text = _BrakeFeelTestModelList.Count().ToString();
            }
            else Lbl_BFTmapping.Text = "False";
        }

        private void Btn_BlockSectionMapping_Click(object sender, EventArgs e)
        {
            EventAnalysysOutputMapping em = new EventAnalysysOutputMapping(_BindableCommonEventList);
            _RunPlotterListModelList = em.Get_RunplotterList();

            if (_RunPlotterListModelList == null)
            {
                Lbl_BlockSectionMapping.Text = "False";
                Display.InfoMessage("No Block section mapping Available for mapping");
            }
            else
            { 
                Lbl_BlockSectionMapping.Text = _RunPlotterListModelList.Count.ToString() + "Sections";
                Display.InfoMessage($"Total of {_RunPlotterListModelList.Count.ToString()} Sections available for mapping");

            }
        }
    }
}
