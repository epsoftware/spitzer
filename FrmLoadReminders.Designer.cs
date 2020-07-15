namespace FrmMain
{
    partial class FrmLoadReminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadReminders));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.radBtn_Execute = new Telerik.WinControls.UI.RadButton();
            this.radTxtBox_Source = new Telerik.WinControls.UI.RadTextBox();
            this.radBtn_Source = new Telerik.WinControls.UI.RadButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radDD_Year = new Telerik.WinControls.UI.RadDropDownList();
            this.radDD_Months = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Execute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtBox_Source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDD_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDD_Months)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radDD_Months);
            this.radGroupBox1.Controls.Add(this.radDD_Year);
            this.radGroupBox1.Controls.Add(this.radWaitingBar1);
            this.radGroupBox1.Controls.Add(this.radBtn_Execute);
            this.radGroupBox1.Controls.Add(this.radTxtBox_Source);
            this.radGroupBox1.Controls.Add(this.radBtn_Source);
            this.radGroupBox1.HeaderText = "Select Source and Target destinations";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 10);
            this.radGroupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(1, 8, 1, 1);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(1, 8, 1, 1);
            this.radGroupBox1.Size = new System.Drawing.Size(635, 197);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Select Source and Target destinations";
            this.radGroupBox1.ThemeName = "Office2007Silver";
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(14, 165);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.ShowText = true;
            this.radWaitingBar1.Size = new System.Drawing.Size(400, 17);
            this.radWaitingBar1.TabIndex = 16;
            this.radWaitingBar1.Text = "Uploading Reminders";
            this.radWaitingBar1.ThemeName = "Office2007Silver";
            this.radWaitingBar1.WaitingSpeed = 100;
            this.radWaitingBar1.WaitingStep = 3;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Throbber;
            // 
            // radBtn_Execute
            // 
            this.radBtn_Execute.BackColor = System.Drawing.Color.ForestGreen;
            this.radBtn_Execute.Location = new System.Drawing.Point(460, 165);
            this.radBtn_Execute.Name = "radBtn_Execute";
            this.radBtn_Execute.Size = new System.Drawing.Size(160, 28);
            this.radBtn_Execute.TabIndex = 15;
            this.radBtn_Execute.Text = "Execute";
            this.radBtn_Execute.ThemeName = "Office2007Silver";
            this.radBtn_Execute.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radTxtBox_Source
            // 
            this.radTxtBox_Source.Location = new System.Drawing.Point(14, 26);
            this.radTxtBox_Source.Name = "radTxtBox_Source";
            this.radTxtBox_Source.Size = new System.Drawing.Size(400, 20);
            this.radTxtBox_Source.TabIndex = 14;
            this.radTxtBox_Source.Text = "-- Source file --";
            this.radTxtBox_Source.ThemeName = "Office2007Silver";
            // 
            // radBtn_Source
            // 
            this.radBtn_Source.BackColor = System.Drawing.Color.ForestGreen;
            this.radBtn_Source.Image = ((System.Drawing.Image)(resources.GetObject("radBtn_Source.Image")));
            this.radBtn_Source.ImageKey = "iconfinder_logo_brand_brands_logos_excel_2993694.png";
            this.radBtn_Source.Location = new System.Drawing.Point(420, 26);
            this.radBtn_Source.Name = "radBtn_Source";
            this.radBtn_Source.Size = new System.Drawing.Size(200, 40);
            this.radBtn_Source.TabIndex = 13;
            this.radBtn_Source.Text = "Select Excel file";
            this.radBtn_Source.ThemeName = "Office2007Silver";
            this.radBtn_Source.Click += new System.EventHandler(this.radBtn_Source_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 212);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(656, 26);
            this.radStatusStrip1.TabIndex = 3;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2007Silver";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "";
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radDD_Year
            // 
            this.radDD_Year.Location = new System.Drawing.Point(14, 66);
            this.radDD_Year.Name = "radDD_Year";
            this.radDD_Year.Size = new System.Drawing.Size(125, 20);
            this.radDD_Year.TabIndex = 17;
            this.radDD_Year.Text = "Select Year";
            this.radDD_Year.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDD_Year_SelectedIndexChanged);
            // 
            // radDD_Months
            // 
            this.radDD_Months.Location = new System.Drawing.Point(155, 66);
            this.radDD_Months.Name = "radDD_Months";
            this.radDD_Months.Size = new System.Drawing.Size(125, 20);
            this.radDD_Months.TabIndex = 18;
            this.radDD_Months.Text = "Select Month";
            this.radDD_Months.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDD_Months_SelectedIndexChanged);
            // 
            // FrmLoadReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 238);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmLoadReminders";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Up-load reminders";
            this.ThemeName = "Office2007Black";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Execute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtBox_Source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDD_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDD_Months)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.RadButton radBtn_Execute;
        private Telerik.WinControls.UI.RadTextBox radTxtBox_Source;
        private Telerik.WinControls.UI.RadButton radBtn_Source;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadDropDownList radDD_Months;
        private Telerik.WinControls.UI.RadDropDownList radDD_Year;
    }
}