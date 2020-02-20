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
            this.SheepMainMenuButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SheepExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // r3turnToMainMenuToolStripMenuItem
            // 
            this.r3turnToMainMenuToolStripMenuItem.Name = "r3turnToMainMenuToolStripMenuItem";
            this.r3turnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.r3turnToMainMenuToolStripMenuItem.Text = "&Return To Main Menu";
            this.r3turnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMainMenuToolStripMenuItem_Click);
            // 
            // SheepMainMenuButton
            // 
            this.SheepMainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SheepMainMenuButton.Location = new System.Drawing.Point(625, 415);
            this.SheepMainMenuButton.Name = "SheepMainMenuButton";
            this.SheepMainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.SheepMainMenuButton.TabIndex = 2;
            this.SheepMainMenuButton.Text = "&Main Menu";
            this.SheepMainMenuButton.UseVisualStyleBackColor = true;
            this.SheepMainMenuButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Add New Sheep";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit Sheep";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Dosplay All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Display Single";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FarmRecords.Properties.Resources.DSC_0740;
            this.pictureBox1.Location = new System.Drawing.Point(141, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SheepExitButton
            // 
            this.SheepExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SheepExitButton.Location = new System.Drawing.Point(703, 415);
            this.SheepExitButton.Name = "SheepExitButton";
            this.SheepExitButton.Size = new System.Drawing.Size(75, 23);
            this.SheepExitButton.TabIndex = 8;
            this.SheepExitButton.Text = "E&xit";
            this.SheepExitButton.UseVisualStyleBackColor = true;
            this.SheepExitButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sheep";
            // 
            // SheepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SheepExitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SheepMainMenuButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SheepForm";
            this.Text = "Sheep";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sheepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewSheepToolStripMenuItem1;
        private System.Windows.Forms.Button SheepMainMenuButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SheepExitButton;
        private System.Windows.Forms.ToolStripMenuItem r3turnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}