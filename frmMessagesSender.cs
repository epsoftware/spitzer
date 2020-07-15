using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

using Microsoft.VisualBasic.FileIO;
using Telerik.WinControls.UI;
using Telerik.WinControls;



namespace FrmMain
{
    public partial class frmMessagesSender : Telerik.WinControls.UI.RadForm
    {

        public DataTable techReminders;
        public DataColumn dtColumn;
        public DataRow techRow;

        public frmMessagesSender()
        {
            InitializeComponent();
            //radDateTimePicker_From.ValueChanged -= new ValueChangedEventHandler(radDateTimePicker_From.ValueChanged);
            this.radDateTimePicker_From.ValueChanged -= new System.EventHandler(this.radDateTimePicker_From_ValueChanged);

            radDateTimePicker_From.NullText = "Select Date";
            radDateTimePicker_From.NullableValue = null;
            radDateTimePicker_From.SetToNullValue();

            radDateTimePicker_From.MinDate = DateTime.Now;
            radDateTimePicker_From.MaxDate = DateTime.Now.AddDays(+7);

            radBtn_Send.Enabled = false;

            this.radDateTimePicker_From.ValueChanged += new System.EventHandler(this.radDateTimePicker_From_ValueChanged);

        }

        private bool loadTechReminders()
        {
            bool status = true;
   // ==> Change later         string postgresConnectionString = PostgresDBManagement.ConnectToPostgres("Staging");

            //if (String.IsNullOrEmpty(postgresConnectionString))
            //{
            //    MessageBox.Show("The Database connection is invalid, Please contact the System Administrator", "Error: Loading email from USER tablr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    // ==> Change later                   DataSet Reminders = PostgresDBManagement.getReminders(postgresConnectionString, radDateTimePicker_From.Value.ToString("yyyy-MM-dd"));
            //    techReminders = Reminders.Tables["reminders"];

            //    if (Reminders.Tables["reminders"].Rows.Count != 0)
            //    {
            //        status = true;
            //    }
            //    else
            //    {
            //        status = false;
            //    }
            //}
            return status;
        }

        private void CheckAllItem()
        {
            int item = 0;
            foreach (DataRow row in techReminders.Rows)
            {
                ListViewDataItem checkedItem = new ListViewDataItem("Checked item");
                this.radListView_Reminders.Items[item++].CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
            }
        }

        private void radBtn_Send_Click(object sender, EventArgs e)
        {
            var cntMsgs = 0;
            foreach (ListViewDataItem item in radListView_Reminders.CheckedItems)
            {
                cntMsgs++;
                radLabelElement_Msg.Text = "Sending message to: " + item["techname"];

                string datestring = item["servicedate"].ToString();
                DateTime serviceDt = DateTime.ParseExact(datestring, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                string techPhoneNbr = item["techphone"].ToString().Replace("(", "").Replace("-", "").Replace(")", "").Trim() + item["phoneCarrier"].ToString().Trim();

                Console.WriteLine(techPhoneNbr);

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("dg@scopesfs.com");

                var message = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                SmtpServer.Credentials = new System.Net.NetworkCredential("DG@scopesfs.com", "ScopesFloorCare!");
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;

                message.From = new MailAddress("dg@scopesfs.com");

                //  message.To.Add(new MailAddress("4046440394@tmomail.net"));//See carrier destinations below
                message.To.Add(new MailAddress(techPhoneNbr));

                message.Subject = "Scopes Floorcare - Your next service";
                message.Body = "Friendly reminder about your upcoming service scheduled for " + serviceDt.ToString("MM/dd/yyyy") + Environment.NewLine +
                                     "Time: " + item["servicetime"].ToString() + Environment.NewLine +
                                     "Store: " + item["store"].ToString() + Environment.NewLine +
                                     "City: " + item["city"].ToString() + Environment.NewLine +
                                     "State: " + item["statecd"].ToString() + Environment.NewLine +
                                     "Phone: " + item["contactphone"].ToString() + Environment.NewLine +
                                     "Floor: " + item["floortype"].ToString() + Environment.NewLine +
                                     "Note: " + item["note"].ToString() + Environment.NewLine + Environment.NewLine +
                                     "Please do not reply  to this automated message";

                //  Console.WriteLine(message.Body);

                //   SmtpServer.Send(message);


            }
            radLabelElement_Msg.Text = "A total of " + cntMsgs.ToString() + " messages were sent.";
            RadMessageBox.Show("The batch of messages has been sent succesfully.", "Message Center", MessageBoxButtons.OK, RadMessageIcon.Info);
            radBtn_Send.Enabled = false;

        }

        private void radListView_Reminders_ColumnCreating(object sender, Telerik.WinControls.UI.ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.FieldName == "techname")
            {
                e.Column.HeaderText = "Tech";
            }
            if (e.Column.FieldName == "store")
            {
                e.Column.HeaderText = "Store Number";
                e.Column.Width = 80;
            }
            if (e.Column.FieldName == "city")
            {
                e.Column.HeaderText = "City";
            }
            if (e.Column.FieldName == "statecd")
            {
                e.Column.HeaderText = "State";
                e.Column.Width = 50;
            }

            if (e.Column.FieldName == "contactphone")
            {
                e.Column.HeaderText = "Contact Phone";
                e.Column.Width = 100;
            }
            if (e.Column.FieldName == "techphone")
            {
                e.Column.Visible = false;
            }
            if (e.Column.FieldName == "phonecarrier")
            {
                e.Column.Visible = false;
            }
            if (e.Column.FieldName == "floortype")
            {
                e.Column.HeaderText = "Floor Type";
                e.Column.Width = 100;
            }
            if (e.Column.FieldName == "servicedate")
            {
                e.Column.HeaderText = "Service Date";
                e.Column.Width = 100;
            }
            if (e.Column.FieldName == "servicetime")
            {
                e.Column.HeaderText = "Service Time";
                e.Column.Width = 100;
            }
            if (e.Column.FieldName == "note")
            {
                e.Column.HeaderText = "Comments";
            }
            if (e.Column.FieldName == "isconfirmed")
            {
                e.Column.HeaderText = "Confirmed";
                e.Column.Width = 80;
            }
        }



        private void radDateTimePicker_From_ValueChanged(object sender, EventArgs e)
        {
            radLabelElement_Msg.Text = string.Empty;
            bool hasRows = loadTechReminders();

            if (hasRows == true)
            {
                // radListView_Reminders.Items.Clear();
                radListView_Reminders.DataSource = techReminders;
                radListView_Reminders.DisplayMember = "techname";
                radListView_Reminders.ValueMember = "techname";
                CheckAllItem();
                radBtn_Send.Enabled = true;
            }
            else
            {
                radBtn_Send.Enabled = false;
            }
        }
    }
}
    