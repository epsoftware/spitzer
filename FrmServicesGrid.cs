using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmServicesGrid : Form
    {

        private DataTable tableReminders = GetTable();
        private DataSet DSservices= new DataSet("DSservices");


        public FrmServicesGrid()
        {
            InitializeComponent();

            DSservices.Tables.Add("tableReminders");

        }

        private void FrmServicesGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scopesDataSet.Reminders' table. You can move, or remove it, as needed.
      //      this.remindersTableAdapter.Fill(DSservices(0););
         //   this.remindersTableAdapter.Fill(this.scopesDataSet.Reminders);
        }

        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {

            tableReminders.Clear();
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=EPINEDA-DELL;Initial Catalog=Scopes;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();

                DateTime dt = new DateTime();
                dt = Convert.ToDateTime(radCalendar1.SelectedDate.ToShortDateString());

                string queryString = @"SELECT  * FROM dbo.[Services]  WHERE ServiceDate = " + "'" + dt.ToString("yyyy-MM-dd") + "'" + " ORDER BY ServiceDate, Store";


                SqlDataAdapter adapter = new SqlDataAdapter(queryString, cnn);

                DataSet customers = new DataSet();

                adapter.Fill(tableReminders);


                radGridView1.DataSource = tableReminders;

                ResizeGridColumns();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void radBtn_SearchStore_Click(object sender, EventArgs e)
        {

            tableReminders.Clear();
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=EPINEDA-DELL;Initial Catalog=Scopes;Integrated Security=true";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();

                    string queryString = @"SELECT  * FROM dbo.[Services]  WHERE store = " + "'" + radTxtBox_Store.Text + "'" +  " ORDER BY ServiceDate, Store";


                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, cnn);

                    DataSet customers = new DataSet();

                    adapter.Fill(tableReminders);


                    radGridView1.DataSource = tableReminders;
                ResizeGridColumns();

                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            } // End

        static DataTable GetTable()
        {

            DataTable table = new DataTable();
            DataColumn column;

            // [PeriodDt]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "PeriodDt";
            column.Caption = "PeriodDt";
            column.ReadOnly = true;
            //          column.Unique = true;
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

            // [Store]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Store";
            column.Caption = "Store";
            column.ReadOnly = true;
            table.Columns.Add(column);


            // [City]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "City";
            column.Caption = "City";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [StateCd]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "State";
            column.Caption = "State";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [Service]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Service";
            column.Caption = "Service";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [FloorType]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FloorType";
            column.Caption = "FloorType";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [ServiceDate]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ServiceDate";
            column.Caption = "ServiceDate";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [ServiceTime]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ServiceTime";
            column.Caption = "ServiceTime";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [RegDirector]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "RegionalDirector";
            column.Caption = "RegionalDirector";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [DistMgr]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "DistrictManager";
            column.Caption = "DistrictManager";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [WorkOrder]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "WorkOrder";
            column.Caption = "WorkOrder";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [ChainId]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "WorkStatus";
            column.Caption = "WorkStatus";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [ChainId]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ChainId";
            column.Caption = "ChainId";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [IsConfirmed]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "IsConfirmed";
            column.Caption = "IsConfirmed";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [ConfirmationDate]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ConfirmationDate";
            column.Caption = "ConfirmationDate";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [ConfirmedBy]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ConfirmedBy";
            column.Caption = "ConfirmedBy";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [NotesOperations]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "NotesOperations";
            column.Caption = "NotesOperations";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [NotesDistpatcher]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "NotesDistpatcher";
            column.Caption = "NotesDistpatcher";
            column.ReadOnly = true;
            table.Columns.Add(column);

            return table;
        }

        private void ResizeGridColumns()
        {

            this.radGridView1.Columns["PeriodDt"].BestFit();
            this.radGridView1.Columns["TechId"].BestFit();
            this.radGridView1.Columns["TechName"].BestFit(); 
           this.radGridView1.Columns["Store"].BestFit(); 
           this.radGridView1.Columns["City"].BestFit(); 
           this.radGridView1.Columns["State"].BestFit(); 
  
            this.radGridView1.Columns["Service"].BestFit();
            this.radGridView1.Columns["FloorType"].BestFit(); 
           this.radGridView1.Columns["ServiceDate"].BestFit(); 
           this.radGridView1.Columns["ServiceTime"].BestFit(); 

           this.radGridView1.Columns["RegionalDirector"].BestFit(); 
           this.radGridView1.Columns["DistrictManager"].BestFit(); 
           this.radGridView1.Columns["WorkOrder"].BestFit();
            this.radGridView1.Columns["WorkStatus"].BestFit();
            this.radGridView1.Columns["ChainId"].BestFit(); 

           this.radGridView1.Columns["IsConfirmed"].BestFit();
            this.radGridView1.Columns["ConfirmationDate"].BestFit();
            this.radGridView1.Columns["ConfirmedBy"].BestFit();

            this.radGridView1.Columns["NotesOperations"].BestFit();
            this.radGridView1.Columns["NotesDistpatcher"].BestFit();

    }
       

    }
    }

