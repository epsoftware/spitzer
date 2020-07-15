using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
//using Microsoft.SqlServer.Management.Common; // add reference Microsoft.SqlServer.ConnectionInfo
//using Microsoft.SqlServer.Management.Smo; //  add reference Microsoft.SqlServer.SMO
using System.Collections;
using System.Data;
using System.Windows.Forms;
//  System.Configuration; //  add reference Microsoft.SqlServer.SMO
using System.Configuration; // add reference System.Configuration (in System.Configuration.dll)

// =======================================================================================
// Note: If the dll are not under reference then go and get them from:
//          C:\Program Files\Microsoft SQL Server\100\SDK\Assemblies
//         -------------------------------------------
//        80 = SQL Server 2000    =  8.00.xxxx
//       90 = SQL Server 2005    =  9.00.xxxx
//      100 = SQL Server 2008    = 10.00.xxxx
//      105 = SQL Server 2008 R2 = 10.50.xxxx
//      110 = SQL Server 2012    = 11.00.xxxx
//      120 = SQL Server 2014    = 12.00.xxxx
//      130 = SQL Server 2016    = 13.00.xxxx
//      140 = SQL Server 2017    = 14.00.xxxx
//      150 = SQL Server 2019    = 15.00.xxxx
// =======================================================================================
// Add below references:

// ================================================================================= >>>>
// Note: PM    Install-Package Unofficial.Sql.Server.Management.Objects -Version 17.4.1
//              2019-07-15
// ================================================================================= >>>>
//Unofficial Microsoft Sql Server Managment Objects v14.0.17213.0 as packaged with Microsoft Sql Server Management Studio v17.4

//Microsoft.SqlServer.ConnectionInfo.dll
//Microsoft.SqlServer.ConnectionInfoExtended.dll
//Microsoft.SqlServer.Management.Sdk.Sfc.dll
//Microsoft.SqlServer.Smo.dll
//Microsoft.SqlServer.SmoExtended.dll
//Microsoft.SqlServer.SqlClrProvider.dll
//Microsoft.SqlServer.SqlEnum.dll
// ================================================================================= >>>>

//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;

// ==> using Microsoft.SqlServer.SMO
// ==> Microsoft.SqlServer.SMOExtended
// ==> Microsoft.SqlServer.ConnectionInfo
// ==> Microsoft.SqlServer.Management.sdlc.sfc
// ==> Microsoft.SqlServer.SqlEnum
// =======================================================================================

namespace FrmMain
{
    class DatabaseManagement
    {
        // =============================================================
        //                     [ Open Sql Server connection]
        // =============================================================

