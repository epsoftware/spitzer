namespace FrmMain
{
    partial class frmMessagesSender
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
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radListView_Reminders = new Telerik.WinControls.UI.RadListView();
            this.radDateTimePicker_From = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radBtn_Send = new Telerik.WinControls.UI.RadButton();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement_Msg = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListView_Reminders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radListView_Reminders);
            this.radGroupBox2.Controls.Add(this.radDateTimePicker_From);
            this.radGroupBox2.HeaderText = "Select Date and Techs to be notified ";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(661, 377);
            this.radGroupBox2.TabIndex = 5;
            this.radGroupBox2.Text = "Select Date and Techs to be notified ";
            // 
            // radListView_Reminders
            // 
            this.radListView_Reminders.HeaderHeight = 25F;
            this.radListView_Reminders.ItemSpacing = -1;
            this.radListView_Reminders.Location = new System.Drawing.Point(22, 60);
            this.radListView_Reminders.Margin = new System.Windows.Forms.Padding(1);
            this.radListView_Reminders.Name = "radListView_Reminders";
            this.radListView_Reminders.ShowCheckBoxes = true;
            this.radListView_Reminders.ShowGridLines = true;
            this.radListView_Reminders.Size = new System.Drawing.Size(628, 302);
            this.radListView_Reminders.TabIndex = 2;
            this.radListView_Reminders.Text = "radListView1";
            this.radListView_Reminders.ThemeName = "Desert";
            this.radListView_Reminders.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // radDateTimePicker_From
            // 
            this.radDateTimePicker_From.Location = new System.Drawing.Point(22, 21);
            this.radDateTimePicker_From.Name = "radDateTimePicker_From";
            this.radDateTimePicker_From.Size = new System.Drawing.Size(164, 20);
            this.radDateTimePicker_From.TabIndex = 0;
            this.radDateTimePicker_From.TabStop = false;
            this.radDateTimePicker_From.Text = "Friday, July 10, 2020";
            this.radDateTimePicker_From.Value = new System.DateTime(2020, 7, 10, 13, 0, 59, 791);
            this.radDateTimePicker_From.ValueChanged += new System.EventHandler(this.radDateTimePicker_From_ValueChanged);
            // 
            // radBtn_Send
            // 
            this.radBtn_Send.Location = new System.Drawing.Point(513, 395);
            this.radBtn_Send.Name = "radBtn_Send";
            this.radBtn_Send.Size = new System.Drawing.Size(160, 28);
            this.radBtn_Send.TabIndex = 6;
            this.radBtn_Send.Text = "Send";
            this.radBtn_Send.Click += new System.EventHandler(this.radBtn_Send_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement_Msg});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 433);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(679, 24);
            this.radStatusStrip1.TabIndex = 7;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // radLabelElement_Msg
            // 
            this.radLabelElement_Msg.AccessibleDescription = "radLabelElement1";
            this.radLabelElement_Msg.AccessibleName = "radLabelElement1";
            this.radLabelElement_Msg.Name = "radLabelElement_Msg";
            this.radStatusStrip1.SetSpring(this.radLabelElement_Msg, false);
            this.radLabelElement_Msg.Text = "radLabelElement1";
            this.radLabelElement_Msg.TextWrap = true;
            this.radLabelElement_Msg.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // frmMessagesSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 457);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radBtn_Send);
            this.Controls.Add(this.radGroupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMessagesSender";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Message Center";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListView_Reminders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtn_Send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker_From;
        private Telerik.WinControls.UI.RadButton radBtn_Send;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement_Msg;
        private Telerik.WinControls.UI.RadListView radListView_Reminders;
    }
}
