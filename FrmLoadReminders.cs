using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ClosedXML.Excel; // via Nuget (ClosedXML)
using System.Linq;
using System.Data.OleDb;

// Download via Nuget: via nuget , search for: Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel; // via nuget , search for: Microsoft.Office.Interop.Excel; 

// In Solution Explorer, right-click your project's name and then click Add Reference. The Add Reference dialog box appears.
// On the Assemblies page, select Microsoft.Office.Interop.Word in the Component Name list, and then hold down the CTRL key and select Microsoft.Office.Interop.Excel.
// If you do not see the assemblies, you may need to ensure they are installed and displayed.



namespace FrmMain
{

    public partial class FrmLoadReminders : Telerik.WinControls.UI.RadForm
    {

        string[] itemsYears = new string[] { "Select Year", "2020", "2021", "2022", "2023", "2024", "2025"};
        string[] itemsMonths = new string[] { "Select Month","JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};
        string YYYYMM = string.Empty;

        private DataTable tableFromExcel = GetTable(); 

        public FrmLoadReminders()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            radWaitingBar1.Visible = false;

            radDD_Year.DataSource = itemsYears;
            radDD_Months.DataSource = itemsMonths;

            this.radDD_Year.SelectedIndex = 0;
            this.radDD_Months.SelectedIndex = 0;


        }

        private void radBtn_Source_Click(object sender, EventArgs e)
        {
            radTxtBox_Source.Text = "";

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Excel Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "xlsx files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                radTxtBox_Source.Text = openFileDialog1.FileName;
                // bool ws = validateWorkSheetName(openFileDialog1.SafeFileName());
                bool ws = validateWorkSheetName(System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName));
            }
        } // End 

        private bool validateWorkSheetName(string fileName)
        {

            bool status = true;

            if (fileName.StartsWith("Reminders") == false)
            {
                RadMessageBox.SetThemeName("Desert");

                RadMessageBox.Show("You have selected an invalid file. Please try again.", "Up-loading reminders", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                status = false;
            }
            return status;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            bool isValidate = ValidateInputs();

            if (isValidate == true)
            {

                YYYYMM = radDD_Year.Text + "-" + radDD_Months.Text;
                // #1
                radWaitingBar1.Visible = true;

                // ==> Awaiting Bar
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                    this.radWaitingBar1.StartWaiting();
                }
            }
            else
            {
                MessageBox.Show("Invalid entries");
                radTxtBox_Source.Focus();
            }
        } // End

        private bool ValidateInputs()
        {
            bool Status = true;
            if (radDD_Year.Text == "Select Year" || radDD_Months.Text == "Select Month" || radTxtBox_Source.Text == "--Source file--")
            {
                Status = false;
            }
            return Status;
        }

        private bool SubmitJobs()
        {
            bool Status = true;

            // #1
            bool isError = DatabaseManagement.DeleteServices("EPINEDA-DELL", "Scopes", YYYYMM, "Services_Imported");
            if (isError == false)
            {
                Status = false;
            }
            if (Status == true )
            {
                isError = ImportServices();
                if (isError == false)
                {
                    Status = false;
                }
            }
            if (Status == true)
            {
                isError = LoadServicesData(); 
                if (isError == false)
                {
                    Status = false;
                }
            }
            return Status;
        }

