namespace TRASY
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mgrid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.txt_search_area = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_edit_password = new System.Windows.Forms.LinkLabel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_delete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_edit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_add = new MaterialSkin.Controls.MaterialFlatButton();
            this.chk_is_admin = new MaterialSkin.Controls.MaterialCheckBox();
            this.metroButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_first_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_middle_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_lastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_password = new MaterialSkin.Controls.MaterialLabel();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_confirm_password = new MaterialSkin.Controls.MaterialLabel();
            this.txt_confirma_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_date_registered = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageviewer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).BeginInit();
            this.metroPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageviewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.metroPanel1.Size = new System.Drawing.Size(247, 391);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mgrid
            // 
            this.mgrid.AllowUserToAddRows = false;
            this.mgrid.AllowUserToDeleteRows = false;
            this.mgrid.AllowUserToResizeColumns = false;
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
            this.mgrid.Size = new System.Drawing.Size(247, 359);
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
            this.metroPanel5.Location = new System.Drawing.Point(0, 359);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(247, 27);
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
            this.txt_search_area.TabIndex = 40;
            this.txt_search_area.UseSystemPasswordChar = false;
            // 
            // lbl_edit_password
            // 
            this.lbl_edit_password.AutoSize = true;
            this.lbl_edit_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_password.Location = new System.Drawing.Point(406, 348);
            this.lbl_edit_password.Name = "lbl_edit_password";
            this.lbl_edit_password.Size = new System.Drawing.Size(97, 13);
            this.lbl_edit_password.TabIndex = 19;
            this.lbl_edit_password.TabStop = true;
            this.lbl_edit_password.Text = "✎... Edit Password";
            this.lbl_edit_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_edit_password_LinkClicked);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Location = new System.Drawing.Point(658, 105);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(64, 36);
            this.btn_cancel.TabIndex = 36;
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
            this.btn_save.Location = new System.Drawing.Point(604, 105);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = false;
            this.btn_save.Size = new System.Drawing.Size(46, 36);
            this.btn_save.TabIndex = 35;
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
            this.btn_delete.Location = new System.Drawing.Point(502, 105);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = false;
            this.btn_delete.Size = new System.Drawing.Size(60, 36);
            this.btn_delete.TabIndex = 34;
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
            this.btn_edit.Location = new System.Drawing.Point(453, 105);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Primary = false;
            this.btn_edit.Size = new System.Drawing.Size(41, 36);
            this.btn_edit.TabIndex = 33;
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
            this.btn_add.Location = new System.Drawing.Point(409, 105);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Primary = false;
            this.btn_add.Size = new System.Drawing.Size(39, 36);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // chk_is_admin
            // 
            this.chk_is_admin.AutoSize = true;
            this.chk_is_admin.Depth = 0;
            this.chk_is_admin.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk_is_admin.Location = new System.Drawing.Point(406, 403);
            this.chk_is_admin.Margin = new System.Windows.Forms.Padding(0);
            this.chk_is_admin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_is_admin.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_is_admin.Name = "chk_is_admin";
            this.chk_is_admin.Ripple = true;
            this.chk_is_admin.Size = new System.Drawing.Size(70, 30);
            this.chk_is_admin.TabIndex = 37;
            this.chk_is_admin.Text = "Admin";
            this.chk_is_admin.UseVisualStyleBackColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Depth = 0;
            this.metroButton1.Location = new System.Drawing.Point(658, 415);
            this.metroButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Primary = true;
            this.metroButton1.Size = new System.Drawing.Size(200, 36);
            this.metroButton1.TabIndex = 38;
            this.metroButton1.Text = "BROWse";
            this.metroButton1.UseVisualStyleBackColor = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(319, 202);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 40;
            this.materialLabel1.Text = "First name";
            // 
            // txt_first_name
            // 
            this.txt_first_name.Depth = 0;
            this.txt_first_name.Hint = "";
            this.txt_first_name.Location = new System.Drawing.Point(405, 202);
            this.txt_first_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.PasswordChar = '\0';
            this.txt_first_name.SelectedText = "";
            this.txt_first_name.SelectionLength = 0;
            this.txt_first_name.SelectionStart = 0;
            this.txt_first_name.Size = new System.Drawing.Size(191, 23);
            this.txt_first_name.TabIndex = 39;
            this.txt_first_name.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(307, 235);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(95, 19);
            this.materialLabel2.TabIndex = 42;
            this.materialLabel2.Text = "Middle name";
            // 
            // txt_middle_name
            // 
            this.txt_middle_name.Depth = 0;
            this.txt_middle_name.Hint = "";
            this.txt_middle_name.Location = new System.Drawing.Point(405, 231);
            this.txt_middle_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_middle_name.Name = "txt_middle_name";
            this.txt_middle_name.PasswordChar = '\0';
            this.txt_middle_name.SelectedText = "";
            this.txt_middle_name.SelectionLength = 0;
            this.txt_middle_name.SelectionStart = 0;
            this.txt_middle_name.Size = new System.Drawing.Size(191, 23);
            this.txt_middle_name.TabIndex = 41;
            this.txt_middle_name.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(320, 264);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 44;
            this.materialLabel3.Text = "Last name";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Depth = 0;
            this.txt_lastname.Hint = "";
            this.txt_lastname.Location = new System.Drawing.Point(405, 260);
            this.txt_lastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.PasswordChar = '\0';
            this.txt_lastname.SelectedText = "";
            this.txt_lastname.SelectionLength = 0;
            this.txt_lastname.SelectionStart = 0;
            this.txt_lastname.Size = new System.Drawing.Size(191, 23);
            this.txt_lastname.TabIndex = 43;
            this.txt_lastname.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(322, 319);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 19);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Depth = 0;
            this.txt_username.Hint = "";
            this.txt_username.Location = new System.Drawing.Point(405, 315);
            this.txt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.Size = new System.Drawing.Size(191, 23);
            this.txt_username.TabIndex = 45;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Depth = 0;
            this.lbl_password.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_password.Location = new System.Drawing.Point(327, 348);
            this.lbl_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(75, 19);
            this.lbl_password.TabIndex = 48;
            this.lbl_password.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "";
            this.txt_password.Location = new System.Drawing.Point(405, 348);
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '⦿';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(191, 23);
            this.txt_password.TabIndex = 47;
            this.txt_password.UseSystemPasswordChar = false;
            this.txt_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyUp);
            // 
            // lbl_confirm_password
            // 
            this.lbl_confirm_password.AutoSize = true;
            this.lbl_confirm_password.Depth = 0;
            this.lbl_confirm_password.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_confirm_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_confirm_password.Location = new System.Drawing.Point(269, 381);
            this.lbl_confirm_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_confirm_password.Name = "lbl_confirm_password";
            this.lbl_confirm_password.Size = new System.Drawing.Size(133, 19);
            this.lbl_confirm_password.TabIndex = 50;
            this.lbl_confirm_password.Text = "Confirm Password";
            // 
            // txt_confirma_password
            // 
            this.txt_confirma_password.Depth = 0;
            this.txt_confirma_password.Hint = "";
            this.txt_confirma_password.Location = new System.Drawing.Point(405, 377);
            this.txt_confirma_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_confirma_password.Name = "txt_confirma_password";
            this.txt_confirma_password.PasswordChar = '⦿';
            this.txt_confirma_password.SelectedText = "";
            this.txt_confirma_password.SelectionLength = 0;
            this.txt_confirma_password.SelectionStart = 0;
            this.txt_confirma_password.Size = new System.Drawing.Size(191, 23);
            this.txt_confirma_password.TabIndex = 49;
            this.txt_confirma_password.UseSystemPasswordChar = false;
            this.txt_confirma_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_confirma_password_KeyUp);
            // 
            // lbl_date_registered
            // 
            this.lbl_date_registered.AutoSize = true;
            this.lbl_date_registered.Depth = 0;
            this.lbl_date_registered.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_date_registered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_date_registered.Location = new System.Drawing.Point(655, 188);
            this.lbl_date_registered.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_date_registered.Name = "lbl_date_registered";
            this.lbl_date_registered.Size = new System.Drawing.Size(38, 19);
            this.lbl_date_registered.TabIndex = 51;
            this.lbl_date_registered.Text = "date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(602, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // imageviewer
            // 
            this.imageviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageviewer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageviewer.ErrorImage")));
            this.imageviewer.Location = new System.Drawing.Point(658, 209);
            this.imageviewer.Name = "imageviewer";
            this.imageviewer.Size = new System.Drawing.Size(200, 200);
            this.imageviewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageviewer.TabIndex = 24;
            this.imageviewer.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TRASY.Properties.Resources.businessman;
            this.pictureBox2.Location = new System.Drawing.Point(85, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 471);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_date_registered);
            this.Controls.Add(this.lbl_confirm_password);
            this.Controls.Add(this.txt_confirma_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txt_middle_name);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.chk_is_admin);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.imageviewer);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lbl_edit_password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Users";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Users";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Users_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Users_MouseDown);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).EndInit();
            this.metroPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageviewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.LinkLabel lbl_edit_password;
        private System.Windows.Forms.PictureBox imageviewer;
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialFlatButton btn_save;
        private MaterialSkin.Controls.MaterialFlatButton btn_delete;
        private MaterialSkin.Controls.MaterialFlatButton btn_edit;
        private MaterialSkin.Controls.MaterialFlatButton btn_add;
        private MaterialSkin.Controls.MaterialCheckBox chk_is_admin;
        private MaterialSkin.Controls.MaterialRaisedButton metroButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_first_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_middle_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_lastname;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_username;
        private MaterialSkin.Controls.MaterialLabel lbl_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialLabel lbl_confirm_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_confirma_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_area;
        private MaterialSkin.Controls.MaterialLabel lbl_date_registered;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}