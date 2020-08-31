﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmRecords
{
    class Utilities
    {
        //Exit Dialog Box
        public DialogResult Exit()
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.OKCancel);
            return result;
        }

        //Return to Main menu Dialog box
        public DialogResult ReturnToMain()
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to return to Main menu?", "Main Menu", MessageBoxButtons.OKCancel);
            return result;
        }

        //Return to Sheep Menu Dialog box
        internal DialogResult ReturnToSheep()
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to return to Sheep menu?", "Sheep Menu", MessageBoxButtons.OKCancel);
            return result;
        }

        //Clear Form Dialog Box
        internal DialogResult ClearForm()
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Clear form", "Clear Form", MessageBoxButtons.OKCancel);
            return result;
        }
    }
}
