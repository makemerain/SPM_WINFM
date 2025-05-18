using MAUI_SPM.DataModels;

using SPM_WINFM.GlobalFunctions;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM_WINFM.UI
{
    public partial class Frm_StoppageFilter : Form
    {
        public Frm_StoppageFilter(List<Models.CommonDieselBindingEventDataModel> commonEventdatalist)
        {
            InitializeComponent();
            _commonEventdatalist = commonEventdatalist;

            if (_commonEventdatalist == null)
            {
                Display.InfoMessage("Event data list is empty, Hence no stoppage can be listed out");
                this.Close();
            }
            else
            {
                _eventMapManager = new EventAnalysysOutputMapping(_commonEventdatalist);
            }

        }

        List<Models.CommonDieselBindingEventDataModel> _commonEventdatalist = new();
        EventAnalysysOutputMapping _eventMapManager;

        private void Frm_StoppageFilter_Load(object sender, EventArgs e)
        {
            // Get the stoppages list from the METHOD
            // EventAnalysysOutputMapping.List<Models.CommonDieselBindingEventDataModel> Get_StoppagesList()
            // Then Choose the stoppages With proper labling
            // Then Load the list Models.StoppageLablingModel

            Dgv_StoppagesMapper.DataSource = _eventMapManager.Get_StoppagesList();

        }

        public List<Models.StoppageLablingModel> GetStoppagesList { get { return Get_StoppagesList(); } }
        public Boolean UserConfirmation { get { return _userConfirmation; } }
        private bool _userConfirmation = false;

        /// <summary>
        /// Retruns the Picked stoppages list
        /// </summary>
        /// <returns>List<Models.StoppageLablingModel></returns>
        private List<Models.StoppageLablingModel> Get_StoppagesList()
        {
            List<Models.StoppageLablingModel> _Stoppagelist = new();
            int rowid = 0;
            String StopLable = "";
            DateTime stoptime;
            Boolean IsPicked = false;

            // Check the null lables in the opted stoppages

            foreach (DataGridViewRow rx in Dgv_StoppagesMapper.Rows)
            {
                // Check for invalid lable at the opted rows
                if (!rx.IsNewRow)
                {
                    StopLable = rx.Cells["DgvCol_StopLable"].Value?.ToString();
                    IsPicked = rx.Cells["DgvCol_OptStoppage"].Value.ToString().ConvertToBoolean();

                    if (IsPicked && StopLable == "")
                    {
                        Display.InfoMessage($"Invalid Stop lable at Row {rx.Index + 1}");
                        return null;
                    }
                } else
                {
                        rowid = rx.Cells["DgvCol_StopLable"].Value.ToString().ConvertToInt();
                        StopLable = rx.Cells["DgvCol_StopLable"].Value.ToString();
                        stoptime = rx.Cells["DgvCol_RunDateAndTime"].Value.ToString().ConvertToDateTime("dd/MM/yy HH:mm:ss");

                        _Stoppagelist.Add(new Models.StoppageLablingModel
                        {
                            StopRowId = rowid,
                            StoppageLable = StopLable,
                            StopTime = stoptime
                        });
                }
            }
            
            return _Stoppagelist;
        }

        private void Btn_SaveStoppageList_Click(object sender, EventArgs e)
        {
            if (GetStoppagesList == null && Display.InfoDecission($"The stoppages list is empty, Would you like to Close the Grid ?") == true)
            {
                this.Close();
                _userConfirmation = false;
            }
            else if (Display.InfoDecission($"Close the Grid ?") == true)
            {
                this.Close();
                _userConfirmation = true;
            }
        }
    }
}
