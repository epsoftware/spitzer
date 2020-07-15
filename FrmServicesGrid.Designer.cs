namespace FrmMain
{
    partial class FrmServicesGrid
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
            this.components = new System.ComponentModel.Container();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.remindersBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();

            this.splitPanel3 = new Telerik.WinControls.UI.SplitPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radBtn_SearchStore = new Telerik.WinControls.UI.RadButton();
            this.radTxtBox_Store = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remindersBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.scopesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).BeginInit();
            this.splitPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_SearchStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtBox_Store)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Controls.Add(this.splitPanel3);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(1195, 450);
            this.radSplitContainer1.SplitterWidth = 4;
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            this.radSplitContainer1.ThemeName = "Office2007Silver";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radCalendar1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(256, 450);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1176636F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-94, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            this.splitPanel1.ThemeName = "Office2007Silver";
            // 
            // radCalendar1
            // 
            this.radCalendar1.AllowFishEye = true;
            this.radCalendar1.AllowMultipleView = true;
            this.radCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCalendar1.Location = new System.Drawing.Point(0, 0);
            this.radCalendar1.MultiViewRows = 2;
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.Size = new System.Drawing.Size(256, 450);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ThemeName = "Office2007Black";
            this.radCalendar1.SelectionChanged += new System.EventHandler(this.radCalendar1_SelectionChanged);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radGridView1);
            this.splitPanel2.Location = new System.Drawing.Point(260, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(777, 450);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.321258F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(280, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            this.splitPanel2.ThemeName = "Office2007Silver";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(777, 450);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Office2007Silver";
            // 
            // remindersBindingSource
            // 
            this.remindersBindingSource.DataMember = "Reminders";
//            this.remindersBindingSource.DataSource = this.scopesDataSet;
            // 
            // scopesDataSet
            // 
//            this.scopesDataSet.DataSetName = "ScopesDataSet";
 //           this.scopesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remindersTableAdapter
            // 
//            this.remindersTableAdapter.ClearBeforeFill = true;
            // 
            // splitPanel3
            // 
            this.splitPanel3.Controls.Add(this.radGroupBox1);
            this.splitPanel3.Location = new System.Drawing.Point(1041, 0);
            this.splitPanel3.Name = "splitPanel3";
            // 
            // 
            // 
            this.splitPanel3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel3.Size = new System.Drawing.Size(154, 450);
            this.splitPanel3.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.2035945F, 0F);
            this.splitPanel3.SizeInfo.SplitterCorrection = new System.Drawing.Size(-73, 0);
            this.splitPanel3.TabIndex = 2;
            this.splitPanel3.TabStop = false;
            this.splitPanel3.Text = "splitPanel3";
            this.splitPanel3.ThemeName = "Office2007Silver";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radTxtBox_Store);
            this.radGroupBox1.Controls.Add(this.radBtn_SearchStore);
            this.radGroupBox1.HeaderText = "Serch by Store";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(148, 100);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Serch by Store";
            // 
            // radBtn_SearchStore
            // 
            this.radBtn_SearchStore.Location = new System.Drawing.Point(6, 48);
            this.radBtn_SearchStore.Name = "radBtn_SearchStore";
            this.radBtn_SearchStore.Size = new System.Drawing.Size(137, 24);
            this.radBtn_SearchStore.TabIndex = 0;
            this.radBtn_SearchStore.Text = "Search";
            this.radBtn_SearchStore.Click += new System.EventHandler(this.radBtn_SearchStore_Click);
            // 
            // radTxtBox_Store
            // 
            this.radTxtBox_Store.Location = new System.Drawing.Point(6, 22);
            this.radTxtBox_Store.Name = "radTxtBox_Store";
            this.radTxtBox_Store.Size = new System.Drawing.Size(137, 20);
            this.radTxtBox_Store.TabIndex = 1;
            this.radTxtBox_Store.Text = "Store #";
            // 
            // FrmServicesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "FrmServicesGrid";
            this.Text = "FrmServicesGrid";
            this.Load += new System.EventHandler(this.FrmServicesGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remindersBindingSource)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.scopesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).EndInit();
            this.splitPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_SearchStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtBox_Store)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private ScopesDataSet scopesDataSet;
        private System.Windows.Forms.BindingSource remindersBindingSource;
        private ScopesDataSetTableAdapters.RemindersTableAdapter remindersTableAdapter;
        private Telerik.WinControls.UI.SplitPanel splitPanel3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox radTxtBox_Store;
        private Telerik.WinControls.UI.RadButton radBtn_SearchStore;
    }
}