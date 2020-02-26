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
    public partial class SheepForm : Form
    {
        Utilities utils = new Utilities();

        public MainMenu refToMainMenu { get; set; }

        public SheepForm()
        {
            InitializeComponent();
        }

        private void buttonAddNewSheep_Click(object sender, EventArgs e)
        {
            AddNewSheep addNewSheep = new AddNewSheep();
            addNewSheep.refToMainMenu = this.refToMainMenu;
            addNewSheep.refToSheep = this;
            this.Visible = false;
            addNewSheep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.ReturnToMain();
            if (result == DialogResult.OK)
            {
                this.refToMainMenu.Show();
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
             DialogResult result = utils.Exit();
            if (result == DialogResult.OK)
            {
                this.Close();
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

        private void addNewSheepToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewSheep addNewSheep = new AddNewSheep();
            addNewSheep.refToMainMenu = this.refToMainMenu;
            addNewSheep.refToSheep = this;
            this.Visible = false;
            addNewSheep.Show();
        }
    }
}
