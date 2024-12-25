using MAUI_SPM.ApplicationTools;

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
        public FrmDataAnalysis(DataFilterParams datafilterparams)
        {
            InitializeComponent();
            this._FilterParams = datafilterparams;
            _dataRepository = new DataRepositoryManager(_FilterParams);
        }

        private DataFilterParams _FilterParams = new DataFilterParams();
        private DataRepositoryManager _dataRepository;
        
        private void FrmDataAnalysis_Load(object sender, EventArgs e)
        {
            Dgv_Analysis.DataSource = _dataRepository.GetMedhaSpeedometerData();
        }
    }
}
