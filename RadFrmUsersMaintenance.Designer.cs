namespace FrmMain
{
    partial class RadFrmUsersMaintenance
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
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radBtn_Cancel = new Telerik.WinControls.UI.RadButton();
            this.radBtn_Save = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGridView1);
            this.radGroupBox1.HeaderText = "Working with Users";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(702, 307);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Working with Users";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(2, 18);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(698, 287);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // radBtn_Cancel
            // 
            this.radBtn_Cancel.Location = new System.Drawing.Point(554, 323);
            this.radBtn_Cancel.Margin = new System.Windows.Forms.Padding(1);
            this.radBtn_Cancel.Name = "radBtn_Cancel";
            this.radBtn_Cancel.Size = new System.Drawing.Size(160, 28);
            this.radBtn_Cancel.TabIndex = 3;
            this.radBtn_Cancel.Text = "Cancel";
            this.radBtn_Cancel.ThemeName = "Breeze";
            // 
            // radBtn_Save
            // 
            this.radBtn_Save.Location = new System.Drawing.Point(14, 323);
            this.radBtn_Save.Margin = new System.Windows.Forms.Padding(1);
            this.radBtn_Save.Name = "radBtn_Save";
            this.radBtn_Save.Size = new System.Drawing.Size(160, 28);
            this.radBtn_Save.TabIndex = 4;
            this.radBtn_Save.Text = "Save";
            this.radBtn_Save.ThemeName = "Breeze";
            this.radBtn_Save.Click += new System.EventHandler(this.radBtn_Save_Click);
            // 
            // RadFrmUsersMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 359);
            this.Controls.Add(this.radBtn_Save);
            this.Controls.Add(this.radBtn_Cancel);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RadFrmUsersMaintenance";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Users Maintenance";
            this.ThemeName = "Office2010Silver";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radBtn_Cancel;
        private Telerik.WinControls.UI.RadButton radBtn_Save;
    }
}
