using MAUI_SPM.ApplicationTools;

namespace SPM_WINFM
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_LoadForAnlysis_Click(object sender, EventArgs e)
        {
            DataFilterParams DataParamsModel = new DataFilterParams();
            DataParamsModel._speedoMeterType = Cbo_SpeedometerType.Text == "LAXVEN" ? SpeedometerTypes.SPMtypes.LAXVEN : SpeedometerTypes.SPMtypes.MEDHA;
            DataParamsModel._QueryTime = Dtp_QueryFrom.Value;
            DataParamsModel._QueryToTime = Dtp_QueryTo.Value;
            DataParamsModel._bpContinutyTestPeriod = TimeSpan.FromMinutes(15);

            FrmDataAnalysis Frm = new FrmDataAnalysis(DataParamsModel);
            Frm.Show(this);
        }

        private void Txt_ExcelPath_Click(object sender, EventArgs e)
        {

        }
    }
}
