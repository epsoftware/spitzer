namespace FrmMain
{
    partial class FrmScheduler
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
            Telerik.WinControls.UI.AppointmentMappingInfo appointmentMappingInfo1 = new Telerik.WinControls.UI.AppointmentMappingInfo();
            Telerik.WinControls.UI.ResourceMappingInfo resourceMappingInfo1 = new Telerik.WinControls.UI.ResourceMappingInfo();
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.schedulerBindingDataSource1 = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radSchedulerReminder1 = new Telerik.WinControls.UI.RadSchedulerReminder(this.components);
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerBindingDataSource1
            // 
            // 
            // 
            // 
            this.schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo1;
            // 
            // 
            // 
            this.schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo1;
            // 
            // radScheduler1
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            dateTimeInterval1.Start = new System.DateTime(((long)(0)));
            this.radScheduler1.AccessibleInterval = dateTimeInterval1;
            this.radScheduler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.DataSource = null;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(443, 185);
            this.radScheduler1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2020, 5, 13, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(1664, 1115);
            this.radScheduler1.TabIndex = 0;
            this.radScheduler1.Text = "radScheduler1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(2088, 116);
            this.radSchedulerNavigator1.TabIndex = 1;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            // 
            // radSchedulerReminder1
            // 
            this.radSchedulerReminder1.AssociatedScheduler = null;
            this.radSchedulerReminder1.StartNotification = System.TimeSpan.Parse("00:15:00");
            this.radSchedulerReminder1.ThemeName = null;
            this.radSchedulerReminder1.TimeInterval = 60000;
            // 
            // radCalendar1
            // 
            this.radCalendar1.AllowMultipleView = true;
            this.radCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radCalendar1.Location = new System.Drawing.Point(0, 185);
            this.radCalendar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCalendar1.MultiViewRows = 2;
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.Size = new System.Drawing.Size(425, 845);
            this.radCalendar1.TabIndex = 2;
            this.radCalendar1.Text = "radCalendar1";
            // 
            // FrmScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2116, 1207);
            this.Controls.Add(this.radCalendar1);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Controls.Add(this.radScheduler1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmScheduler";
            this.Text = "FrmScheduler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmScheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.SchedulerBindingDataSource schedulerBindingDataSource1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadSchedulerReminder radSchedulerReminder1;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
    }
}