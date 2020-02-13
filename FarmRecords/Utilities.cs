using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmRecords
{
    class Utilities
    {
        public DialogResult Exit()
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.OKCancel);
            return result;
        }

        public DialogResult ReturnToMain()
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Return To Main Menu?", "Main Menu", MessageBoxButtons.OKCancel);
            return result;
        }
    }
}
