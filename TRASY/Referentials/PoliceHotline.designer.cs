namespace TRASY
{
    partial class PoliceHotline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoliceHotline));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbo_location = new MetroFramework.Controls.MetroComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.txt_search_area = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mgrid = new MetroFramework.Controls.MetroGrid();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_delete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_edit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_add = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_statation_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_hot_line_number = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_code = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel5.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(321, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_location
            // 
            this.cbo_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_location.FormattingEnabled = true;
            this.cbo_location.ItemHeight = 23;
            this.cbo_location.Location = new System.Drawing.Point(402, 242);
            this.cbo_location.Name = "cbo_location";
            this.cbo_location.Size = new System.Drawing.Size(191, 29);
            this.cbo_location.TabIndex = 19;
            this.cbo_location.UseSelectable = true;
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
            this.no.Width = 30;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
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
            this.metroPanel5.Location = new System.Drawing.Point(0, 306);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(247, 24);
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
            this.txt_search_area.Size = new System.Drawing.Size(247, 23);
            this.txt_search_area.TabIndex = 37;
            this.txt_search_area.UseSystemPasswordChar = false;
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
            this.metroPanel1.Size = new System.Drawing.Size(247, 335);
            this.metroPanel1.TabIndex = 3;
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
            this._id,
            this._no,
            this._name});
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
            this.mgrid.Size = new System.Drawing.Size(247, 306);
            this.mgrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.mgrid.TabIndex = 4;
            this.mgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellClick);
            this.mgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellContentClick);
            this.mgrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellEnter);
            this.mgrid.CellErrorTextChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellErrorTextChanged);
            // 
            // _id
            // 
            this._id.DataPropertyName = "id";
            this._id.HeaderText = "Column1";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Visible = false;
            // 
            // _no
            // 
            this._no.HeaderText = "NO";
            this._no.Name = "_no";
            this._no.ReadOnly = true;
            this._no.Width = 30;
            // 
            // _name
            // 
            this._name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._name.DataPropertyName = "name";
            this._name.HeaderText = "NAME";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Location = new System.Drawing.Point(635, 158);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(64, 36);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_save.Depth = 0;
            this.btn_save.Location = new System.Drawing.Point(581, 158);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = false;
            this.btn_save.Size = new System.Drawing.Size(46, 36);
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_delete.Depth = 0;
            this.btn_delete.Location = new System.Drawing.Point(492, 158);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = false;
            this.btn_delete.Size = new System.Drawing.Size(60, 36);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AutoSize = true;
            this.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_edit.Depth = 0;
            this.btn_edit.Location = new System.Drawing.Point(443, 158);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Primary = false;
            this.btn_edit.Size = new System.Drawing.Size(41, 36);
            this.btn_edit.TabIndex = 28;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_add.Depth = 0;
            this.btn_add.Location = new System.Drawing.Point(399, 158);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Primary = false;
            this.btn_add.Size = new System.Drawing.Size(39, 36);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(326, 252);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Location";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(280, 277);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(116, 19);
            this.materialLabel2.TabIndex = 33;
            this.materialLabel2.Text = "Hot line number";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(292, 217);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(98, 19);
            this.materialLabel3.TabIndex = 34;
            this.materialLabel3.Text = "Station name";
            // 
            // txt_statation_name
            // 
            this.txt_statation_name.Depth = 0;
            this.txt_statation_name.Hint = "";
            this.txt_statation_name.Location = new System.Drawing.Point(402, 213);
            this.txt_statation_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_statation_name.Name = "txt_statation_name";
            this.txt_statation_name.PasswordChar = '\0';
            this.txt_statation_name.SelectedText = "";
            this.txt_statation_name.SelectionLength = 0;
            this.txt_statation_name.SelectionStart = 0;
            this.txt_statation_name.Size = new System.Drawing.Size(318, 23);
            this.txt_statation_name.TabIndex = 35;
            this.txt_statation_name.UseSystemPasswordChar = false;
            // 
            // txt_hot_line_number
            // 
            this.txt_hot_line_number.Depth = 0;
            this.txt_hot_line_number.Hint = "";
            this.txt_hot_line_number.Location = new System.Drawing.Point(402, 277);
            this.txt_hot_line_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_hot_line_number.Name = "txt_hot_line_number";
            this.txt_hot_line_number.PasswordChar = '\0';
            this.txt_hot_line_number.SelectedText = "";
            this.txt_hot_line_number.SelectionLength = 0;
            this.txt_hot_line_number.SelectionStart = 0;
            this.txt_hot_line_number.Size = new System.Drawing.Size(191, 23);
            this.txt_hot_line_number.TabIndex = 36;
            this.txt_hot_line_number.UseSystemPasswordChar = false;
            // 
            // txt_code
            // 
            this.txt_code.AutoSize = true;
            this.txt_code.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_code.Depth = 0;
            this.txt_code.Location = new System.Drawing.Point(445, 110);
            this.txt_code.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_code.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_code.Name = "txt_code";
            this.txt_code.Primary = false;
            this.txt_code.Size = new System.Drawing.Size(8, 36);
            this.txt_code.TabIndex = 37;
            this.txt_code.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRASY.Properties.Resources.phone_number;
            this.pictureBox1.Location = new System.Drawing.Point(167, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // PoliceHotline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_hot_line_number);
            this.Controls.Add(this.txt_statation_name);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbo_location);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PoliceHotline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Police Hotline";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PoliceHotline_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PoliceHotline_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PoliceHotline_MouseDown);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbo_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid mgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _no;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
     
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialFlatButton btn_save;
        private MaterialSkin.Controls.MaterialFlatButton btn_delete;
        private MaterialSkin.Controls.MaterialFlatButton btn_edit;
        private MaterialSkin.Controls.MaterialFlatButton btn_add;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_statation_name;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_hot_line_number;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_area;
        private MaterialSkin.Controls.MaterialFlatButton txt_code;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}