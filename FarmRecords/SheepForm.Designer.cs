namespace FarmRecords
{
    partial class SheepForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sheepToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSheepToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.r3turnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sheepMainMenuButton = new System.Windows.Forms.Button();
            this.buttonAddNewSheep = new System.Windows.Forms.Button();
            this.buttonEditSheep = new System.Windows.Forms.Button();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.buttonDisplaySingle = new System.Windows.Forms.Button();
            this.pictureBoxSheep = new System.Windows.Forms.PictureBox();
            this.sheepExitButton = new System.Windows.Forms.Button();
            this.labelSheepTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheep)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.sheepToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            // 
            // sheepToolStripMenuItem1
            // 
            this.sheepToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSheepToolStripMenuItem1,
            this.r3turnToMainMenuToolStripMenuItem});
            this.sheepToolStripMenuItem1.Name = "sheepToolStripMenuItem1";
            this.sheepToolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.sheepToolStripMenuItem1.Text = "&Sheep";
            // 
            // addNewSheepToolStripMenuItem1
            // 
            this.addNewSheepToolStripMenuItem1.Name = "addNewSheepToolStripMenuItem1";
            this.addNewSheepToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.addNewSheepToolStripMenuItem1.Text = "&Add New Sheep";
            this.addNewSheepToolStripMenuItem1.Click += new System.EventHandler(this.addNewSheepToolStripMenuItem1_Click);
            // 
            // r3turnToMainMenuToolStripMenuItem
            // 
            this.r3turnToMainMenuToolStripMenuItem.Name = "r3turnToMainMenuToolStripMenuItem";
            this.r3turnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.r3turnToMainMenuToolStripMenuItem.Text = "&Return To Main Menu";
            this.r3turnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMainMenuToolStripMenuItem_Click);
            // 
            // sheepMainMenuButton
            // 
            this.sheepMainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sheepMainMenuButton.Location = new System.Drawing.Point(625, 415);
            this.sheepMainMenuButton.Name = "sheepMainMenuButton";
            this.sheepMainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.sheepMainMenuButton.TabIndex = 2;
            this.sheepMainMenuButton.Text = "&Main Menu";
            this.sheepMainMenuButton.UseVisualStyleBackColor = true;
            this.sheepMainMenuButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // buttonAddNewSheep
            // 
            this.buttonAddNewSheep.Location = new System.Drawing.Point(32, 92);
            this.buttonAddNewSheep.Name = "buttonAddNewSheep";
            this.buttonAddNewSheep.Size = new System.Drawing.Size(94, 23);
            this.buttonAddNewSheep.TabIndex = 3;
            this.buttonAddNewSheep.Text = "&Add New Sheep";
            this.buttonAddNewSheep.UseVisualStyleBackColor = true;
            this.buttonAddNewSheep.Click += new System.EventHandler(this.buttonAddNewSheep_Click);
            // 
            // buttonEditSheep
            // 
            this.buttonEditSheep.Location = new System.Drawing.Point(32, 121);
            this.buttonEditSheep.Name = "buttonEditSheep";
            this.buttonEditSheep.Size = new System.Drawing.Size(94, 23);
            this.buttonEditSheep.TabIndex = 4;
            this.buttonEditSheep.Text = "Edit Sheep";
            this.buttonEditSheep.UseVisualStyleBackColor = true;
            this.buttonEditSheep.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.Location = new System.Drawing.Point(32, 150);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(94, 23);
            this.buttonDisplayAll.TabIndex = 5;
            this.buttonDisplayAll.Text = "Dosplay All";
            this.buttonDisplayAll.UseVisualStyleBackColor = true;
            this.buttonDisplayAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDisplaySingle
            // 
            this.buttonDisplaySingle.Location = new System.Drawing.Point(32, 179);
            this.buttonDisplaySingle.Name = "buttonDisplaySingle";
            this.buttonDisplaySingle.Size = new System.Drawing.Size(94, 23);
            this.buttonDisplaySingle.TabIndex = 6;
            this.buttonDisplaySingle.Text = "Display Single";
            this.buttonDisplaySingle.UseVisualStyleBackColor = true;
            this.buttonDisplaySingle.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBoxSheep
            // 
            this.pictureBoxSheep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSheep.Image = global::FarmRecords.Properties.Resources.DSC_0740;
            this.pictureBoxSheep.Location = new System.Drawing.Point(141, 92);
            this.pictureBoxSheep.Name = "pictureBoxSheep";
            this.pictureBoxSheep.Size = new System.Drawing.Size(559, 314);
            this.pictureBoxSheep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSheep.TabIndex = 7;
            this.pictureBoxSheep.TabStop = false;
            // 
            // sheepExitButton
            // 
            this.sheepExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sheepExitButton.Location = new System.Drawing.Point(703, 415);
            this.sheepExitButton.Name = "sheepExitButton";
            this.sheepExitButton.Size = new System.Drawing.Size(75, 23);
            this.sheepExitButton.TabIndex = 8;
            this.sheepExitButton.Text = "E&xit";
            this.sheepExitButton.UseVisualStyleBackColor = true;
            this.sheepExitButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelSheepTitle
            // 
            this.labelSheepTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSheepTitle.AutoSize = true;
            this.labelSheepTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSheepTitle.Location = new System.Drawing.Point(377, 43);
            this.labelSheepTitle.Name = "labelSheepTitle";
            this.labelSheepTitle.Size = new System.Drawing.Size(66, 26);
            this.labelSheepTitle.TabIndex = 9;
            this.labelSheepTitle.Text = "Sheep";
            // 
            // SheepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSheepTitle);
            this.Controls.Add(this.sheepExitButton);
            this.Controls.Add(this.pictureBoxSheep);
            this.Controls.Add(this.buttonDisplaySingle);
            this.Controls.Add(this.buttonDisplayAll);
            this.Controls.Add(this.buttonEditSheep);
            this.Controls.Add(this.buttonAddNewSheep);
            this.Controls.Add(this.sheepMainMenuButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SheepForm";
            this.Text = "Sheep";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sheepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewSheepToolStripMenuItem1;
        private System.Windows.Forms.Button sheepMainMenuButton;
        private System.Windows.Forms.Button buttonAddNewSheep;
        private System.Windows.Forms.Button buttonEditSheep;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.Button buttonDisplaySingle;
        private System.Windows.Forms.PictureBox pictureBoxSheep;
        private System.Windows.Forms.Button sheepExitButton;
        private System.Windows.Forms.ToolStripMenuItem r3turnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Label labelSheepTitle;
    }
}