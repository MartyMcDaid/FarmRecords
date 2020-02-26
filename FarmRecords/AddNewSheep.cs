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
    public partial class AddNewSheep : Form
    {
        Utilities utils = new Utilities();

        public MainMenu refToMainMenu { get; set; }

        public SheepForm refToSheep { get; set; }

        public AddNewSheep()
        {
            InitializeComponent();
        }

        private void addSheepClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddNewReturnToSheep_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.ReturnToSheep();
            if (result == DialogResult.OK)
            {
                this.refToSheep.Show();
                this.Close();
            }
        }

        private void addSheepMain_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.ReturnToMain();
            if (result == DialogResult.OK)
            {
                this.refToMainMenu.Show();
                this.Close();
            }
        }

        private void addSheepExit_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.Exit();
            if (result == DialogResult.OK)
            {
                this.Close();
                this.refToSheep.Close();
                this.refToMainMenu.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.Exit();
            if (result == DialogResult.OK)
            {
                this.Close();
                this.refToSheep.Close();
                this.refToMainMenu.Close();
            }
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.ReturnToMain();
            if (result == DialogResult.OK)
            {
                this.refToMainMenu.Show();
                this.Close();
            }
        }

        private void returnToSheepMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.ReturnToSheep();
            if (result == DialogResult.OK)
            {
                this.refToSheep.Show();
                this.Close();
            }
        }
    }
}
