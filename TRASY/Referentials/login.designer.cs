namespace TRASY
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lbl_label = new System.Windows.Forms.Label();
            this.lbl_load = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_percent = new MetroFramework.Controls.MetroLabel();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.txt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.p_username = new System.Windows.Forms.PictureBox();
            this.p_password = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_password)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_label
            // 
            this.lbl_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_label.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_label.Location = new System.Drawing.Point(78, 5);
            this.lbl_label.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_label.Name = "lbl_label";
            this.lbl_label.Size = new System.Drawing.Size(246, 68);
            this.lbl_label.TabIndex = 10;
            this.lbl_label.Text = "TRASY";
            // 
            // lbl_load
            // 
            this.lbl_load.BackColor = System.Drawing.Color.Cyan;
            this.lbl_load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_load.Location = new System.Drawing.Point(1, 73);
            this.lbl_load.Name = "lbl_load";
            this.lbl_load.Size = new System.Drawing.Size(399, 2);
            this.lbl_load.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_version
            // 
            this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_version.Location = new System.Drawing.Point(1, 118);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(199, 61);
            this.lbl_version.TabIndex = 12;
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_percent.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_percent.Location = new System.Drawing.Point(170, 77);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(54, 19);
            this.lbl_percent.TabIndex = 13;
            this.lbl_percent.Text = "Percent";
            this.lbl_percent.UseCustomBackColor = true;
            this.lbl_percent.UseCustomForeColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(365, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(25, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "X";
            this.btn_cancel.UseCustomBackColor = true;
            this.btn_cancel.UseCustomForeColor = true;
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_username
            // 
            this.txt_username.Depth = 0;
            this.txt_username.Hint = "Username";
            this.txt_username.Location = new System.Drawing.Point(36, 88);
            this.txt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.Size = new System.Drawing.Size(312, 23);
            this.txt_username.TabIndex = 1;
            this.txt_username.UseSystemPasswordChar = false;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "Password";
            this.txt_password.Location = new System.Drawing.Point(35, 118);
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '⦾';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(312, 23);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = false;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.Depth = 0;
            this.btn_login.Location = new System.Drawing.Point(36, 146);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(311, 33);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // p_username
            // 
            this.p_username.Image = global::TRASY.Properties.Resources.username;
            this.p_username.Location = new System.Drawing.Point(353, 88);
            this.p_username.Margin = new System.Windows.Forms.Padding(2);
            this.p_username.Name = "p_username";
            this.p_username.Padding = new System.Windows.Forms.Padding(6, 2, 2, 50);
            this.p_username.Size = new System.Drawing.Size(29, 22);
            this.p_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_username.TabIndex = 6;
            this.p_username.TabStop = false;
            // 
            // p_password
            // 
            this.p_password.Image = global::TRASY.Properties.Resources.key;
            this.p_password.Location = new System.Drawing.Point(353, 118);
            this.p_password.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.p_password.Name = "p_password";
            this.p_password.Padding = new System.Windows.Forms.Padding(5, 2, 2, 6);
            this.p_password.Size = new System.Drawing.Size(28, 21);
            this.p_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_password.TabIndex = 7;
            this.p_password.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(393, 181);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_percent);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_load);
            this.Controls.Add(this.lbl_label);
            this.Controls.Add(this.p_username);
            this.Controls.Add(this.p_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.p_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox p_username;
        private System.Windows.Forms.PictureBox p_password;
        private System.Windows.Forms.Label lbl_label;
        private System.Windows.Forms.Label lbl_load;
        private System.Windows.Forms.Label lbl_version;
        private MetroFramework.Controls.MetroLabel lbl_percent;
        public System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
    }
}