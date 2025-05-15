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
using System.Windows.Forms.VisualStyles;

namespace SPM_WINFM.UI
{
    public partial class JournalTimeAppenderDialog : Form
    {
        public JournalTimeAppenderDialog(String BlockSection)
        {
            InitializeComponent();

            _blockSection = BlockSection;
        }

        private String _blockSection { get; set; }
        private  DateTime GetDepartureTime()
        {
            if (TimingsValidated())
            {
                return Dtp_DepartureTime.Value;
            }
            else return DateTime.Now;

        }

        public DateTime _GetArrivalTime { get { return Dtp_ArrivalTime.Value; } }
        public DateTime _GetDepartureTime { get { return GetDepartureTime(); } }

        private Boolean _isCancelled = false;
        public Boolean Cancelled { get { return _isCancelled; } }

        private void JournalTimeAppenderDialog_Load(object sender, EventArgs e)
        {
            Lbl_BlockSection.Text = $"Block Section : {_blockSection}";
        }

        public Boolean TimingsValidated()
        {
            if (Dtp_ArrivalTime.Value < Dtp_DepartureTime.Value)
            {
                _isCancelled = true;
                Display.InfoMessage("Train Arrival Time is More than the Departure time");

                return false;
            }
            else
            {
                _isCancelled = false;
                return true;
            }

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            
            _isCancelled = true;
            this.Close();
            

          //  MessageBox.Show(Dtp_ArrivalTime.Value.ToString("dd/MM/yy HH:mm:ss").ConvertToDateTime("dd/MM/yy HH:mm:ss").ToString());


        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
                       this.Close();

        }
    }
}
