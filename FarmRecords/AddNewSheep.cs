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

        //Button Controls

        //Clear Form
        private void addSheepClear_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.ClearForm();
            if (result == DialogResult.OK)
            {
                this.refToSheep.Show();
                this.txtBoxAddSheepHerd.Clear();
                this.txtBoxAddSheepTag.Clear();
                this.txtBoxAddSheepBreed.Clear();
                this.dateTimePickerBirthAddNew.Equals(DateTime.Now);
                this.dateTimePickerPurchaseAddNew.Equals(DateTime.Now);
                this.txtBoxAddSheepPurchaseDoc.Clear();
                this.radioButtonMaleAddNew.Checked.Equals(false);
                this.radioButtonFemaleAddNew.Checked.Equals(false);
                this.radioButtonActiveAddNew.Checked.Equals(false);
                this.radioButtonSoldAddNew.Checked.Equals(false);
                this.radioButtonLostAddNew.Checked.Equals(false);
                this.radioButtonEweAddNew.Checked.Equals(false);
                this.radioButtonRamAddNew.Checked.Equals(false);
                this.radioButtonLambAddNew.Checked.Equals(false);
                this.radioButtonHogAddNEw.Checked.Equals(false);
            }
        }

        //Return to Sheep Menu
        private void buttonAddNewReturnToSheep_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.ReturnToSheep();
            if (result == DialogResult.OK)
            {
                this.refToSheep.Show();
                this.Close();
            }
        }

        //Return To Main menu
        private void addSheepMain_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.ReturnToMain();
            if (result == DialogResult.OK)
            {
                this.refToMainMenu.Show();
                this.Close();
            }
        }

        //Exit
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

        //Tool Strip Controls

        //Tool Strip Exit
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

        //Tool Strip Return to main menu
        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = utils.ReturnToMain();
            if (result == DialogResult.OK)
            {
                this.refToMainMenu.Show();
                this.Close();
            }
        }

        //Tool Strip Return to Sheep Menu
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
