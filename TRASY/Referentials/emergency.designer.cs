namespace TRASY
{
    partial class emergency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emergency));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mgrid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.txt_search_area = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_title = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_add = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_content = new MetroFramework.Controls.MetroTextBox();
            this.btn_edit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_delete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).BeginInit();
            this.metroPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.metroPanel1.Size = new System.Drawing.Size(247, 376);
            this.metroPanel1.TabIndex = 9;
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
            this.mgrid.Size = new System.Drawing.Size(247, 348);
            this.mgrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.mgrid.TabIndex = 4;
            this.mgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellClick);
            this.mgrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellEnter);
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
            this.metroPanel5.Location = new System.Drawing.Point(0, 348);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(247, 23);
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
            this.txt_search_area.TabIndex = 2;
            this.txt_search_area.UseSystemPasswordChar = false;
            // 
            // txt_title
            // 
            this.txt_title.Depth = 0;
            this.txt_title.Hint = "";
            this.txt_title.Location = new System.Drawing.Point(355, 140);
            this.txt_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.SelectedText = "";
            this.txt_title.SelectionLength = 0;
            this.txt_title.SelectionStart = 0;
            this.txt_title.Size = new System.Drawing.Size(364, 23);
            this.txt_title.TabIndex = 19;
            this.txt_title.UseSystemPasswordChar = false;
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_add.Depth = 0;
            this.btn_add.Location = new System.Drawing.Point(381, 95);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Primary = false;
            this.btn_add.Size = new System.Drawing.Size(39, 36);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_content
            // 
            this.txt_content.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_content.CustomButton.Image = null;
            this.txt_content.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txt_content.CustomButton.Name = "";
            this.txt_content.CustomButton.Size = new System.Drawing.Size(211, 211);
            this.txt_content.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_content.CustomButton.TabIndex = 1;
            this.txt_content.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_content.CustomButton.UseSelectable = true;
            this.txt_content.CustomButton.Visible = false;
            this.txt_content.Lines = new string[0];
            this.txt_content.Location = new System.Drawing.Point(355, 182);
            this.txt_content.MaxLength = 32767;
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.PasswordChar = '\0';
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_content.SelectedText = "";
            this.txt_content.SelectionLength = 0;
            this.txt_content.SelectionStart = 0;
            this.txt_content.ShortcutsEnabled = true;
            this.txt_content.Size = new System.Drawing.Size(364, 213);
            this.txt_content.TabIndex = 22;
            this.txt_content.UseSelectable = true;
            this.txt_content.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_content.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_edit
            // 
            this.btn_edit.AutoSize = true;
            this.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_edit.Depth = 0;
            this.btn_edit.Location = new System.Drawing.Point(425, 95);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Primary = false;
            this.btn_edit.Size = new System.Drawing.Size(41, 36);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_delete.Depth = 0;
            this.btn_delete.Location = new System.Drawing.Point(474, 95);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = false;
            this.btn_delete.Size = new System.Drawing.Size(60, 36);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_save.Depth = 0;
            this.btn_save.Location = new System.Drawing.Point(576, 95);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = false;
            this.btn_save.Size = new System.Drawing.Size(46, 36);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Location = new System.Drawing.Point(630, 95);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(64, 36);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(310, 144);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Title";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(287, 182);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Content";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRASY.Properties.Resources.ambulance;
            this.pictureBox1.Location = new System.Drawing.Point(144, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // emergency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "emergency";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Emergency";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.emergency_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.emergency_MouseDown);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).EndInit();
            this.metroPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid mgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_title;
        private MaterialSkin.Controls.MaterialFlatButton btn_add;
        private MetroFramework.Controls.MetroTextBox txt_content;
        private MaterialSkin.Controls.MaterialFlatButton btn_edit;
        private MaterialSkin.Controls.MaterialFlatButton btn_delete;
        private MaterialSkin.Controls.MaterialFlatButton btn_save;
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_area;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}