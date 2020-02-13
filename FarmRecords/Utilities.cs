using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmRecords
{
    /*The Utilities class is used to call methods that
        will be used by the other classes*/

    class Utilities
    {
        /*The DialogResult Exit() method can be called to ask the user if they are sure
         * they want to exit the program*/

        public DialogResult Exit()
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.OKCancel);
            return result;
        }
    }
}
