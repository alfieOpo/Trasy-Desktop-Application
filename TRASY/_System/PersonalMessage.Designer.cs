namespace TRASY._System
{
    partial class PersonalMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalMessage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mgrid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.txt_search_area = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.messagelist = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).BeginInit();
            this.metroPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRASY.Properties.Resources.speech_bubble__2_;
            this.pictureBox1.Location = new System.Drawing.Point(208, 28);
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
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.metroPanel1.Size = new System.Drawing.Size(261, 503);
            this.metroPanel1.TabIndex = 78;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mgrid
            // 
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
            this.name});
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
            this.mgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrid.Size = new System.Drawing.Size(261, 471);
            this.mgrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.mgrid.TabIndex = 4;
            this.mgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellClick);
            this.mgrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellEnter);
            // 
            // id
            // 
            this.id.DataPropertyName = "bus_plate_no";
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
            this.no.Width = 30;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "bus_name";
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.txt_search_area);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(0, 471);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(261, 27);
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
            this.txt_search_area.Size = new System.Drawing.Size(261, 23);
            this.txt_search_area.TabIndex = 75;
            this.txt_search_area.UseSystemPasswordChar = false;
            this.txt_search_area.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_area_KeyDown);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoEllipsis = true;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(281, 60);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_title.Size = new System.Drawing.Size(556, 47);
            this.lbl_title.TabIndex = 84;
            this.lbl_title.Text = "label1";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(281, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 32);
            this.panel1.TabIndex = 86;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialFlatButton1.Location = new System.Drawing.Point(486, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(70, 32);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "refresh";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // messagelist
            // 
            this.messagelist.AutoScroll = true;
            this.messagelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagelist.Location = new System.Drawing.Point(281, 107);
            this.messagelist.Name = "messagelist";
            this.messagelist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.messagelist.Size = new System.Drawing.Size(556, 424);
            this.messagelist.TabIndex = 87;
            this.messagelist.Paint += new System.Windows.Forms.PaintEventHandler(this.messagelist_Paint);
            // 
            // PersonalMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 583);
            this.Controls.Add(this.messagelist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonalMessage";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Personal Message";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PersonalMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).EndInit();
            this.metroPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid mgrid;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_area;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel messagelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}