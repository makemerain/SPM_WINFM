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
    public partial class JournalTimeAppenderDialog : Form
    {
        public JournalTimeAppenderDialog(String BlockSection)
        {
            InitializeComponent();

            _blockSection = BlockSection;
        }

        private String _blockSection { get; set; }
        public DateTime _GetDepartureTime { get { if (ValidateTimings()) return Dtp_DepartureTime.Value; } }

        public DateTime _GetArrivalTime { get { return Dtp_ArrivalTime.Value; } }

        private void JournalTimeAppenderDialog_Load(object sender, EventArgs e)
        {
            Lbl_BlockSection.Text = $"Block Section : {_blockSection}";
        }

        private Boolean ValidateTimings()
        {
            if (Dtp_ArrivalTime.Value < Dtp_DepartureTime.Value)
            {
                Display.InfoMessage("Train Arrival Time is More than the Departure time");
                return false;
            }
            else return true;
        }
    }
}
