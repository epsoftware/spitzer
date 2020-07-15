using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Telerik.WinControls.UI;

namespace FrmMain
{
    public partial class FrmScheduler : Form
    {
        public FrmScheduler()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=EPINEDA-DELL;Initial Catalog=Scopes;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
 
                string queryString = @"SELECT Store AS [Summary], [Address] + ' ' + [City] + ' ' + [State] + ' ' + Phone as [Location],  
              CASE WHEN right(time,2) = 'PM' 
	        THEN DATEADD(HOUR, CAST(LEFT(time,1) as int) + 12 , Day)
	        ELSE DATEADD(HOUR, CAST(LEFT(time,1) as int), Day)
			End AS [Start], 
       CASE WHEN right(time,2) = 'PM' 
	        THEN DATEADD(HOUR, CAST(LEFT(time,1) as int) + 13 , Day)
	        ELSE DATEADD(HOUR, CAST(LEFT(time,1) as int) + 1, Day)
			End AS [End], 
      CASE FLOOR 
         WHEN 'VCT' THEN CAST(2 as int)
         ELSE CAST(6 as int)
      END AS [BackgroundID],  
	   'Tech: '+ Tech + ' RegDirector: ' + [RegDirector] + ' DistMgr: ' + [DistMgr] + 'Floor: ' + [Floor] AS [Description]  FROM dbo.[MASTER-MAYO] 
	   ORDER BY Day";


                SqlDataAdapter adapter = new SqlDataAdapter(queryString, cnn);

                DataSet customers = new DataSet();

                adapter.Fill(customers, "Appointments");

                //adapter.Fill(schedulerDataDataSet.Appointments);

                AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();

                appointmentMappingInfo.Start = "Start";
                appointmentMappingInfo.End = "End";
                appointmentMappingInfo.Duration = "Duration";
                appointmentMappingInfo.Summary = "Summary";
                appointmentMappingInfo.Description = "Description";
                appointmentMappingInfo.Location = "Location";
                appointmentMappingInfo.BackgroundId = "BackgroundID";
                //appointmentMappingInfo.StatusId = "StatusID";
                //appointmentMappingInfo.RecurrenceRule = "RecurrenceRule";
                //appointmentMappingInfo.Resources = "Appointments_AppointmentsResources";
                //appointmentMappingInfo.ResourceId = "ResourceID";
                schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo;
                schedulerBindingDataSource1.EventProvider.DataSource = customers.Tables[0]; // schedulerDataDataSet.Appointments;
                radScheduler1.DataSource = schedulerBindingDataSource1;
                schedulerBindingDataSource1.Rebind();
         //       MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void FrmScheduler_Load(object sender, EventArgs e)
        {
            this.radScheduler1.ActiveView.PropertyChanged += new PropertyChangedEventHandler(ActiveView_PropertyChanged);
            this.radCalendar1.SelectionChanged += new EventHandler(radCalendar1_SelectionChanged);
        }

