using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace FrmMain
{
    public partial class RadFrmUsersMaintenance : Telerik.WinControls.UI.RadForm
    {

        private DataColumn dcColumn;
        private DataRow drRow;

        private DataTable dtUsers = GetTable();
        private DataSet DSusers= new DataSet("DSusers");

        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataSet changes;

        SqlConnection cnn = new SqlConnection();

        public RadFrmUsersMaintenance()
        {
            InitializeComponent();

            
            //GridViewComboBoxColumn LegalEntity1 = new GridViewComboBoxColumn("LegalEntity1");
            ////set the column data source - the possible column values
            //LegalEntity1.DataSource = new String[] { "Business", "Individual" };
            //LegalEntity1.ValueMember = "LegalEntity";
            //LegalEntity1.DisplayMember = "LegalEntity";
            ////set the FieldName - the column will retrieve the value from "Phone" column in the data table
            //LegalEntity1.FieldName = "LegalEntity";
            ////add the column to the grid
            //radGridView1.Columns.Add(LegalEntity1);



            //GridViewComboBoxColumn IsActive = new GridViewComboBoxColumn("IsActive");
            ////set the column data source - the possible column values
            //IsActive.DataSource = new String[] { "Yes", "No" };
            //IsActive.ValueMember = "IsActive";
            //IsActive.DisplayMember = "IsActive";
            ////set the FieldName - the column will retrieve the value from "Phone" column in the data table
            //IsActive.FieldName = "IsActive";
            ////add the column to the grid
            //radGridView1.Columns.Add(IsActive);

        bool hasRows = LoadUsers();

            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;

            GridViewComboBoxColumn Name = new GridViewComboBoxColumn("Name");
            //set the column data source - the possible column values
            Name.DataSource = DSusers.Tables["dtUsers"];
            Name.ValueMember = "Name";
            Name.DisplayMember = "Name";
            //set the FieldName - the column will retrieve the value from "Phone" column in the data table
            Name.FieldName = "Name";
            //add the column to the grid
            radGridView1.Columns.Add(Name);

           
            //this.radGridView1.DataSource = DSusers.Tables["tbUsers"];

            //create the combo box column
            GridViewComboBoxColumn comboColumn = new GridViewComboBoxColumn("IsTxmMsgActive");
            //set the column data source - the possible column values
            comboColumn.DataSource = new String[] { "Yes", "No" };
            //set the FieldName - the column will retrieve the value from "Phone" column in the data table
            comboColumn.FieldName = "IsTxmMsgActive";
            //add the column to the grid
            radGridView1.Columns.Add(comboColumn);

            //GridViewComboBoxColumn IsTxmMsgActive = new GridViewComboBoxColumn("IsTxmMsgActive");
            ////set the column data source - the possible column values
            //IsTxmMsgActive.DataSource = new String[] { "Yes", "No" };
            //IsTxmMsgActive.ValueMember = "IsTxmMsgActive";
            //IsTxmMsgActive.DisplayMember = "IsTxmMsgActive";
            ////set the FieldName - the column will retrieve the value from "Phone" column in the data table
            //IsTxmMsgActive.FieldName = "IsTxmMsgActive";
            //IsTxmMsgActive.GetLookupValue("IsTxmMsgActive");
            ////add the column to the grid
            //radGridView1.Columns.Add(IsTxmMsgActive);

            







            //GridViewComboBoxColumn IsActive = new GridViewComboBoxColumn("IsActive");
            ////set the column data source - the possible column values
            //IsActive.DataSource = new String[] { "Yes", "No" };
            //IsActive.ValueMember = "IsActive";
            //IsActive.DisplayMember = "IsActive";
            ////set the FieldName - the column will retrieve the value from "Phone" column in the data table
            //IsActive.FieldName = "IsActive";
            ////add the column to the grid
            //radGridView1.Columns.Add(IsActive);

        }

        private  bool LoadUsers()
        {
            bool status = true;
            dtUsers.Clear();
            string connetionString = null;
    //        SqlConnection cnn;
            connetionString = "Data Source=EPINEDA-DELL;Initial Catalog=Scopes;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();

 //               DateTime dt = new DateTime();
 //               dt = Convert.ToDateTime(radCalendar1.SelectedDate.ToShortDateString());

                string queryString = @"SELECT  id, name, AlternateName, LegalEntity, city, State, Mobile, MobileCarrier, IsTxmMsgActive, email, emailOffice, IsActive FROM [dbo].[Scopes_DGFloorcare_Techs] ORDER by ID";


                adapter = new SqlDataAdapter(queryString, cnn);
                DSusers.Tables.Add(dtUsers);
                adapter.Fill(DSusers, "dtUsers");

                //     DataSet customers = new DataSet();


                //  adapter.Fill(dtUsers);
                //         cnn.Close();    ??
                radGridView1.DataSource = DSusers.Tables["dtUsers"];


                //     SqlCommandBuilder cb = new SqlCommandBuilder(adapter);

                //adapter.DeleteCommand = cb.GetDeleteCommand(true);
                //adapter.UpdateCommand = cb.GetUpdateCommand(true);
                // adapter.InsertCommand = cb.GetInsertCommand(true);

                // OLD and working
                //adapter.Fill(dtUsers.);
                //radGridView1.DataSource = dtUsers;

                foreach (GridViewDataColumn column in radGridView1.Columns)
                {
                    column.BestFit();
                }

          //      ResizeGridColumns();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            return status;
        }


        static void BuildGrid()
        {



        }

        static DataTable GetTable()
        {

            DataTable table = new DataTable();
            DataColumn column;

            // [Id]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Id";
            column.Caption = "Id";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            // [Name]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Name";
            column.Caption = "Name";
            column.ReadOnly = false;
            column.AllowDBNull = false;
            table.Columns.Add(column);

            // [AlternateName]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "AlternateName";
            column.Caption = "AlternateName";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [LegalEntity]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LegalEntity";
            column.Caption = "LegalEntity";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [CompanyRelationship]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CompanyRelationship";
            column.Caption = "CompanyRelationship";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [ChainCode]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ChainCode";
            column.Caption = "ChainCode";
            column.ReadOnly = false;
            column.DefaultValue = "DGFL";
            table.Columns.Add(column);

            // [Role]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Role";
            column.Caption = "Role";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [Address]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Address";
            column.Caption = "Address";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [City]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "City";
            column.Caption = "City";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [State]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "State";
            column.Caption = "State";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [PostalCode]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "PostalCode";
            column.Caption = "PostalCode";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [BusinessRegionID]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "BusinessRegionID";
            column.Caption = "BusinessRegionID";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [StartDate]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "StartDate";
            column.Caption = "StartDate";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [EndDate]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "EndDate";
            column.Caption = "EndDate";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [Language]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Language";
            column.Caption = "Language";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [Phone]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Phone";
            column.Caption = "Phone";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [Mobile]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mobile";
            column.Caption = "Mobile";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [MobileCarrier]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "MobileCarrier";
            column.Caption = "MobileCarrier";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [IsTxmMsgActive]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "IsTxmMsgActive";
            column.Caption = "IsTxmMsgActive";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [Fax]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Fax";
            column.Caption = "Fax";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [email]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "email";
            column.Caption = "email";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [emailOffice]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "emailOffice";
            column.Caption = "emailOffice";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [Website]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Website";
            column.Caption = "Website";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [AccountGroup]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "AccountGroup";
            column.Caption = "AccountGroup";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [TaxID]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "TaxID";
            column.Caption = "TaxID";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [BankAccount]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "BankAccount";
            column.Caption = "BankAccount";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [PayTermsCode]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "PayTermsCode";
            column.Caption = "PayTermsCode";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [PaymentFeeAgreetmentCode]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "PaymentFeeAgreetmentCode";
            column.Caption = "PaymentFeeAgreetmentCode";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [InsuranceType]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "InsuranceType";
            column.Caption = "InsuranceType";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [InsuranceCompany]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "InsuranceCompany";
            column.Caption = "InsuranceCompany";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [InsuranceStartDate]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "InsuranceStartDate";
            column.Caption = "InsuranceStartDate";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [InsuranceExpirationDate]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "InsuranceExpirationDate";
            column.Caption = "InsuranceExpirationDate";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [UserId]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "UserId";
            column.Caption = "UserId";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [Password]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Password";
            column.Caption = "Password";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [ManagedBy]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ManagedBy";
            column.Caption = "ManagedBy";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [IsActive]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "IsActive";
            column.Caption = "IsActive";
            column.ReadOnly = true;
            table.Columns.Add(column);

            // [CreatedBy]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CreatedBy";
            column.Caption = "CreatedBy";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [CreatedAt]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CreatedAt";
            column.Caption = "CreatedAt";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [UpdatedBy]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "UpdatedBy";
            column.Caption = "UpdatedBy";
            column.ReadOnly = false;
            table.Columns.Add(column);


            // [UpdatedAt]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "UpdatedAt";
            column.Caption = "UpdatedAt";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [IsFirstLogin]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "IsFirstLogin";
            column.Caption = "IsFirstLogin";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [FirstLoginSignUpCode]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FirstLoginSignUpCode";
            column.Caption = "FirstLoginSignUpCode";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [MobileInvitation]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "MobileInvitation";
            column.Caption = "MobileInvitation";
            column.ReadOnly = false;
            table.Columns.Add(column);

            // [photo]
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "photo";
            column.Caption = "photo";
            column.ReadOnly = false;
            table.Columns.Add(column);


            return table;
        }

        private void ResizeGridColumns()
        {

            //this.radGridView1.Columns["Id"].BestFit();
            //this.radGridView1.Columns["Name"].BestFit();
            //this.radGridView1.Columns["AlternateName"].BestFit();
            //this.radGridView1.Columns["LegalEntity"].BestFit();
            //this.radGridView1.Columns["CompanyRelationship"].BestFit();
            //this.radGridView1.Columns["ChainCode"].BestFit();
            //this.radGridView1.Columns["Role"].BestFit();
            //this.radGridView1.Columns["Address"].BestFit();
            //this.radGridView1.Columns["City"].BestFit();
            //this.radGridView1.Columns["State"].BestFit();
            //this.radGridView1.Columns["PostalCode"].BestFit();
            //this.radGridView1.Columns["BusinessRegionID"].BestFit();
            //this.radGridView1.Columns["StartDate"].BestFit();
            //this.radGridView1.Columns["EndDate"].BestFit();
            //this.radGridView1.Columns["Language"].BestFit();
            //this.radGridView1.Columns["Phone"].BestFit();
            //this.radGridView1.Columns["Mobile"].BestFit();
            //this.radGridView1.Columns["MobileCarrier"].BestFit();
            //this.radGridView1.Columns["IsTxmMsgActive"].BestFit();
            //this.radGridView1.Columns["Fax"].BestFit();
            //this.radGridView1.Columns["email"].BestFit();
            //this.radGridView1.Columns["emailOffice"].BestFit();
            //this.radGridView1.Columns["Website"].BestFit();
            //this.radGridView1.Columns["AccountGroup"].BestFit();
            //this.radGridView1.Columns["TaxID"].BestFit();
            //this.radGridView1.Columns["BankAccount"].BestFit();
            //this.radGridView1.Columns["PayTermsCode"].BestFit();
            //this.radGridView1.Columns["PaymentFeeAgreetmentCode"].BestFit();
            //this.radGridView1.Columns["InsuranceType"].BestFit();
            //this.radGridView1.Columns["InsuranceCompany"].BestFit();
            //this.radGridView1.Columns["InsuranceStartDate"].BestFit();
            //this.radGridView1.Columns["InsuranceExpirationDate"].BestFit();
            //this.radGridView1.Columns["UserId"].BestFit();
            //this.radGridView1.Columns["Password"].BestFit();
            //this.radGridView1.Columns["ManagedBy"].BestFit();
            //this.radGridView1.Columns["IsActive"].BestFit();
            //this.radGridView1.Columns["CreatedBy"].BestFit();
            //this.radGridView1.Columns["CreatedAt"].BestFit();
            //this.radGridView1.Columns["UpdatedBy"].BestFit();
            //this.radGridView1.Columns["UpdatedAt"].BestFit();
            //this.radGridView1.Columns["IsFirstLogin"].BestFit();
            //this.radGridView1.Columns["FirstLoginSignUpCode"].BestFit();
            //this.radGridView1.Columns["MobileInvitation"].BestFit();
            //this.radGridView1.Columns["photo"].BestFit();

            //  this.radGridView1.Columns["Id"].IsVisible = false;
            //   this.radGridView1.Columns["Name"].IsVisible = false;                                     
            //   this.radGridView1.Columns["AlternateName"].IsVisible = false;
            this.radGridView1.Columns["LegalEntity"].IsVisible = false;
       
            this.radGridView1.Columns["CompanyRelationship"].IsVisible = false;
            this.radGridView1.Columns["ChainCode"].IsVisible = false;
            this.radGridView1.Columns["Role"].IsVisible = false;
            this.radGridView1.Columns["Address"].IsVisible = false;
        //    this.radGridView1.Columns["City"].IsVisible = false;
         //   this.radGridView1.Columns["State"].IsVisible = false;
            this.radGridView1.Columns["PostalCode"].IsVisible = false;
            this.radGridView1.Columns["BusinessRegionID"].IsVisible = false;
            this.radGridView1.Columns["StartDate"].IsVisible = false;
            this.radGridView1.Columns["EndDate"].IsVisible = false;
            this.radGridView1.Columns["Language"].IsVisible = false;
            this.radGridView1.Columns["Phone"].IsVisible = false;
       //     this.radGridView1.Columns["Mobile"].IsVisible = false;
       //     this.radGridView1.Columns["MobileCarrier"].IsVisible = false;
            this.radGridView1.Columns["IsTxmMsgActive"].IsVisible = false;
            this.radGridView1.Columns["Fax"].IsVisible = false;
        //    this.radGridView1.Columns["email"].IsVisible = false;
      //      this.radGridView1.Columns["emailOffice"].IsVisible = false;
            this.radGridView1.Columns["Website"].IsVisible = false;
            this.radGridView1.Columns["AccountGroup"].IsVisible = false;
            this.radGridView1.Columns["TaxID"].IsVisible = false;
            this.radGridView1.Columns["BankAccount"].IsVisible = false;
            this.radGridView1.Columns["PayTermsCode"].IsVisible = false;
            this.radGridView1.Columns["PaymentFeeAgreetmentCode"].IsVisible = false;
            this.radGridView1.Columns["InsuranceType"].IsVisible = false;
            this.radGridView1.Columns["InsuranceCompany"].IsVisible = false;
            this.radGridView1.Columns["InsuranceStartDate"].IsVisible = false;
            this.radGridView1.Columns["InsuranceExpirationDate"].IsVisible = false;
            this.radGridView1.Columns["UserId"].IsVisible = false;
            this.radGridView1.Columns["Password"].IsVisible = false;
            this.radGridView1.Columns["ManagedBy"].IsVisible = false;
            this.radGridView1.Columns["IsActive"].IsVisible = false;
            this.radGridView1.Columns["CreatedBy"].IsVisible = false;
            this.radGridView1.Columns["CreatedAt"].IsVisible = false;
            this.radGridView1.Columns["UpdatedBy"].IsVisible = false;
            this.radGridView1.Columns["UpdatedAt"].IsVisible = false;
            this.radGridView1.Columns["IsFirstLogin"].IsVisible = false;
            this.radGridView1.Columns["FirstLoginSignUpCode"].IsVisible = false;
            this.radGridView1.Columns["MobileInvitation"].IsVisible = false;
            this.radGridView1.Columns["photo"].IsVisible = false;
        }



        private void radListView_Reminders_ColumnCreating(object sender, Telerik.WinControls.UI.ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.FieldName == "Id")
            {
                e.Column.HeaderText = "Id";
            }

            if (e.Column.FieldName == "Name")
            {
                e.Column.HeaderText = "Name";
            }
            
            if (e.Column.FieldName == "AlternateName")
            {
                e.Column.HeaderText = "AlternateName";
            }

            if (e.Column.FieldName == "LegalEntity")
            {
                e.Column.HeaderText = "LegalEntity";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "CompanyRelationship")
            {
                e.Column.HeaderText = "CompanyRelationship";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "ChainCode")
            {
                e.Column.HeaderText = "ChainCode";
            }

            if (e.Column.FieldName == "Role")
            {
                e.Column.HeaderText = "Role";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "Address")
            {
                e.Column.HeaderText = "Address";
            }

            if (e.Column.FieldName == "City")
            {
                e.Column.HeaderText = "City";
            }

            if (e.Column.FieldName == "State")
            {
                e.Column.HeaderText = "State";
            }
            if (e.Column.FieldName == "PostalCode")
            {
                e.Column.HeaderText = "PostalCode";
            }
            if (e.Column.FieldName == "BusinessRegionID")
            {
                e.Column.HeaderText = "BusinessRegionID";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "StartDate")
            {
                e.Column.HeaderText = "StartDate";
                e.Column.Visible = false;
            }
            if (e.Column.FieldName == "EndDate")
            {
                e.Column.HeaderText = "EndDate";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "Language")
            {
                e.Column.HeaderText = "Language";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "Phone")
            {
                e.Column.HeaderText = "Phone";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "Mobile")
            {
                e.Column.HeaderText = "Mobile";
            }

            if (e.Column.FieldName == "MobileCarrier")
            {
                e.Column.HeaderText = "MobileCarrier";
            }

            if (e.Column.FieldName == "IsTxmMsgActive")
            {
                e.Column.HeaderText = "IsTxmMsgActive";
            }

            if (e.Column.FieldName == "Fax")
            {
                e.Column.HeaderText = "Fax";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "email")
            {
                e.Column.HeaderText = "email";
            }

            if (e.Column.FieldName == "emailOffice")
            {
                e.Column.HeaderText = "emailOffice";
            }

            if (e.Column.FieldName == "Website")
            {
                e.Column.HeaderText = "Website";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "AccountGroup")
            {
                e.Column.HeaderText = "AccountGroup";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "TaxID")
            {
                e.Column.HeaderText = "TaxID";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "BankAccount")
            {
                e.Column.HeaderText = "BankAccount";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "PayTermsCode")
            {
                e.Column.HeaderText = "PayTermsCode";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "PaymentFeeAgreetmentCode")
            {
                e.Column.HeaderText = "PaymentFeeAgreetmentCode";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "InsuranceType")
            {
                e.Column.HeaderText = "InsuranceType";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "InsuranceCompany")
            {
                e.Column.HeaderText = "InsuranceCompany";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "InsuranceStartDate")
            {
                e.Column.HeaderText = "InsuranceStartDate";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "InsuranceExpirationDate")
            {
                e.Column.HeaderText = "InsuranceExpirationDate";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "UserId")
            {
                e.Column.HeaderText = "UserId";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "Password")
            {
                e.Column.HeaderText = "Password";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "ManagedBy")
            {
                e.Column.HeaderText = "ManagedBy";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "IsActive")
            {
                e.Column.HeaderText = "IsActive";
            }

            if (e.Column.FieldName == "CreatedBy")
            {
                e.Column.HeaderText = "CreatedBy";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "UpdatedBy")
            {
                e.Column.HeaderText = "UpdatedBy";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "UpdatedAt")
            {
                e.Column.HeaderText = "UpdatedAt";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "IsFirstLogin")
            {
                e.Column.HeaderText = "IsFirstLogin";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "FirstLoginSignUpCode")
            {
                e.Column.HeaderText = "FirstLoginSignUpCode";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "MobileInvitation")
            {
                e.Column.HeaderText = "MobileInvitation";
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "photo")
            {
                e.Column.HeaderText = "photo";
                e.Column.Visible = false;
            }

        }

        private void radBtn_Save_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            //code to modify data in DataSet here

            builder.GetInsertCommand();
            builder.GetUpdateCommand();

            //Without the SqlCommandBuilder this line would fail
            adapter.Update(DSusers, "dtUsers");

            //try
            //{

            //        //SqlCommand  command = new SqlCommand(  "INSERT INTO [dbo].[Scopes_DGFloorcare_Techs] (Name) VALUES (@Name)", cnn);

            //        var insertCommand = builder.GetInsertCommand();

            //        // Set first parameter.
            //        insertCommand.Parameters[0] = new SqlParameter("@p1", 60);
            //        // Execute.
            //        insertCommand.ExecuteNonQuery();



            //        // Add the parameters for the InsertCommand.
            //        command.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            //        adapter.InsertCommand = command;

            //        changes = DSusers.GetChanges();
            //        if (changes != null)
            //        {
            //            adapter.Update(changes);
            //        }
            //        MessageBox.Show("Changes Done");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
        }
    }
}
