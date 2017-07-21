namespace TRASY
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdn_female = new MetroFramework.Controls.MetroRadioButton();
            this.rdn_male = new MetroFramework.Controls.MetroRadioButton();
            this.cbo_position = new MetroFramework.Controls.MetroComboBox();
            this.dt_datestart = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mgrid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.txt_search_area = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_advance = new System.Windows.Forms.LinkLabel();
            this.pnl_advance = new System.Windows.Forms.Panel();
            this.lbl6 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_uisername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_first_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_middle_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_lastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl5 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_age = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_3453 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_date_registered = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_delete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_edit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_add = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).BeginInit();
            this.metroPanel5.SuspendLayout();
            this.pnl_advance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdn_female);
            this.groupBox1.Controls.Add(this.rdn_male);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(486, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 44);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rdn_female
            // 
            this.rdn_female.AutoSize = true;
            this.rdn_female.Location = new System.Drawing.Point(107, 23);
            this.rdn_female.Name = "rdn_female";
            this.rdn_female.Size = new System.Drawing.Size(61, 15);
            this.rdn_female.TabIndex = 20;
            this.rdn_female.Text = "Female";
            this.rdn_female.UseCustomBackColor = true;
            this.rdn_female.UseSelectable = true;
            // 
            // rdn_male
            // 
            this.rdn_male.AutoSize = true;
            this.rdn_male.Location = new System.Drawing.Point(40, 23);
            this.rdn_male.Name = "rdn_male";
            this.rdn_male.Size = new System.Drawing.Size(49, 15);
            this.rdn_male.TabIndex = 0;
            this.rdn_male.Text = "Male";
            this.rdn_male.UseCustomBackColor = true;
            this.rdn_male.UseSelectable = true;
            // 
            // cbo_position
            // 
            this.cbo_position.FormattingEnabled = true;
            this.cbo_position.ItemHeight = 23;
            this.cbo_position.Location = new System.Drawing.Point(486, 301);
            this.cbo_position.Name = "cbo_position";
            this.cbo_position.Size = new System.Drawing.Size(191, 29);
            this.cbo_position.TabIndex = 42;
            this.cbo_position.UseCustomBackColor = true;
            this.cbo_position.UseSelectable = true;
            // 
            // dt_datestart
            // 
            this.dt_datestart.Location = new System.Drawing.Point(486, 423);
            this.dt_datestart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_datestart.Name = "dt_datestart";
            this.dt_datestart.Size = new System.Drawing.Size(191, 29);
            this.dt_datestart.TabIndex = 39;
            this.dt_datestart.UseCustomBackColor = true;
            this.dt_datestart.Value = new System.DateTime(2016, 2, 8, 0, 0, 0, 0);
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
            this.metroPanel1.Size = new System.Drawing.Size(247, 465);
            this.metroPanel1.TabIndex = 0;
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
            this.mgrid.Size = new System.Drawing.Size(247, 433);
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
            this.metroPanel5.Location = new System.Drawing.Point(0, 433);
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
            this.txt_search_area.TabIndex = 75;
            this.txt_search_area.UseSystemPasswordChar = false;
            // 
            // lbl_advance
            // 
            this.lbl_advance.AutoSize = true;
            this.lbl_advance.Location = new System.Drawing.Point(483, 455);
            this.lbl_advance.Name = "lbl_advance";
            this.lbl_advance.Size = new System.Drawing.Size(50, 13);
            this.lbl_advance.TabIndex = 46;
            this.lbl_advance.TabStop = true;
            this.lbl_advance.Text = "Advance";
            this.lbl_advance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_advance_LinkClicked);
            // 
            // pnl_advance
            // 
            this.pnl_advance.Controls.Add(this.lbl6);
            this.pnl_advance.Controls.Add(this.txt_password);
            this.pnl_advance.Controls.Add(this.txt_uisername);
            this.pnl_advance.Controls.Add(this.materialLabel3);
            this.pnl_advance.Location = new System.Drawing.Point(402, 279);
            this.pnl_advance.Name = "pnl_advance";
            this.pnl_advance.Size = new System.Drawing.Size(304, 100);
            this.pnl_advance.TabIndex = 51;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Depth = 0;
            this.lbl6.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl6.Location = new System.Drawing.Point(9, 58);
            this.lbl6.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(75, 19);
            this.lbl6.TabIndex = 59;
            this.lbl6.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "";
            this.txt_password.Location = new System.Drawing.Point(90, 54);
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(191, 23);
            this.txt_password.TabIndex = 60;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // txt_uisername
            // 
            this.txt_uisername.Depth = 0;
            this.txt_uisername.Hint = "";
            this.txt_uisername.Location = new System.Drawing.Point(90, 25);
            this.txt_uisername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_uisername.Name = "txt_uisername";
            this.txt_uisername.PasswordChar = '\0';
            this.txt_uisername.SelectedText = "";
            this.txt_uisername.SelectionLength = 0;
            this.txt_uisername.SelectionStart = 0;
            this.txt_uisername.Size = new System.Drawing.Size(191, 23);
            this.txt_uisername.TabIndex = 58;
            this.txt_uisername.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(7, 29);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 57;
            this.materialLabel3.Text = "Username";
            // 
            // txt_first_name
            // 
            this.txt_first_name.Depth = 0;
            this.txt_first_name.Hint = "";
            this.txt_first_name.Location = new System.Drawing.Point(486, 214);
            this.txt_first_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.PasswordChar = '\0';
            this.txt_first_name.SelectedText = "";
            this.txt_first_name.SelectionLength = 0;
            this.txt_first_name.SelectionStart = 0;
            this.txt_first_name.Size = new System.Drawing.Size(191, 23);
            this.txt_first_name.TabIndex = 60;
            this.txt_first_name.UseSystemPasswordChar = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Depth = 0;
            this.lbl1.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl1.Location = new System.Drawing.Point(400, 218);
            this.lbl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(80, 19);
            this.lbl1.TabIndex = 59;
            this.lbl1.Text = "First name";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Depth = 0;
            this.lbl2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl2.Location = new System.Drawing.Point(387, 247);
            this.lbl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(95, 19);
            this.lbl2.TabIndex = 61;
            this.lbl2.Text = "Middle name";
            // 
            // txt_middle_name
            // 
            this.txt_middle_name.Depth = 0;
            this.txt_middle_name.Hint = "";
            this.txt_middle_name.Location = new System.Drawing.Point(486, 243);
            this.txt_middle_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_middle_name.Name = "txt_middle_name";
            this.txt_middle_name.PasswordChar = '\0';
            this.txt_middle_name.SelectedText = "";
            this.txt_middle_name.SelectionLength = 0;
            this.txt_middle_name.SelectionStart = 0;
            this.txt_middle_name.Size = new System.Drawing.Size(191, 23);
            this.txt_middle_name.TabIndex = 62;
            this.txt_middle_name.UseSystemPasswordChar = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Depth = 0;
            this.lbl3.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl3.Location = new System.Drawing.Point(403, 276);
            this.lbl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(79, 19);
            this.lbl3.TabIndex = 63;
            this.lbl3.Text = "Last name";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Depth = 0;
            this.txt_lastname.Hint = "";
            this.txt_lastname.Location = new System.Drawing.Point(486, 272);
            this.txt_lastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.PasswordChar = '\0';
            this.txt_lastname.SelectedText = "";
            this.txt_lastname.SelectionLength = 0;
            this.txt_lastname.SelectionStart = 0;
            this.txt_lastname.Size = new System.Drawing.Size(191, 23);
            this.txt_lastname.TabIndex = 64;
            this.txt_lastname.UseSystemPasswordChar = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Depth = 0;
            this.lbl5.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl5.Location = new System.Drawing.Point(415, 311);
            this.lbl5.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(65, 19);
            this.lbl5.TabIndex = 65;
            this.lbl5.Text = "Position";
            // 
            // txt_age
            // 
            this.txt_age.Depth = 0;
            this.txt_age.Hint = "";
            this.txt_age.Location = new System.Drawing.Point(486, 386);
            this.txt_age.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_age.Name = "txt_age";
            this.txt_age.PasswordChar = '\0';
            this.txt_age.SelectedText = "";
            this.txt_age.SelectionLength = 0;
            this.txt_age.SelectionStart = 0;
            this.txt_age.Size = new System.Drawing.Size(89, 23);
            this.txt_age.TabIndex = 67;
            this.txt_age.UseSystemPasswordChar = false;
            // 
            // lbl_3453
            // 
            this.lbl_3453.AutoSize = true;
            this.lbl_3453.Depth = 0;
            this.lbl_3453.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_3453.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_3453.Location = new System.Drawing.Point(445, 390);
            this.lbl_3453.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_3453.Name = "lbl_3453";
            this.lbl_3453.Size = new System.Drawing.Size(35, 19);
            this.lbl_3453.TabIndex = 66;
            this.lbl_3453.Text = "Age";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(406, 433);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(76, 19);
            this.materialLabel8.TabIndex = 68;
            this.materialLabel8.Text = "Date Start";
            // 
            // lbl_date_registered
            // 
            this.lbl_date_registered.AutoSize = true;
            this.lbl_date_registered.Depth = 0;
            this.lbl_date_registered.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_date_registered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_date_registered.Location = new System.Drawing.Point(442, 183);
            this.lbl_date_registered.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_date_registered.Name = "lbl_date_registered";
            this.lbl_date_registered.Size = new System.Drawing.Size(38, 19);
            this.lbl_date_registered.TabIndex = 69;
            this.lbl_date_registered.Text = "date";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Location = new System.Drawing.Point(662, 87);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(64, 36);
            this.btn_cancel.TabIndex = 74;
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
            this.btn_save.Location = new System.Drawing.Point(608, 87);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = false;
            this.btn_save.Size = new System.Drawing.Size(46, 36);
            this.btn_save.TabIndex = 73;
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
            this.btn_delete.Location = new System.Drawing.Point(506, 87);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = false;
            this.btn_delete.Size = new System.Drawing.Size(60, 36);
            this.btn_delete.TabIndex = 72;
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
            this.btn_edit.Location = new System.Drawing.Point(457, 87);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Primary = false;
            this.btn_edit.Size = new System.Drawing.Size(41, 36);
            this.btn_edit.TabIndex = 71;
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
            this.btn_add.Location = new System.Drawing.Point(413, 87);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Primary = false;
            this.btn_add.Size = new System.Drawing.Size(39, 36);
            this.btn_add.TabIndex = 70;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRASY.Properties.Resources.employees;
            this.pictureBox1.Location = new System.Drawing.Point(129, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_date_registered);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.lbl_3453);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt_middle_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl_advance);
            this.Controls.Add(this.cbo_position);
            this.Controls.Add(this.dt_datestart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pnl_advance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Employee";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Employee";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Users_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).EndInit();
            this.metroPanel5.ResumeLayout(false);
            this.pnl_advance.ResumeLayout(false);
            this.pnl_advance.PerformLayout();
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
        private MetroFramework.Controls.MetroComboBox cbo_position;
        private MetroFramework.Controls.MetroDateTime dt_datestart;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdn_female;
        private MetroFramework.Controls.MetroRadioButton rdn_male;
        private System.Windows.Forms.LinkLabel lbl_advance;
        private System.Windows.Forms.Panel pnl_advance;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_uisername;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lbl6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_first_name;
        private MaterialSkin.Controls.MaterialLabel lbl1;
        private MaterialSkin.Controls.MaterialLabel lbl2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_middle_name;
        private MaterialSkin.Controls.MaterialLabel lbl3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_lastname;
        private MaterialSkin.Controls.MaterialLabel lbl5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_age;
        private MaterialSkin.Controls.MaterialLabel lbl_3453;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lbl_date_registered;
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialFlatButton btn_save;
        private MaterialSkin.Controls.MaterialFlatButton btn_delete;
        private MaterialSkin.Controls.MaterialFlatButton btn_edit;
        private MaterialSkin.Controls.MaterialFlatButton btn_add;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_area;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}