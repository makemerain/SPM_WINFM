using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM_WINFM.GlobalFunctions
{
    public static class Display
    {
        public static void InfoMessage(String Message)
        {
            MessageBox.Show(Message, "BALU- Data Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static Boolean InfoDecission(String Message)
        {
            var result = MessageBox.Show(Message, "BALU- Data Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result == DialogResult.OK;
        }
    }
}