        // Getting the connection string from the app.config
        public static SqlConnection connectToSqlServer()
        {
            var sqlServerConnectionString = ConfigurationManager.ConnectionStrings["SourceConnection"].ConnectionString;

            try
            {
                if (sqlServerConnectionString.Length == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    return new SqlConnection(sqlServerConnectionString);
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return new SqlConnection(sqlServerConnectionString);
        }

        public static SqlConnection connectToSqlServer(string inputConnection)
        {
            var sqlServerConnectionString = ConfigurationManager.ConnectionStrings[inputConnection].ConnectionString;

            try
            {
                if (sqlServerConnectionString.Length == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    return new SqlConnection(sqlServerConnectionString);
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return new SqlConnection(sqlServerConnectionString);
        }

        public static string getConnectionStringFromAppconfig(string inputConnection)
        {
            var sqlServerConnectionString = ConfigurationManager.ConnectionStrings[inputConnection].ConnectionString;

            try
            {
                if (sqlServerConnectionString.Length == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    return sqlServerConnectionString;
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return sqlServerConnectionString;
        }

        public static string getInputConnection(string SQLserver, string InitialCatalog)
        {
            SqlConnectionStringBuilder connStringBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            connStringBuilder["Data Source"] = SQLserver;
            connStringBuilder["Initial Catalog"] = InitialCatalog;
            connStringBuilder["integrated Security"] = true;
            return connStringBuilder.ToString();
        }


        // Get Years
        public static ArrayList getData(string sqlSelectIn)
        {
            ArrayList DataArray = new ArrayList();
            using (SqlConnection sqlConn = connectToSqlServer())
            {
                SqlCommand sqlCmd = new SqlCommand(sqlSelectIn, sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    foreach (DbDataRecord rec in reader)
                    {
                        DataArray.Add(rec);
                    }
                }
            }
            return DataArray;
        }

        // GetDatabases
        public static DataTable getDatabases(string sqlSelectIn)
        {
            DataTable dtDataBases = new DataTable();

            using (SqlConnection sqlConn = connectToSqlServer())
            {
                SqlCommand sqlCmd = new SqlCommand(sqlSelectIn, sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    dtDataBases.Load(reader);
                }
            }
            return dtDataBases;
        }



        // Get Stats Info
        public static DataTable getStatsInfo(string sqlSelectIn)
        {
            DataTable dtStatisticsInfo = new DataTable();

            using (SqlConnection sqlConn = connectToSqlServer())
            {
                SqlCommand sqlCmd = new SqlCommand(sqlSelectIn, sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    dtStatisticsInfo.Load(reader);
                }
            }
            return dtStatisticsInfo;
        }


        // Get Stats Info for Dates
        public static DataTable getStatsDates(string sqlSelectIn)
        {

            using (SqlConnection sqlConn = connectToSqlServer())
            {
                SqlCommand sqlCmd = new SqlCommand(sqlSelectIn, sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                DataTable dtStatisticsDates = reader.GetSchemaTable();
                return dtStatisticsDates;
            }
        }

        // ============== BEGIN SMO ===================

        //public static DataTable retrieveNetworkServers()
        //{
        //    System.Data.Sql.SqlDataSourceEnumerator instance = System.Data.Sql.SqlDataSourceEnumerator.Instance;
        //    DataTable NetworkServers = new DataTable();
        //    NetworkServers = instance.GetDataSources();
        //    return NetworkServers;
        //}

        //public static DataTable retrieveSQLServers()
        //{
        //    DataTable SMOservers = new DataTable();
        //    SMOservers = SmoApplication.EnumAvailableSqlServers(); // true
        //    return SMOservers;
        //}

        //public static ArrayList retrievingDatabases(string sqlServerIn)
        //{
        //    ArrayList dataBases = new ArrayList();
        //    Server sqlServer = new Server(sqlServerIn);

        //    //Using windows authentication
        //    sqlServer.ConnectionContext.LoginSecure = true;
        //    sqlServer.ConnectionContext.Connect();

        //    if (sqlServer.ConnectionContext.IsOpen)
        //    {
        //        foreach (Database myDataBase in sqlServer.Databases)
        //        {
        //            dataBases.Add(myDataBase.Name);
        //        }
        //    }
        //    sqlServer.ConnectionContext.Disconnect();
        //    return dataBases;
        //}

        //public static ArrayList retrievingTables(string sqlServerIn, string DatabaseIn)
        //{
        //    ArrayList Tables = new ArrayList();
        //    Server sqlServer = new Server(sqlServerIn);

        //    Database DB = new Database();

        //    //        DB.Name = DatabaseIn;

        //    //Using windows authentication
        //    sqlServer.ConnectionContext.LoginSecure = true;
        //    sqlServer.ConnectionContext.Connect();

        //    if (sqlServer.ConnectionContext.IsOpen)
        //    {
        //        DB = sqlServer.Databases[DatabaseIn];
        //        foreach (Table myTable in DB.Tables)
        //        {
        //            if (myTable.IsSystemObject != true) // If don't want to show system objects
        //            {
        //                Tables.Add("[" + myTable.Schema + "]." + myTable.Name);
        //                //     Tables.Add(myTable.Name);
        //            }
        //        }
        //    }
        //    sqlServer.ConnectionContext.Disconnect();
        //    return Tables;
        //}

        //public static DataTable retrievingTableProperties(string sqlServerIn, string DatabaseIn)
        //{

        //    DataTable TB_TableInfo = new DataTable();
        //    DataColumn columna;
        //    DataRow fila;

        //    // Create Columns

        //    // Schema Name
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "SchemaName";
        //    TB_TableInfo.Columns.Add(columna);

        //    // Table Name
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "TableName";
        //    TB_TableInfo.Columns.Add(columna);

        //    // RowCount
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.Int32");
        //    columna.ColumnName = "RowCount";
        //    TB_TableInfo.Columns.Add(columna);

        //    // Columns
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "Columns";
        //    TB_TableInfo.Columns.Add(columna);

        //    // CreateDate
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.DateTime");
        //    columna.ColumnName = "CreateDate";
        //    TB_TableInfo.Columns.Add(columna);

        //    // Date Last Modified (datetime)
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.DateTime");
        //    columna.ColumnName = "DateLastModified";
        //    TB_TableInfo.Columns.Add(columna);

        //    // DataSpaceUsed (double)
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.Double");
        //    columna.ColumnName = "DataSpaceUsed";
        //    TB_TableInfo.Columns.Add(columna);

        //    // HasIndex [bool]
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "HasIndex";
        //    TB_TableInfo.Columns.Add(columna);

        //    // HasClusteredIndex [bool]
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "HasClusteredIndex";
        //    TB_TableInfo.Columns.Add(columna);

        //    // Indexes Count
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "IndexesCount";
        //    TB_TableInfo.Columns.Add(columna);

        //    // IndexSpaceUsed [double]
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.Double");
        //    columna.ColumnName = "IndexSpaceUsed";
        //    TB_TableInfo.Columns.Add(columna);

        //    // IsPartitioned [bool]
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "IsPartitioned";
        //    TB_TableInfo.Columns.Add(columna);

        //    // HasCompressedPartitions [bool]
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "HasCompressedPartitions";
        //    TB_TableInfo.Columns.Add(columna);

        //    ArrayList Tables = new ArrayList();

        //    Database DB = new Database();
        //    //         DB.Name = DatabaseIn;

        //    //Using windows authentication

        //    Server sqlServer = new Server(sqlServerIn);
        //    ServerConnection conContext = new ServerConnection();
        //    conContext = sqlServer.ConnectionContext;

        //    sqlServer.ConnectionContext.LoginSecure = true;
        //    sqlServer.ConnectionContext.Connect();

        //    if (sqlServer.ConnectionContext.IsOpen)
        //    {
        //        DB = sqlServer.Databases[DatabaseIn];
        //        foreach (Table myTable in DB.Tables)
        //        {

        //            if (myTable.IsSystemObject != true) // If don't want to show system objects
        //            {
        //                //           Tables.Add("[" + myTable.Schema + "]." + myTable.Name);
        //                Tables.Add(myTable.Name);

        //                fila = TB_TableInfo.NewRow();
        //                fila["SchemaName"] = myTable.Schema;
        //                fila["TableName"] = myTable.Name;
        //                fila["RowCount"] = myTable.RowCount;
        //                fila["Columns"] = myTable.Columns.Count;
        //                fila["CreateDate"] = myTable.CreateDate;
        //                fila["DateLastModified"] = myTable.DateLastModified;
        //                fila["DataSpaceUsed"] = myTable.DataSpaceUsed;
        //                fila["HasIndex"] = myTable.HasIndex;
        //                fila["HasClusteredIndex"] = myTable.HasClusteredIndex;
        //                fila["IndexesCount"] = myTable.Indexes.Count;
        //                fila["IndexSpaceUsed"] = myTable.IndexSpaceUsed;
        //                fila["IsPartitioned"] = myTable.IsPartitioned;
        //                fila["HasCompressedPartitions"] = myTable.HasCompressedPartitions;
        //                TB_TableInfo.Rows.Add(fila);
        //            }
        //        }
        //    }
        //    sqlServer.ConnectionContext.Disconnect();
        //    return TB_TableInfo;
        //}

        //public static DataTable retrievingTables_and_Schemas(string sqlServerIn, string DatabaseIn)
        //{

        //    DataTable TB_TableInfo = new DataTable();
        //    DataColumn columna;
        //    DataRow fila;

        //    // Create Columns

        //    // Table Name
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "SchemaName";
        //    TB_TableInfo.Columns.Add(columna);

        //    // Table Name
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "TableName";
        //    TB_TableInfo.Columns.Add(columna);

        //    // Data Type
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "RowCount";
        //    TB_TableInfo.Columns.Add(columna);

        //    ArrayList Tables = new ArrayList();
        //    Server sqlServer = new Server(sqlServerIn);

        //    Database DB = new Database();

        //    //        DB.Name = DatabaseIn;

        //    //Using windows authentication
        //    sqlServer.ConnectionContext.LoginSecure = true;
        //    sqlServer.ConnectionContext.Connect();

        //    if (sqlServer.ConnectionContext.IsOpen)
        //    {
        //        DB = sqlServer.Databases[DatabaseIn];
        //        foreach (Table myTable in DB.Tables)
        //        {
        //            if (myTable.IsSystemObject != true) // If don't want to show system objects
        //            {
        //                //           Tables.Add("[" + myTable.Schema + "]." + myTable.Name);
        //                Tables.Add(myTable.Name);

        //                fila = TB_TableInfo.NewRow();
        //                fila["SchemaName"] = myTable.Schema;
        //                fila["TableName"] = myTable.Name;
        //                fila["RowCount"] = myTable.RowCount;
        //                TB_TableInfo.Rows.Add(fila);
        //            }
        //        }
        //    }
        //    sqlServer.ConnectionContext.Disconnect();
        //    return TB_TableInfo;
        //}

        //public static DataTable retrievingTableColumns(string sqlServerIn, string DatabaseIn, string TableIn)
        //{
        //    ArrayList TableProperties = new ArrayList();

        //    DataTable TB_SchemaColumn = new DataTable();
        //    DataColumn columna;
        //    DataRow fila;

        //    // Create Columns

        //    // Column Name
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "ColumnName";
        //    TB_SchemaColumn.Columns.Add(columna);

        //    // Data Type
        //    columna = new DataColumn();
        //    columna.DataType = System.Type.GetType("System.String");
        //    columna.ColumnName = "DataType";
        //    TB_SchemaColumn.Columns.Add(columna);

        //    Server sqlServer = new Server(sqlServerIn);
        //    //          Database DB = new Database(sqlServer,DatabaseIn);

        //    //Using windows authentication
        //    sqlServer.ConnectionContext.LoginSecure = true;
        //    sqlServer.ConnectionContext.Connect();

        //    if (sqlServer.ConnectionContext.IsOpen)
        //    {

        //        Database DB = new Database(sqlServer, DatabaseIn);

        //        Table TB = new Table(DB, TableIn, "dbo");

        //        foreach (Column myColumn in sqlServer.Databases[DB.Name.ToString()].Tables[TB.Name.ToString(), "dbo"].Columns)
        //        {
        //            //         TableProperties.AddRange(new string[] { myColumn.Name.ToString(), myColumn.DataType.ToString() });

        //            fila = TB_SchemaColumn.NewRow();
        //            fila["ColumnName"] = myColumn.Name;
        //            fila["DataType"] = myColumn.DataType;
        //            TB_SchemaColumn.Rows.Add(fila);

        //            //            TableProperties.Add (myColumn.Name.ToString());
        //        }
        //    }
        //    sqlServer.ConnectionContext.Disconnect();
        //    return TB_SchemaColumn;
        //}


        // ============== END SMO ===================

        public static void dropAndCreateTable(string sqlServerIn, string DatabaseIn, string TableIn)
        {
            string QUOTE = @"'";

            string connectionString = null;
            connectionString = getInputConnection(sqlServerIn, DatabaseIn);
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;

            //       connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            sql = "IF OBJECT_ID (" + QUOTE + "dbo." + TableIn + QUOTE + "," + QUOTE + "U" + QUOTE + ") IS NOT NULL DROP TABLE dbo." + TableIn + " ; ";
            sql = sql + "CREATE TABLE [dbo].[" + TableIn + "](            [RowID] [int] NULL, [RowType] [varchar](1) NULL, [VndNbr] [varchar](12) NULL, [InvNbr] [varchar](15) NULL, [RowData] [varchar](100) NULL , [FileTag] [varchar](100) NULL) ON [PRIMARY] ; ";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! (  DROP and CREATE TABLE )");
            }
        }

        public static void executeBulkCopy(string sqlServerIn, string DatabaseIn, string TableIn, DataTable table)
        {

            string connectionString = null;
            connectionString = getInputConnection(sqlServerIn, DatabaseIn);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    foreach (DataColumn c in table.Columns)
                        bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);
                    bulkCopy.DestinationTableName = "dbo." + TableIn;
                    bulkCopy.BatchSize = 1000;

                    try
                    {
                        bulkCopy.WriteToServer(table);
                    }
                    catch (Exception ex)
                    {
                        //           Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public static long getRowCount(string sqlServerIn, string DatabaseIn, string TableIn)
        {

            long countStart = 0;
            string connectionString = null;
            connectionString = getInputConnection(sqlServerIn, DatabaseIn);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Perform a count on the destination table.
                SqlCommand commandRowCount = new SqlCommand("SELECT COUNT(*) FROM " + TableIn, connection);
                countStart = System.Convert.ToInt32(commandRowCount.ExecuteScalar());
            }
            return countStart;
        }

        // These two pending to review !!!

        //private void populateRegisteredServers()
        //{
        //    // --------------------------------------------------------------------------------
        //    //     Connection string for SQL Servers
        //    // --------------------------------------------------------------------------------

        //    string connectionString = DatabaseManagement.connectToSqlServer().ConnectionString.ToString();

        //    try
        //    {
        //        using (SqlConnection RegisteredServersConnection = new SqlConnection(connectionString))
        //        {
        //            SqlCommand RegisteredServersCommand = RegisteredServersConnection.CreateCommand();
        //            RegisteredServersCommand.CommandText = "Select  Distinct ServerName from dbo.Vw_WincoServers  Order By ServerName";
        //            SqlDataAdapter RegisteredServersDataAdapter = new SqlDataAdapter(RegisteredServersCommand);

        //            DataSet RegisteredServersDataset = new DataSet();
        //            RegisteredServersTable = new DataTable();
        //            RegisteredServersDataAdapter.Fill(RegisteredServersTable);

        //            // Fill Source combobox
        //            radDDLSourceServers.DataSource = RegisteredServersTable;
        //            radDDLSourceServers.DisplayMember = "ServerName";
        //            radDDLSourceServers.ValueMember = "ServerName";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error:" + ex.Message, "Critical error - The server configured in the App.config is not available", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //    }
        //}


        //private void populateSourceDatabases()
        //{
        //    // --------------------------------------------------------------------------------
        //    //     Connection String for Databases  - GridView
        //    // --------------------------------------------------------------------------------

        //    string connectionString = DatabaseManagement.getInputConnection(this.radDDLSourceServers.SelectedItem.Text.ToString(), "master");

        //    using (SqlConnection DBConnection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand DatabasesCommand = DBConnection.CreateCommand();

        //        DatabasesCommand.CommandText = "SELECT [name] as DatabaseName, CONVERT(varchar(10), create_date, 102) as DateCreated FROM sys.databases Where [name] like 'WINC%' ORDER BY [name]";
        //        //WHERE name like '%WINCO%' ) ORDER BY [name]";

        //        SqlDataAdapter DatabasesDataAdapter = new SqlDataAdapter(DatabasesCommand);

        //        DataSet DatabasesDataset = new DataSet();
        //        DatabasesTable = new DataTable();
        //        DatabasesDataAdapter.Fill(DatabasesTable);

        //        // TAB (tabPage_Create)

        //        this.radDDLSourceDatabases.DataSource = DatabasesTable;
        //        this.radDDLSourceDatabases.DisplayMember = "DatabaseName";
        //        this.radDDLSourceDatabases.ValueMember = "DatabaseName";
        //    }

        //}

        public static bool DeleteServices(string sqlServerIn, string DatabaseIn, string yyyyMM, string TableIn)
       //     public static bool DeleteServices(string sqlServerIn, string DatabaseIn, string yyyyMM, DataTable TableIn)
        {

            bool Status = true;

            string QUOTE = @"'";

            string connectionString = null;
            connectionString = getInputConnection(sqlServerIn, DatabaseIn);
            SqlConnection cnn;
            SqlCommand cmd = new SqlCommand();
            string sql = null;
            // RIGHT(@ServiceTime,10)
            //       connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                if (cnn.State == ConnectionState.Open)
                {
                    try
                    {

                        sql = "DELETE FROM dbo." + TableIn + " WHERE PERIODdt = " + "'" + yyyyMM + "'" ;
                        //foreach (DataRow row in TableIn.Rows)
                        //{
                        //    sql = "DELETE FROM SERVICES ";
                            cmd = new SqlCommand(sql, cnn);

                            cmd.ExecuteNonQuery();
                        //}
                    }
                    catch (Exception ex)
                    {
                        Status = false;
                        MessageBox.Show("Issues deleting data ! (  Deleting Data into Services )" + ex.Message);
                    }

                }

            }
            catch (Exception ex)
            {
                Status = false;
                MessageBox.Show("Can not open connection ! (  Deleting Data into Services )" + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                cnn.Close();
            }
            return Status;
        }

        public static bool InsertServices(string sqlServerIn, string DatabaseIn, string yyyyMM, DataTable TableIn)
        {

            bool Status = true;

            string QUOTE = @"'";

            string connectionString = null;
            connectionString = getInputConnection(sqlServerIn, DatabaseIn);
            SqlConnection cnn;
            SqlCommand cmd = new SqlCommand();
            string sql = null;
            // RIGHT(@ServiceTime,10)
            //       connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                if (cnn.State == ConnectionState.Open)
                {
                    try
                    {

                        foreach (DataRow row in TableIn.Rows)
                        {
                            sql = "INSERT INTO [dbo].[Services] ([PeriodDt], [ChainId], [Store], [City], [State], [WorkOrder], [Service], [FloorType], [ServiceDate], [ServiceTime], [IsConfirmed],  [ContactPhone], [RegionalDirector], [DistrictManager], [TechId], [TechName], [TechPhone], [PhoneCarrier],  [NotesDistpatcher])" +
                                    " Select[PeriodDt], [ChainId], [Store], a.[City], a.[State],  [WorkOrder], [Service], [FloorType], a.[ServiceDate], CONVERT(varchar(15),CAST([ServiceTime]  AS TIME),100) as [ServiceTime], [isConfirmed], [ContactPhone], [RegDir], [DistMgr], [TechId], b.[Name], b.[Mobile], b.[MobileCarrier] , [Notes] " +
                                    " FROM[dbo].[Services_Imported]   a " +
                                    " INNER JOIN[dbo].[Scopes_DGFloorcare_Techs]   b ON    a.[TechId] = b.[Id] WHERE [PeriodDt] = " + "'" + yyyyMM + "'"; ;
                        cmd = new SqlCommand(sql, cnn);
 
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Status = false;
                        MessageBox.Show("Issues inserting data ! (  INSERT Data into Services )" + ex.Message);
                    }

                }

            }
            catch (Exception ex)
            {
                Status = false;
                MessageBox.Show("Can not open connection ! (  INSERT Data into Services )" + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                cnn.Close();
            }
            return Status;
        }

        public static bool LoadServices(string sqlServerIn, string DatabaseIn, string yyyyMM, DataTable TableIn)
        {

            bool Status = true;

            string QUOTE = @"'";

            string connectionString = null;
            connectionString = getInputConnection(sqlServerIn, DatabaseIn);
            SqlConnection cnn;
            SqlCommand cmd = new SqlCommand();
            string sql = null;
            // RIGHT(@ServiceTime,10)
            //       connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                if (cnn.State == ConnectionState.Open)
                {
                    try
                    {

                        foreach (DataRow row in TableIn.Rows)
                        {
                            sql = "INSERT INTO [dbo].[Services_Imported]   ([PeriodDt]  ,[ChainId]  ,[Store]  ,[Address]   ,[City]   ,[State]   ,[ZipCode]   ,[ContactPhone]   ,[RegDir]  ,[DistMgr]  ,[SellingArea]   ,[Service]   ,[WorkOrder]  ,[DGPrice] " +
           ",[NewPrice]  ,[Spot]  ,[NP]  ,[SN]  ,[DGTripCharge]  ,[ServiceDate]  ,[ServiceTime]   ,[TruckDay]   ,[Wave]   ,[PicturesDate]  ,[FloorType]  ,[TechId]  ,[TechName]   ,[Notes]  ,[isConfirmed] ) VALUES (@PeriodDt, " +
           "@ChainId   ,@Store    ,cast(@Address  as nvarchar(100)) ,cast(@City as nvarchar(100))    ,Cast(@State as nvarchar(3))   ,cast(@ZipCode as nvarchar(20))   ,@ContactPhone    ,cast(@RegDir  as nvarchar(50))  ,cast(@DistMgr as nvarchar(50))  ,@SellingArea    ,@Service    ,@WorkOrder    ,@DGPrice   ,@NewPrice   ,@Spot   ,@NP  ,@SN  ,@DGTripCharge, " +
           "@ServiceDate   ,@ServiceTime  ,@TruckDay ,@Wave   ,@PicturesDate  ,@FloorType  ,@TechId  ,cast(@TechName  as nvarchar(100)),@Notes  ,@isConfirmed ) ";
                            cmd = new SqlCommand(sql, cnn);
                            cmd.Parameters.AddWithValue("@PeriodDt", yyyyMM);
                            cmd.Parameters.AddWithValue("@ChainId", "DGFL");
                            cmd.Parameters.AddWithValue("@Store", row["Store"]);
                            cmd.Parameters.AddWithValue("@Address", row["Address"]);
                            cmd.Parameters.AddWithValue("@City", row["City"]);
                            cmd.Parameters.AddWithValue("@State", row["State"]);
                            cmd.Parameters.AddWithValue("@ZipCode", row["ZipCode"]);
                            cmd.Parameters.AddWithValue("@ContactPhone", row["ContactPhone"]);
                            cmd.Parameters.AddWithValue("@RegDir", row["RegDir"]);
                            cmd.Parameters.AddWithValue("@DistMgr", row["DistMgr"]);
                            cmd.Parameters.AddWithValue("@SellingArea", row["SellingArea"]);
                            cmd.Parameters.AddWithValue("@Service", row["Service"]);
                            cmd.Parameters.AddWithValue("@WorkOrder", row["WorkOrder"]);
                            cmd.Parameters.AddWithValue("@DGPrice", row["DGPrice"]);
                            cmd.Parameters.AddWithValue("@NewPrice", row["NewPrice"]);
                            cmd.Parameters.AddWithValue("@Spot", row["Spot"]);
                            cmd.Parameters.AddWithValue("@NP", row["NP"]);
                            cmd.Parameters.AddWithValue("@SN", row["SN"]);
                            cmd.Parameters.AddWithValue("@DGTripCharge", row["DGTripCharge"]);
                            cmd.Parameters.AddWithValue("@ServiceDate", row["ServiceDate"]);
                            cmd.Parameters.AddWithValue("@ServiceTime", row["ServiceTime"]);
                            cmd.Parameters.AddWithValue("@TruckDay", row["TruckDay"]);
                            cmd.Parameters.AddWithValue("@Wave", row["Wave"]);
                            cmd.Parameters.AddWithValue("@PicturesDate", row["PicturesDate"]);
                            cmd.Parameters.AddWithValue("@FloorType", row["FloorType"]);
                            cmd.Parameters.AddWithValue("@TechId", row["TechId"]);
                            cmd.Parameters.AddWithValue("@TechName", row["TechName"]);
                            cmd.Parameters.AddWithValue("@Notes", row["Notes"]);
                            cmd.Parameters.AddWithValue("@isConfirmed", row["isConfirmed"]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Status = false;
                        MessageBox.Show("Issues inserting data ! (  INSERT Data into Reminders )" + ex.Message);
                    }

                }

            }
            catch (Exception ex)
            {
                Status = false;
                MessageBox.Show("Can not open connection ! (  INSERT Data into Reminders )" + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                cnn.Close();
            }
            return Status;
        }

        public static bool InsertReminders(string sqlServerIn, string DatabaseIn, DataTable TableIn)
        {

            bool Status = true;

            string QUOTE = @"'";

            string connectionString = null;
            connectionString = getInputConnection(sqlServerIn, DatabaseIn);
            SqlConnection cnn;
            SqlCommand cmd = new SqlCommand();
            string sql = null;
            // RIGHT(@ServiceTime,10)
            //       connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                if (cnn.State == ConnectionState.Open)
                {
                    try
                    {

                        foreach (DataRow row in TableIn.Rows)
                        {
                            sql = "INSERT INTO [dbo].[Reminders] ( [TechId],[TechName],[Store],[City],[StateCd],[ContactPhone],[TechPhone],[PhoneCarrier],[FloorType],[ServiceDate],[ServiceTime],[RegDirector] " +
                ",[DistMgr],[WorkOrderNumber],[ChainId],[IsConfirmed],[Notes] ) VALUES (@TechId , @TechName , @Store , @City , @StateCd , @ContactPhone , @TechPhone , @PhoneCarrier , @FloorType , CONVERT(varchar, @ServiceDate, 23) , CONVERT(varchar(15), CAST(@ServiceTime AS TIME), 100), @RegDirector , @DistMgr , @WorkOrderNumber" +
                ", @ChainId , @IsConfirmed, @Notes)";
                            cmd = new SqlCommand(sql, cnn);
                            cmd.Parameters.AddWithValue("@TechId", row["TechId"]);
                            cmd.Parameters.AddWithValue("@TechName", row["TechName"]);
                            cmd.Parameters.AddWithValue("@Store", row["Store"]);
                            cmd.Parameters.AddWithValue("@City", row["City"]);
                            cmd.Parameters.AddWithValue("@StateCd", row["StateCd"]);
                            cmd.Parameters.AddWithValue("@ContactPhone", row["ContactPhone"]);
                            cmd.Parameters.AddWithValue("@TechPhone", row["TechPhone"]);
                            cmd.Parameters.AddWithValue("@PhoneCarrier", row["PhoneCarrier"]);
                            cmd.Parameters.AddWithValue("@FloorType", row["FloorType"]);
                            cmd.Parameters.AddWithValue("@ServiceDate", row["ServiceDate"]);
                            cmd.Parameters.AddWithValue("@ServiceTime", row["ServiceTime"]);
                            cmd.Parameters.AddWithValue("@RegDirector", row["RegDirector"]);
                            cmd.Parameters.AddWithValue("@DistMgr", row["DistMgr"]);
                            cmd.Parameters.AddWithValue("@WorkOrderNumber", row["WorkOrderNumber"]);
                            cmd.Parameters.AddWithValue("@ChainId", row["ChainId"]);
                            cmd.Parameters.AddWithValue("@IsConfirmed", row["IsConfirmed"]);
                            cmd.Parameters.AddWithValue("@Notes", row["Notes"]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Status = false;
                        MessageBox.Show("Issues inserting data ! (  INSERT Data into Reminders )" + ex.Message);
                    }

                }

            }
            catch (Exception ex)
            {
                Status = false;
                MessageBox.Show("Can not open connection ! (  INSERT Data into Reminders )" + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                cnn.Close();
            }
            return Status;
        }
    }
}