private bool ImportServices()
        {

            bool status = true;
            string FileName = radTxtBox_Source.Text;

                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");

                    da.Fill(tableFromExcel);

                    bool Status = DatabaseManagement.LoadServices("EPINEDA-DELL", "Scopes", YYYYMM, tableFromExcel);
                    if (Status == false)
                    {
                        status = false;
                        MessageBox.Show("Error in connection");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    status = false;
                    File.AppendAllText(@"C:\Scopes_AppFiles\logFiles\" + "Spitzer-log.txt", DateTime.Today.ToString("g") + " - frmLoadReminders - Error in method => Process,Start " + ex.Message.ToString() + Environment.NewLine);
                }

            return status;
        }

        private bool LoadServicesData()
        {
            bool Status = true;

            bool isErrorDeleting = DatabaseManagement.DeleteServices("EPINEDA-DELL", "Scopes", YYYYMM, "Services");
            if (isErrorDeleting == true)
            {
                bool isErrorInserting = DatabaseManagement.InsertServices("EPINEDA-DELL", "Scopes", YYYYMM, tableFromExcel);
                if (isErrorInserting == false)
                {
                    Status = false;
                }
            }
            else
            {
                Status = false;
            }

            return Status;
        }





        static DataTable GetTable()
        {

            DataTable table = new DataTable();
            DataColumn column;

            // [Store]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Store";
            column.Caption = "Store";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [Address]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Address";
            column.Caption = "Adress";
            column.ReadOnly = true;
            table.Columns.Add(column);


        // [City]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "City";
            column.Caption = "City";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [State]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "State";
            column.Caption = "State";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [ZipCode]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ZipCode";
            column.Caption = "ZipCode";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [ContactPhone]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ContactPhone";
            column.Caption = "ContactPhone";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [Reg Dir]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "RegDir";
            column.Caption = "RegDir";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [Dist Mgr]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "DistMgr";
            column.Caption = "DistMgr";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [Selling Area]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "SellingArea";
            column.Caption = "SellingArea";
            column.ReadOnly = true;
            table.Columns.Add(column);

             // [Service]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Service";
            column.Caption = "Service";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [WO NUMBER]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "WorkOrder";
            column.Caption = "WorkOrder";
            column.ReadOnly = true;
            table.Columns.Add(column);

               // [DG PRICE]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = "DGPrice";
            column.Caption = "DGPrice";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [NEW PRICE]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = "NewPrice";
            column.Caption = "NewPrice";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [SPOT]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Spot";
            column.Caption = "Spot";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [NP (Not Ready) ]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = "NP";
            column.Caption = "NP";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [SN (No Show) ]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = "SN";
            column.Caption = "SN";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [DG Trip Charge]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = "DGTripCharge";
            column.Caption = "DGTripCharge";
            column.ReadOnly = true;
            table.Columns.Add(column);

             // [ServiceDate]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ServiceDate";
            column.Caption = "ServiceDate";
            column.ReadOnly = true;
            table.Columns.Add(column);

             // [ServicesTime]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ServiceTime";
            column.Caption = "ServiceTime";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [Truck]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "TruckDay";
            column.Caption = "TruckDay";
            column.ReadOnly = true;
            table.Columns.Add(column);

             // [WAVE]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Wave";
            column.Caption = "Wave";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [Pictures Date]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "PicturesDate";
            column.Caption = "PicturesDate";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [Floor Type]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FloorType";
            column.Caption = "FloorType";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [TechId]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "TechId";
            column.Caption = "TechId";
            column.ReadOnly = true;
            //          column.Unique = true;
            table.Columns.Add(column);

            // [TechName]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "TechName";
            column.Caption = "TechName";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [Notes]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Notes";
            column.Caption = "Notes";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [SendText]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "IsConfirmed";
            column.Caption = "SendText";
            column.ReadOnly = true;
            table.Columns.Add(column);

  
            return table;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool status = SubmitJobs();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.radWaitingBar1.StopWaiting();
            this.radWaitingBar1.ResetWaiting();

            this.Cursor = System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
            radWaitingBar1.Visible = false;

            if (e.Error != null)
            {
                // Finally, handle the case where the operation 
                // succeeded.

                RadMessageBox.SetThemeName("Breeze");
                RadMessageBox.Show("Data upload failed", "Data upload - Notification status", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                radBtn_Execute.Enabled = false;
                radLabelElement1.ForeColor = Color.Red;
                radLabelElement1.Text = "Data upload failed ...";
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.

                //    uncomment this one   radLabelElement1.Text = "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                // ===>
                RadMessageBox.SetThemeName("Breeze");
                RadMessageBox.Show("The Data upload process has been completed.", "Data upload - Notification status", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                radBtn_Execute.Enabled = false;
                radLabelElement1.ForeColor = Color.Green;
                radLabelElement1.Text = "Data upload completed  ...";
                // ===>
                // radWaitingBarElement1
            }
        } // End

        private void radDD_Year_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (radDD_Year.SelectedIndex != -1)
               {
                if (radDD_Year.SelectedIndex == 0)
                {
                    radDD_Year.Focus();
                }
            }
        }

        private void radDD_Months_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (radDD_Months.SelectedIndex != -1)
            {
                if (radDD_Months.SelectedIndex == 0)
                {
                    radDD_Months.Focus();
                }
            }
        }


    }
}
