using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmRecords
{
    public partial class MainMenu : Form
    {
        Utilities utils = new Utilities();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.Exit();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = utils.Exit();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
