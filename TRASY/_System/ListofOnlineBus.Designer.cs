namespace TRASY._System
{
    partial class ListofOnlineBus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListofOnlineBus));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mgrid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countofpassessenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conductorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.txt_search_area = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_viewReport = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).BeginInit();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRASY.Properties.Resources.onlinebus;
            this.pictureBox1.Location = new System.Drawing.Point(203, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mgrid);
            this.metroPanel1.Controls.Add(this.metroPanel5);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.metroPanel1.Size = new System.Drawing.Size(1037, 566);
            this.metroPanel1.TabIndex = 78;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mgrid
            // 
            this.mgrid.AllowUserToDeleteRows = false;
            this.mgrid.AllowUserToResizeRows = false;
            this.mgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.no,
            this.bus_name,
            this.address,
            this.countofpassessenger,
            this.drivername,
            this.conductorname});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgrid.EnableHeadersVisualStyles = false;
            this.mgrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrid.Location = new System.Drawing.Point(0, 0);
            this.mgrid.Name = "mgrid";
            this.mgrid.ReadOnly = true;
            this.mgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgrid.RowHeadersVisible = false;
            this.mgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mgrid.RowTemplate.Height = 30;
            this.mgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrid.Size = new System.Drawing.Size(1037, 536);
            this.mgrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.mgrid.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 5;
            // 
            // no
            // 
            this.no.HeaderText = "NO";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 50;
            // 
            // bus_name
            // 
            this.bus_name.DataPropertyName = "bus_name";
            this.bus_name.HeaderText = "NAME";
            this.bus_name.Name = "bus_name";
            this.bus_name.ReadOnly = true;
            this.bus_name.Width = 150;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // countofpassessenger
            // 
            this.countofpassessenger.DataPropertyName = "passesngercount";
            this.countofpassessenger.HeaderText = "Count of Passenger";
            this.countofpassessenger.Name = "countofpassessenger";
            this.countofpassessenger.ReadOnly = true;
            // 
            // drivername
            // 
            this.drivername.DataPropertyName = "drivername";
            this.drivername.HeaderText = "Driver name";
            this.drivername.Name = "drivername";
            this.drivername.ReadOnly = true;
            this.drivername.Width = 200;
            // 
            // conductorname
            // 
            this.conductorname.DataPropertyName = "conductorname";
            this.conductorname.HeaderText = "Conductor name";
            this.conductorname.Name = "conductorname";
            this.conductorname.ReadOnly = true;
            this.conductorname.Width = 200;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.txt_search_area);
            this.metroPanel5.Controls.Add(this.btn_viewReport);
            this.metroPanel5.Controls.Add(this.materialFlatButton1);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(0, 536);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(1037, 25);
            this.metroPanel5.TabIndex = 3;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // txt_search_area
            // 
            this.txt_search_area.Depth = 0;
            this.txt_search_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_search_area.Hint = "Search...";
            this.txt_search_area.Location = new System.Drawing.Point(0, 0);
            this.txt_search_area.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search_area.Name = "txt_search_area";
            this.txt_search_area.PasswordChar = '\0';
            this.txt_search_area.SelectedText = "";
            this.txt_search_area.SelectionLength = 0;
            this.txt_search_area.SelectionStart = 0;
            this.txt_search_area.Size = new System.Drawing.Size(904, 23);
            this.txt_search_area.TabIndex = 79;
            this.txt_search_area.UseSystemPasswordChar = false;
            this.txt_search_area.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_area_KeyDown);
            // 
            // btn_viewReport
            // 
            this.btn_viewReport.AutoSize = true;
            this.btn_viewReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_viewReport.Depth = 0;
            this.btn_viewReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_viewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewReport.Location = new System.Drawing.Point(904, 0);
            this.btn_viewReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_viewReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_viewReport.Name = "btn_viewReport";
            this.btn_viewReport.Primary = false;
            this.btn_viewReport.Size = new System.Drawing.Size(63, 25);
            this.btn_viewReport.TabIndex = 78;
            this.btn_viewReport.Text = "Report";
            this.btn_viewReport.UseVisualStyleBackColor = true;
            this.btn_viewReport.Click += new System.EventHandler(this.btn_viewReport_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton1.Location = new System.Drawing.Point(967, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(70, 25);
            this.materialFlatButton1.TabIndex = 76;
            this.materialFlatButton1.Text = "Refresh";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // ListofOnlineBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ListofOnlineBus";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "List of Online Bus";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ListofOnlineBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).EndInit();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid mgrid;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn countofpassessenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivername;
        private System.Windows.Forms.DataGridViewTextBoxColumn conductorname;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_area;
        private MaterialSkin.Controls.MaterialFlatButton btn_viewReport;
    }
}