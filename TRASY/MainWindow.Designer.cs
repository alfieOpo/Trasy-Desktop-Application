namespace TRASY
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainmap = new GMap.NET.WindowsForms.GMapControl();
            this.TimeChecker = new System.Windows.Forms.Timer(this.components);
            this.UpdateTheCurrentlocationOftheBus = new System.Windows.Forms.Timer(this.components);
            this.BusChecker = new System.Windows.Forms.Timer(this.components);
            this.DetailsChecker = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_map_setting = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.alertMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.emergencyMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfOnlineBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCodingBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emergencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeHotlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmergencyMessageChecker = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainmap, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1336, 662);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // mainmap
            // 
            this.mainmap.Bearing = 0F;
            this.mainmap.CanDragMap = true;
            this.mainmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.mainmap.GrayScaleMode = false;
            this.mainmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mainmap.LevelsKeepInMemmory = 5;
            this.mainmap.Location = new System.Drawing.Point(3, 3);
            this.mainmap.MarkersEnabled = true;
            this.mainmap.MaxZoom = 1000;
            this.mainmap.MinZoom = 2;
            this.mainmap.MouseWheelZoomEnabled = true;
            this.mainmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mainmap.Name = "mainmap";
            this.mainmap.NegativeMode = false;
            this.mainmap.PolygonsEnabled = true;
            this.mainmap.RetryLoadTile = 0;
            this.mainmap.RoutesEnabled = true;
            this.mainmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mainmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mainmap.ShowTileGridLines = false;
            this.mainmap.Size = new System.Drawing.Size(1330, 656);
            this.mainmap.TabIndex = 1;
            this.mainmap.Zoom = 11.25D;
            // 
            // TimeChecker
            // 
            this.TimeChecker.Interval = 1000;
            this.TimeChecker.Tick += new System.EventHandler(this.TimeChecker_Tick);
            // 
            // UpdateTheCurrentlocationOftheBus
            // 
            this.UpdateTheCurrentlocationOftheBus.Interval = 10000;
            this.UpdateTheCurrentlocationOftheBus.Tick += new System.EventHandler(this.UpdateTheCurrentlocationOftheBus_Tick);
            // 
            // BusChecker
            // 
            this.BusChecker.Interval = 10000;
            this.BusChecker.Tick += new System.EventHandler(this.BusChecker_Tick);
            // 
            // DetailsChecker
            // 
            this.DetailsChecker.Interval = 10000;
            this.DetailsChecker.Tick += new System.EventHandler(this.DetailsChecker_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1144, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRASY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(1084, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "(BUS TRACKING SYSTEM)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1084, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server Base";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(20, 757);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version 1.0.0.1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_map_setting
            // 
            this.cbo_map_setting.AutoCompleteCustomSource.AddRange(new string[] {
            "Map",
            "Satellite"});
            this.cbo_map_setting.BackColor = System.Drawing.Color.White;
            this.cbo_map_setting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_map_setting.DropDownWidth = 100;
            this.cbo_map_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_map_setting.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbo_map_setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbo_map_setting.Items.AddRange(new object[] {
            "Map",
            "Satellite"});
            this.cbo_map_setting.Name = "cbo_map_setting";
            this.cbo_map_setting.Size = new System.Drawing.Size(121, 28);
            this.cbo_map_setting.DropDownClosed += new System.EventHandler(this.cbo_map_setting_DropDownClosed);
            this.cbo_map_setting.Click += new System.EventHandler(this.cbo_map_setting_Click);
            this.cbo_map_setting.TextChanged += new System.EventHandler(this.cbo_map_setting_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.referentialsToolStripMenuItem,
            this.cbo_map_setting});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem,
            this.listOfOnlineBusToolStripMenuItem,
            this.listOfCodingBusToolStripMenuItem,
            this.toolStripSeparator2,
            this.lockToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Image = global::TRASY.Properties.Resources.planet;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMessageToolStripMenuItem,
            this.toolStripSeparator1,
            this.alertMessageToolStripMenuItem,
            this.personalMessageToolStripMenuItem,
            this.toolStripSeparator3,
            this.emergencyMessageToolStripMenuItem});
            this.messageToolStripMenuItem.Image = global::TRASY.Properties.Resources.speech_bubble__3_;
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.messageToolStripMenuItem.Text = "Message";
            // 
            // createMessageToolStripMenuItem
            // 
            this.createMessageToolStripMenuItem.Image = global::TRASY.Properties.Resources.speech_bubble;
            this.createMessageToolStripMenuItem.Name = "createMessageToolStripMenuItem";
            this.createMessageToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.createMessageToolStripMenuItem.Text = "Create Message";
            this.createMessageToolStripMenuItem.Click += new System.EventHandler(this.createMessageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // alertMessageToolStripMenuItem
            // 
            this.alertMessageToolStripMenuItem.Image = global::TRASY.Properties.Resources.speech_bubble__1_;
            this.alertMessageToolStripMenuItem.Name = "alertMessageToolStripMenuItem";
            this.alertMessageToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.alertMessageToolStripMenuItem.Text = "Alert Message";
            this.alertMessageToolStripMenuItem.Click += new System.EventHandler(this.alertMessageToolStripMenuItem_Click);
            // 
            // personalMessageToolStripMenuItem
            // 
            this.personalMessageToolStripMenuItem.Image = global::TRASY.Properties.Resources.speech_bubble__2_;
            this.personalMessageToolStripMenuItem.Name = "personalMessageToolStripMenuItem";
            this.personalMessageToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.personalMessageToolStripMenuItem.Text = "Personal Message";
            this.personalMessageToolStripMenuItem.Click += new System.EventHandler(this.personalMessageToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // emergencyMessageToolStripMenuItem
            // 
            this.emergencyMessageToolStripMenuItem.Image = global::TRASY.Properties.Resources.email;
            this.emergencyMessageToolStripMenuItem.Name = "emergencyMessageToolStripMenuItem";
            this.emergencyMessageToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.emergencyMessageToolStripMenuItem.Text = "Emergency Message";
            this.emergencyMessageToolStripMenuItem.Click += new System.EventHandler(this.emergencyMessageToolStripMenuItem_Click_1);
            // 
            // listOfOnlineBusToolStripMenuItem
            // 
            this.listOfOnlineBusToolStripMenuItem.Image = global::TRASY.Properties.Resources.onlinebus;
            this.listOfOnlineBusToolStripMenuItem.Name = "listOfOnlineBusToolStripMenuItem";
            this.listOfOnlineBusToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listOfOnlineBusToolStripMenuItem.Text = "List of Online Bus";
            this.listOfOnlineBusToolStripMenuItem.Click += new System.EventHandler(this.listOfOnlineBusToolStripMenuItem_Click);
            // 
            // listOfCodingBusToolStripMenuItem
            // 
            this.listOfCodingBusToolStripMenuItem.Image = global::TRASY.Properties.Resources.offlinebus;
            this.listOfCodingBusToolStripMenuItem.Name = "listOfCodingBusToolStripMenuItem";
            this.listOfCodingBusToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listOfCodingBusToolStripMenuItem.Text = "List of Coding Bus";
            this.listOfCodingBusToolStripMenuItem.Click += new System.EventHandler(this.listOfCodingBusToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Image = global::TRASY.Properties.Resources.locked;
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::TRASY.Properties.Resources.logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TRASY.Properties.Resources.delete__1_;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // referentialsToolStripMenuItem
            // 
            this.referentialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.emergencyToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.busesToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.policeHotlineToolStripMenuItem});
            this.referentialsToolStripMenuItem.Image = global::TRASY.Properties.Resources.office_material;
            this.referentialsToolStripMenuItem.Name = "referentialsToolStripMenuItem";
            this.referentialsToolStripMenuItem.Size = new System.Drawing.Size(96, 28);
            this.referentialsToolStripMenuItem.Text = "Referentials";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::TRASY.Properties.Resources.businessman;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // emergencyToolStripMenuItem
            // 
            this.emergencyToolStripMenuItem.Image = global::TRASY.Properties.Resources.ambulance;
            this.emergencyToolStripMenuItem.Name = "emergencyToolStripMenuItem";
            this.emergencyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.emergencyToolStripMenuItem.Text = "Emergency";
            this.emergencyToolStripMenuItem.Click += new System.EventHandler(this.emergencyToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Image = global::TRASY.Properties.Resources.map__1_;
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // busesToolStripMenuItem
            // 
            this.busesToolStripMenuItem.Image = global::TRASY.Properties.Resources.buses;
            this.busesToolStripMenuItem.Name = "busesToolStripMenuItem";
            this.busesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.busesToolStripMenuItem.Text = "Buses";
            this.busesToolStripMenuItem.Click += new System.EventHandler(this.busesToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Image = global::TRASY.Properties.Resources.employees;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // policeHotlineToolStripMenuItem
            // 
            this.policeHotlineToolStripMenuItem.Image = global::TRASY.Properties.Resources.phone_number;
            this.policeHotlineToolStripMenuItem.Name = "policeHotlineToolStripMenuItem";
            this.policeHotlineToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.policeHotlineToolStripMenuItem.Text = "Police Hotline";
            this.policeHotlineToolStripMenuItem.Click += new System.EventHandler(this.policeHotlineToolStripMenuItem_Click);
            // 
            // EmergencyMessageChecker
            // 
            this.EmergencyMessageChecker.Interval = 10000;
            this.EmergencyMessageChecker.Tick += new System.EventHandler(this.EmergencyMessageChecker_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TRASY.Properties.Resources.trasymianicon;
            this.pictureBox1.Location = new System.Drawing.Point(1277, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 774);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "TRASY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GMap.NET.WindowsForms.GMapControl mainmap;
        private System.Windows.Forms.Timer TimeChecker;
        private System.Windows.Forms.Timer UpdateTheCurrentlocationOftheBus;
        private System.Windows.Forms.Timer BusChecker;
        private System.Windows.Forms.Timer DetailsChecker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem alertMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem emergencyMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfOnlineBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCodingBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emergencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeHotlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbo_map_setting;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer EmergencyMessageChecker;
    }
}