        void ActiveView_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "StartDate")
            {
                this.radCalendar1.SelectionChanged -= new EventHandler(radCalendar1_SelectionChanged);
                this.radCalendar1.SelectedDate = this.radScheduler1.ActiveView.StartDate;
                this.radCalendar1.FocusedDate = this.radScheduler1.ActiveView.StartDate;
                this.radCalendar1.SelectionChanged += new EventHandler(radCalendar1_SelectionChanged);
            }
        }

        void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.radCalendar1.SelectedDates.Count > 0)
            {
                this.radScheduler1.ActiveView.PropertyChanged -= new PropertyChangedEventHandler(ActiveView_PropertyChanged);
                this.radScheduler1.ActiveView.StartDate = this.radCalendar1.SelectedDate;
                this.radScheduler1.ActiveView.PropertyChanged += new PropertyChangedEventHandler(ActiveView_PropertyChanged);
            }
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "Images (*.csv)|*csv|" +
                "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Excel worksheets";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            //             string connetionString = null;
            //             SqlConnection cnn;
            //         connetionString = "Data Source=EPINEDA-DELL;Initial Catalog=Scopes;Integrated Security=true";
            //             cnn = new SqlConnection(connetionString);
            //             try
            //             {
            //               cnn.Open();
            //             //   string queryString = "SELECT * FROM dbo.[MASTER-MAYO]";
            //             // string queryString = "SELECT top 3 Store AS [Summary], Address as [Location], DATEADD(HOUR,+3, Day)  as [Start],  DATEADD(HOUR,+4, Day)  as [End],  Tech AS [Description] ,  Duration = '01:00:00' FROM dbo.[MASTER-MAYO]   where Day > getdate()";
            //             //   string queryString = "SELECT top 3 Store AS [Summary], Address as [Location], Day  as [Start],  Day  as [End],  Tech AS [Description] ,  Duration = '4.00:00:00' FROM dbo.[MASTER-MAYO]   where Day > getdate()";
            //             //    string queryString = "SELECT STORE as  [Summary], Address as [Location],  CONVERT(varchar, Day, 101)  as [Start]  ,  CONVERT(varchar, Day, 101)  as [End],  Tech AS [Description]  FROM dbo.[MASTER-MAYO] where Day > getdate() ORDER BY Day";


            //             string queryString = @"SELECT Store AS [Summary], [Address] + ' ' + [City] + ' ' + [State] + ' ' + Phone as [Location],  
            //           CASE WHEN right(time,2) = 'PM' 
            //      THEN DATEADD(HOUR, CAST(LEFT(time,1) as int) + 12 , Day)
            //      ELSE DATEADD(HOUR, CAST(LEFT(time,1) as int), Day)
            //End AS [Start], 
            //    CASE WHEN right(time,2) = 'PM' 
            //      THEN DATEADD(HOUR, CAST(LEFT(time,1) as int) + 13 , Day)
            //      ELSE DATEADD(HOUR, CAST(LEFT(time,1) as int) + 1, Day)
            //End AS [End], 
            //   CASE FLOOR 
            //      WHEN 'VCT' THEN CAST(2 as int)
            //      ELSE CAST(6 as int)
            //   END AS [BackgroundID],  
            // 'Tech: '+ Tech + ' RegDirector: ' + [RegDirector] + ' DistMgr: ' + [DistMgr] + 'Floor: ' + [Floor] AS [Description]  FROM dbo.[MASTER-MAYO] 
            // ORDER BY Day";


            //            SqlDataAdapter adapter = new SqlDataAdapter(queryString, cnn);

            //             DataSet customers = new DataSet();

            //             adapter.Fill(customers, "Appointments");

            //             //adapter.Fill(schedulerDataDataSet.Appointments);

            //             AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();

            //             appointmentMappingInfo.Start = "Start";
            //             appointmentMappingInfo.End = "End";
            //             appointmentMappingInfo.Duration = "Duration";
            //             appointmentMappingInfo.Summary = "Summary";
            //             appointmentMappingInfo.Description = "Description";
            //             appointmentMappingInfo.Location = "Location";
            //             appointmentMappingInfo.BackgroundId = "BackgroundID";
            //             //appointmentMappingInfo.StatusId = "StatusID";
            //             //appointmentMappingInfo.RecurrenceRule = "RecurrenceRule";
            //             //appointmentMappingInfo.Resources = "Appointments_AppointmentsResources";
            //             //appointmentMappingInfo.ResourceId = "ResourceID";
            //             schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo;
            //             schedulerBindingDataSource1.EventProvider.DataSource = customers.Tables[0]; // schedulerDataDataSet.Appointments;
            //             radScheduler1.DataSource = schedulerBindingDataSource1;
            //             schedulerBindingDataSource1.Rebind();
            //             MessageBox.Show("Connection Open ! ");
            //                 cnn.Close();
            //             }
            //             catch (Exception ex)
            //             {
            //                 MessageBox.Show("Can not open connection ! ");
            //             }
            //         }
        }

        private void radScheduler1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello !!!");
        }
    }
}

