using LinqToExcel.Extensions;

using MAUI_SPM.ApplicationTools;
using MAUI_SPM.DataModels;

using SPM_WINFM.GlobalFunctions;

namespace SPM_WINFM
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private Models.TrainInformationModel trainInformationModel;
        private List<Models.CautionOrderModel> cautionOrderModelList = new();
        private List<Models.SectionalSpeedModel> sectionalSpeedList = new();
        private List<Models.BlockSecionModel> blockSectionList = new();

        private void Btn_LoadForAnlysis_Click(object sender, EventArgs e)
        {

            trainInformationModel = InputDataValidation();

            if (trainInformationModel == null) return;
            if (Validate_CautionOrderGrid()) { cautionOrderModelList = Get_CautionOrderList(); } else return;
            if (Validate_SectionalSpeedGrid()) { sectionalSpeedList = Get_SectionalSpeedList(); } else return;
            if (Validate_BlockSectioningGrid()) { blockSectionList = Get_BlockSectionPartitionList(); } else return;


            FrmDataAnalysis f = new FrmDataAnalysis(trainInformationModel, cautionOrderModelList, sectionalSpeedList, blockSectionList);
            f.Show(this);

        }

        /// <summary>
        /// Input data validation
        /// </summary>
        /// <returns>TrainInformationModel</returns>
        private Models.TrainInformationModel InputDataValidation()
        {
            Boolean IsValidated = false;

            String LPname = Txt_LocoPilotName.Text;
            String LPdesignation_Depot = Txt_LpDegn_Depot.Text;
            String Grade_Experiance = Txt_LpGrade_Experiance.Text;
            String NliName_Depot = Txt_NliName_Depot.Text;
            double TrainStartKms = Txt_TrainStartKMnumber.Text.ConvertToDouble();
            String LocoConsist = Txt_LocoConsist.Text;
            String TrainNumber = Txt_TrainNumber.Text;
            String TrainLoad = Txt_TrainLoad.Text;
            String MajorSection = Txt_MajorSection.Text;
            String AnalyzedSection = Txt_AnalysedSection.Text;
            String StockType = txt_StockType.Text;
            String BrakePower_Kbd = Txt_BrakePower.Text;
            DateTime QueryFromTime = Dtp_QueryFrom.Value;
            DateTime QueryToTime = Dtp_QueryTo.Value;
            String SPMtype = Cbo_SpeedometerType.Text; 
            String ExcelPath = Txt_ExcelPath.Text;
            String AnalyserName = Txt_Analyser.Text;
            String Analyserdesignation = Txt_AnalyserDegn.Text;

            if (LPname.Length <= 4 || LPname == "")
            {
                Display.InfoMessage("Invalid Crew name, Must be of atleast 05 characters");
                Txt_LocoPilotName.Focus();
                return null;
            }
            else if (LPdesignation_Depot == "")
            {
                Display.InfoMessage("Invalid crew designation");
                Txt_LpDegn_Depot.Focus();
                return null;
            }
            else if (Grade_Experiance == "")
            {
                Display.InfoMessage("Invalid LP Grade / Experiance");
                Txt_LpGrade_Experiance.Focus();
                return null;
            }
            else if (NliName_Depot == "")
            {
                Display.InfoMessage("Invalid NLI name & base depot");
                Txt_NliName_Depot.Focus();
                return null;
            }
            else if (TrainStartKms < 0)
            {
                Display.InfoMessage("Invalid train start Hectometer");
                Txt_TrainStartKMnumber.Focus();
                return null;
            }
            else if (LocoConsist == "")
            {
                Display.InfoMessage("Invalid Loco Consist, The leading loco must be first of the consist");
                Txt_LocoConsist.Focus();
                return null;
            }
            else if (TrainLoad == "")
            {
                Display.InfoMessage("Invalid Train load");
                Txt_TrainLoad.Focus();
                return null;
            }
            else if (MajorSection == "")
            {
                Display.InfoMessage("Invalid Train Major section");
                Txt_MajorSection.Focus();
                return null;
            }
            else if (AnalyzedSection == "")
            {
                Display.InfoMessage("Invalid Analyzed section name");
                Txt_AnalysedSection.Focus();
                return null;
            }
            else if (StockType == "")
            {
                Display.InfoMessage("Invalid stock type");
                txt_StockType.Focus();
                return null;
            }
            else if (BrakePower_Kbd == "")
            {
                Display.InfoMessage("Invalid Brake power / KBD % Detail");
                Txt_BrakePower.Focus();
                return null;
            }
            else if (QueryFromTime > DateTime.Now || QueryToTime > DateTime.Now || QueryFromTime >= QueryToTime)
            {
                Display.InfoMessage("Query from time must be Less than the Query to time & Must be Less than the current time");
                Dtp_QueryFrom.Focus();
                return null;
            }
            else if (Cbo_SpeedometerType.SelectedIndex < 0)
            {
                Display.InfoMessage("Select proper SPM type");
                Cbo_SpeedometerType.Focus();
                return null;
            }
            else if (ExcelPath == "" || !File.Exists(ExcelPath))
            {
                Display.InfoMessage("Invalid Excel path OR the file Doesn't exists");
                Txt_ExcelPath.Focus();
                return null;
            }
            else if (AnalyserName == "" || Analyserdesignation == "")
            {
                Display.InfoMessage("Invalid name & Degn of the Analyzed person");
                Txt_AnalysedSection.Focus();
                return null;
            }
            else if (TrainNumber == "")
            {
                Display.InfoMessage("Invalid Train Number");
                Txt_TrainNumber.Focus();
                return null;
            }
            else if (!Validate_CautionOrderGrid() || !Validate_SectionalSpeedGrid() || !Validate_BlockSectioningGrid())
            {
                Display.InfoMessage("Invalid Grid Configurations noticed");
                return null;
            }
            else
            {
                trainInformationModel = new Models.TrainInformationModel(
                    locopilotName: LPname,
                    lPdesignation_Depot: LPdesignation_Depot,
                    nli_Depot: NliName_Depot,
                    trainStartKm: TrainStartKms,
                    trainNumber: TrainNumber,
                    trainLoad: TrainLoad,
                    majorSection: MajorSection,
                    analysedSection: AnalyzedSection,
                    stockType: StockType,
                    brakePower_KBDpercentage: BrakePower_Kbd,
                    queryStartFromTime: QueryFromTime,
                    queryEndTime: QueryToTime,
                    spmType: SPMtype,
                    excelPath: ExcelPath,
                    analyserName: AnalyserName,
                    analyserDegn: Analyserdesignation,
                    isDataValidated: true);

                return trainInformationModel;
            }

            return null;
        }

        /// <summary>
        /// Validate Caution orders Grid
        /// </summary> 
        private Boolean Validate_CautionOrderGrid()
        {
            String CDfrom = "";
            String CDto = "";
            String CDspeed = "";

            DGV_CautionOrders.CommitEdit(DataGridViewDataErrorContexts.Commit);

            foreach (DataGridViewRow r in DGV_CautionOrders.Rows)
            {
                if (!r.IsNewRow)
                {
                    CDfrom = r.Cells["DgvCol_CDkmFrom"].Value.ToString() ?? "";
                    CDto = r.Cells["DgvCol_CDkmTo"].Value.ToString() ?? "";
                    CDspeed = r.Cells["DgvCol_CDspeed"].Value.ToString() ?? "";

                    if (!CDfrom.IsNumber())
                    {
                        Display.InfoMessage($"Invalid CD from Km {CDfrom} @ Row {r.Index + 1}");
                        return false;
                    }
                    else if (!CDto.IsNumber())
                    {
                        Display.InfoMessage($"Invalid CD to Km {CDto} @ Row {r.Index + 1}");
                        return false;
                    }
                    else if (!CDspeed.IsNumber())
                    {
                        Display.InfoMessage($"Invalid CD speed {CDspeed} @ Row {r.Index + 1}");
                        return false;
                    }
                    else return true;
                }
            }
            return true;
        }

        /// <summary>
        /// Validate Sectional speed Grid
        /// </summary> 
        private Boolean Validate_SectionalSpeedGrid()
        {
            String SectionKmfrom = "";
            String SectionKmTo = "";
            String SectionSpeed = "";

            Dgv_SectionalSpeed.CommitEdit(DataGridViewDataErrorContexts.Commit);

            foreach (DataGridViewRow r in Dgv_SectionalSpeed.Rows)
            {
                if (!r.IsNewRow)
                {
                    SectionKmfrom = r.Cells["DgvCol_SectionSpeedFrom"].Value.ToString() ?? "";
                    SectionKmTo = r.Cells["DgvCol_SectionSpeedTo"].Value.ToString() ?? "";
                    SectionSpeed = r.Cells["DgvCol_SectionSpeed"].Value.ToString() ?? "";

                    if (!SectionKmfrom.IsNumber())
                    {
                        Display.InfoMessage($"Invalid Section from Km {SectionKmfrom} @ Row {r.Index + 1}");
                        return false;
                    }
                    else if (!SectionKmTo.IsNumber())
                    {
                        Display.InfoMessage($"Invalid Section to Km {SectionKmTo} @ Row {r.Index + 1}");
                        return false;
                    }
                    else if (!SectionSpeed.IsNumber())
                    {
                        Display.InfoMessage($"Invalid Section speed {SectionSpeed} @ Row {r.Index + 1}");
                        return false;
                    }
                    else return true;
                }
            }
            return true;
        }

        /// <summary>
        /// Validate Block sectioning grid
        /// </summary> 
        private Boolean Validate_BlockSectioningGrid()
        {
            String BlockSectionName = "";
            String SectionKmFrom = "";
            String SectionKmTo = "";

            Dgv_BlockSectionPartition.CommitEdit(DataGridViewDataErrorContexts.Commit);

            foreach (DataGridViewRow r in Dgv_BlockSectionPartition.Rows)
            {
                if (!r.IsNewRow)
                {
                    BlockSectionName = r.Cells["DgvCol_SectionSpeedFrom"].Value.ToString() ?? "";
                    SectionKmFrom = r.Cells["DgvCol_SectionSpeedTo"].Value.ToString() ?? "";
                    SectionKmFrom = r.Cells["DgvCol_SectionSpeed"].Value.ToString() ?? "";

                    if (BlockSectionName == "")
                    {
                        Display.InfoMessage($"Invalid Bock section name {BlockSectionName} @ Row {r.Index + 1}");
                        return false;
                    }
                    else if (!SectionKmFrom.IsNumber())
                    {
                        Display.InfoMessage($"Invalid Block Section to Km {SectionKmFrom} @ Row {r.Index + 1}");
                        return false;
                    }
                    else if (!SectionKmFrom.IsNumber())
                    {
                        Display.InfoMessage($"Invalid Block Section to km {SectionKmFrom} @ Row {r.Index + 1}");
                        return false;
                    }
                    else return true;
                }
            }
            return true;
        }

        /// <summary>
        /// Get the Sectional Speed Grid
        /// </summary>
        /// <returns>SecionalSpeedModel</returns>
        private List<Models.SectionalSpeedModel> Get_SectionalSpeedList()
        {

            List<Models.SectionalSpeedModel> sectionalSpeedList = new List<Models.SectionalSpeedModel>();

            double FromKms, ToKms;
            Int16 speed;

            foreach (DataGridViewRow r in Dgv_SectionalSpeed.Rows)
            {
                if (!r.IsNewRow)
                {
                    FromKms = r.Cells["DgvCol_SectionSpeedFrom"].Value.ToString().ConvertToDouble();
                    ToKms = r.Cells["DgvCol_SectionSpeedTo"].Value.ToString().ConvertToDouble();
                    speed = r.Cells["DgvCol_SectionSpeed"].Value.ToString().ConvertToInt();

                    sectionalSpeedList.Add(
                        new Models.SectionalSpeedModel
                        {
                            SectionalSpeedFromKms = FromKms,
                            SectionalSpeedToKms = ToKms,
                            SectionalSpeed = speed
                        }
                        );
                }

            }

            return sectionalSpeedList;

        }

        /// <summary>
        /// Get the caution orders Grid
        /// </summary>
        /// <returns>CautionOrderModel</returns>
        private List<Models.CautionOrderModel> Get_CautionOrderList()
        {

            List<Models.CautionOrderModel> cautionorderList = new List<Models.CautionOrderModel>();

            double cdFromKms, cdToKms;
            Int16 speed;

            foreach (DataGridViewRow r in DGV_CautionOrders.Rows)
            {
                if (!r.IsNewRow)
                {
                    cdFromKms = r.Cells["DgvCol_CDkmFrom"].Value.ToString().ConvertToDouble();
                    cdToKms = r.Cells["DgvCol_CDkmTo"].Value.ToString().ConvertToDouble();
                    speed = r.Cells["DgvCol_CDspeed"].Value.ToString().ConvertToInt();

                    cautionorderList.Add(
                        new Models.CautionOrderModel
                        {
                            CautionOrderFrom = cdFromKms,
                            CautionOrderTo = cdToKms,
                            SpeedRestriction = speed
                        }
                        );
                }

            }

            return cautionorderList;

        }

        /// <summary>
        /// Get the Block section Partition
        /// </summary>
        /// <returns>BlockSecionModel</returns>
        private List<Models.BlockSecionModel> Get_BlockSectionPartitionList()
        {

            List<Models.BlockSecionModel> blockSectionModelList = new List<Models.BlockSecionModel>();

            double FromKms, ToKms;
            String BlockSectionName;

            foreach (DataGridViewRow r in Dgv_BlockSectionPartition.Rows)
            {
                if (!r.IsNewRow)
                {
                    FromKms = r.Cells["DgvCol_BlockSectionStartKm"].Value.ToString().ConvertToDouble();
                    ToKms = r.Cells["DgvCol_BlockSectionToKm"].Value.ToString().ConvertToDouble();
                    BlockSectionName = r.Cells["DgvCol_BlockSectionName"].Value.ToString();

                    blockSectionModelList.Add(
                        new Models.BlockSecionModel
                        {
                            BlockStartKms = FromKms,
                            BlockEndKms = ToKms,
                            BlockSectionName = BlockSectionName
                        }
                        );
                }

            }

            return blockSectionModelList;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Cbo_SpeedometerType.DataSource = Models.EventDataTypesModel.EventDataModelTypesList();
        }

        private void DGV_CautionOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 &&
                !DGV_CautionOrders.Rows[e.RowIndex].IsNewRow &&
                Display.InfoDecission("Delete the Caution order row ?") == true)
            {
                DGV_CautionOrders.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Dgv_SectionalSpeed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 &&
                !Dgv_SectionalSpeed.Rows[e.RowIndex].IsNewRow &&
                Display.InfoDecission("Delete the Sectional Speed row ?") == true)
            {
                Dgv_SectionalSpeed.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Dgv_BlockSectionPartition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 &&
                !Dgv_BlockSectionPartition.Rows[e.RowIndex].IsNewRow &&
                Display.InfoDecission("Delete Block section row ?") == true)
            {
                Dgv_BlockSectionPartition.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Txt_ExcelPath_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_ExcelPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog O = new OpenFileDialog();
            O.Filter = "Excel files|*.xls;*.xlsx;";
            O.Multiselect = false;
            O.Title = "Direct to Event data file";


            if (O.ShowDialog() == DialogResult.OK)
            {
                Txt_ExcelPath.Text = O.FileName;
            }
            else
            {
                Txt_ExcelPath.Text = "";
                O.Dispose();
            }
        }
    }
}
