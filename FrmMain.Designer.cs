namespace FrmMain
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radMenuMain = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem_BuildInvoices = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem_Messaging = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem_TechUpdates = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem_Services = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem_MissingServices = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem_WebApp = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem_About = new Telerik.WinControls.UI.RadMenuItem();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Mail-icon.png");
            this.imageList1.Images.SetKeyName(1, "construction-worker-icon.png");
            this.imageList1.Images.SetKeyName(2, "Import-Ecxel-icon.png");
            this.imageList1.Images.SetKeyName(3, "download.png");
            this.imageList1.Images.SetKeyName(4, "DollarGeneral.jpg");
            this.imageList1.Images.SetKeyName(5, "RiteAid.ico");
            this.imageList1.Images.SetKeyName(6, "MissingServices.png");
            this.imageList1.Images.SetKeyName(7, "Duplicates.png");
            this.imageList1.Images.SetKeyName(8, "FindDuplicates.png");
            this.imageList1.Images.SetKeyName(9, "iconfinder_logo_brand_brands_logos_excel_2993694.png");
            this.imageList1.Images.SetKeyName(10, "Email.ico");
            this.imageList1.Images.SetKeyName(11, "Invoice-icon.png");
            this.imageList1.Images.SetKeyName(12, "invoice.png");
            this.imageList1.Images.SetKeyName(13, "document-construction-icon.png");
            this.imageList1.Images.SetKeyName(14, "invoices.ico");
            // 
            // radMenuMain
            // 
            this.radMenuMain.ImageList = this.imageList1;
            this.radMenuMain.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem_BuildInvoices,
            this.radMenuItem_Messaging,
            this.radMenuItem_TechUpdates,
            this.radMenuItem_Services,
            this.radMenuItem_MissingServices,
            this.radMenuItem_WebApp,
            this.radMenuItem_About});
            this.radMenuMain.Location = new System.Drawing.Point(0, 0);
            this.radMenuMain.Name = "radMenuMain";
            this.radMenuMain.Size = new System.Drawing.Size(1272, 89);
            this.radMenuMain.TabIndex = 21;
            this.radMenuMain.Text = "radMenu1";
            this.radMenuMain.ThemeName = "Office2010Silver";
            // 
            // radMenuItem_BuildInvoices
            // 
            this.radMenuItem_BuildInvoices.AccessibleDescription = "Load Data";
            this.radMenuItem_BuildInvoices.AccessibleName = "Load Data";
            this.radMenuItem_BuildInvoices.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem_BuildInvoices.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem_BuildInvoices.Image")));
            this.radMenuItem_BuildInvoices.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenuItem_BuildInvoices.ImageIndex = -1;
            this.radMenuItem_BuildInvoices.Name = "radMenuItem_BuildInvoices";
            this.radMenuItem_BuildInvoices.Padding = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.radMenuItem_BuildInvoices.Text = "Load Data";
            this.radMenuItem_BuildInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem_BuildInvoices.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem_BuildInvoices.Click += new System.EventHandler(this.radMenuItem_LoadData_Click);
            // 
            // radMenuItem_Messaging
            // 
            this.radMenuItem_Messaging.AccessibleDescription = "Send Messages";
            this.radMenuItem_Messaging.AccessibleName = "Send Messages";
            this.radMenuItem_Messaging.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem_Messaging.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem_Messaging.Image")));
            this.radMenuItem_Messaging.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenuItem_Messaging.ImageIndex = -1;
            this.radMenuItem_Messaging.Name = "radMenuItem_Messaging";
            this.radMenuItem_Messaging.Padding = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.radMenuItem_Messaging.Text = "Messaging Center";
            this.radMenuItem_Messaging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem_Messaging.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem_Messaging.Click += new System.EventHandler(this.radMenuItem_Messaging_Click);
            // 
            // radMenuItem_TechUpdates
            // 
            this.radMenuItem_TechUpdates.AccessibleDescription = "Tech updates";
            this.radMenuItem_TechUpdates.AccessibleName = "Tech updates";
            this.radMenuItem_TechUpdates.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds;
            this.radMenuItem_TechUpdates.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem_TechUpdates.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem_TechUpdates.Image")));
            this.radMenuItem_TechUpdates.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenuItem_TechUpdates.ImageIndex = -1;
            this.radMenuItem_TechUpdates.Name = "radMenuItem_TechUpdates";
            this.radMenuItem_TechUpdates.Padding = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.radMenuItem_TechUpdates.Text = "Tech Info";
            this.radMenuItem_TechUpdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem_TechUpdates.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem_Services
            // 
            this.radMenuItem_Services.AccessibleDescription = "Services";
            this.radMenuItem_Services.AccessibleName = "Services";
            this.radMenuItem_Services.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem_Services.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem_Services.Image")));
            this.radMenuItem_Services.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenuItem_Services.ImageIndex = -1;
            this.radMenuItem_Services.Name = "radMenuItem_Services";
            this.radMenuItem_Services.Padding = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.radMenuItem_Services.Text = "Services";
            this.radMenuItem_Services.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem_Services.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radMenuItem_Services.Click += new System.EventHandler(this.radMenuItem_Services_Click);
            // 
            // radMenuItem_MissingServices
            // 
            this.radMenuItem_MissingServices.AccessibleDescription = "Missing Services";
            this.radMenuItem_MissingServices.AccessibleName = "Missing Services";
            this.radMenuItem_MissingServices.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem_MissingServices.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem_MissingServices.Image")));
            this.radMenuItem_MissingServices.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenuItem_MissingServices.ImageKey = "";
            this.radMenuItem_MissingServices.Name = "radMenuItem_MissingServices";
            this.radMenuItem_MissingServices.Padding = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.radMenuItem_MissingServices.Text = "Missing Services";
            this.radMenuItem_MissingServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem_MissingServices.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radMenuItem_WebApp
            // 
            this.radMenuItem_WebApp.AccessibleDescription = "WebApp";
            this.radMenuItem_WebApp.AccessibleName = "WebApp";
            this.radMenuItem_WebApp.Enabled = false;
            this.radMenuItem_WebApp.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem_WebApp.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem_WebApp.Image")));
            this.radMenuItem_WebApp.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenuItem_WebApp.Name = "radMenuItem_WebApp";
            this.radMenuItem_WebApp.Padding = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.radMenuItem_WebApp.Text = "WebApp";
            this.radMenuItem_WebApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem_WebApp.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radMenuItem_About
            // 
            this.radMenuItem_About.AccessibleDescription = "About";
            this.radMenuItem_About.AccessibleName = "About";
            this.radMenuItem_About.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem_About.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem_About.Image")));
            this.radMenuItem_About.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenuItem_About.Name = "radMenuItem_About";
            this.radMenuItem_About.Padding = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.radMenuItem_About.Text = "About";
            this.radMenuItem_About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radMenuItem_About.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem_About.Click += new System.EventHandler(this.radMenuItem_About_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 654);
            this.Controls.Add(this.radMenuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Spitzer";
            this.ThemeName = "Office2010Silver";
            ((System.ComponentModel.ISupportInitialize)(this.radMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadMenu radMenuMain;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_BuildInvoices;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_Messaging;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_TechUpdates;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_Services;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_MissingServices;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_WebApp;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_About;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
    }
}

