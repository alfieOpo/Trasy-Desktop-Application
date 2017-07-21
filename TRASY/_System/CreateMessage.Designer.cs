namespace TRASY._System
{
    partial class CreateMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMessage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_title = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_bus_name = new MaterialSkin.Controls.MaterialLabel();
            this.cbo_bus_online = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbo_type_message = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Controls.Add(this.lbl_bus_name);
            this.panel1.Controls.Add(this.cbo_bus_online);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.cbo_type_message);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 33);
            this.panel1.TabIndex = 0;
            // 
            // txt_title
            // 
            this.txt_title.Depth = 0;
            this.txt_title.Hint = "Title";
            this.txt_title.Location = new System.Drawing.Point(22, 6);
            this.txt_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.SelectedText = "";
            this.txt_title.SelectionLength = 0;
            this.txt_title.SelectionStart = 0;
            this.txt_title.Size = new System.Drawing.Size(231, 23);
            this.txt_title.TabIndex = 47;
            this.txt_title.UseSystemPasswordChar = false;
            // 
            // lbl_bus_name
            // 
            this.lbl_bus_name.AutoSize = true;
            this.lbl_bus_name.Depth = 0;
            this.lbl_bus_name.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_bus_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_bus_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bus_name.Location = new System.Drawing.Point(276, 0);
            this.lbl_bus_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_bus_name.Name = "lbl_bus_name";
            this.lbl_bus_name.Size = new System.Drawing.Size(75, 19);
            this.lbl_bus_name.TabIndex = 46;
            this.lbl_bus_name.Text = "Bus name";
            // 
            // cbo_bus_online
            // 
            this.cbo_bus_online.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbo_bus_online.FormattingEnabled = true;
            this.cbo_bus_online.ItemHeight = 23;
            this.cbo_bus_online.Items.AddRange(new object[] {
            "Alert",
            "Emergency",
            "Personal"});
            this.cbo_bus_online.Location = new System.Drawing.Point(351, 0);
            this.cbo_bus_online.Name = "cbo_bus_online";
            this.cbo_bus_online.Size = new System.Drawing.Size(169, 29);
            this.cbo_bus_online.TabIndex = 45;
            this.cbo_bus_online.UseCustomBackColor = true;
            this.cbo_bus_online.UseSelectable = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(520, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(124, 19);
            this.materialLabel1.TabIndex = 44;
            this.materialLabel1.Text = "Type of Message";
            // 
            // cbo_type_message
            // 
            this.cbo_type_message.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbo_type_message.FormattingEnabled = true;
            this.cbo_type_message.ItemHeight = 23;
            this.cbo_type_message.Items.AddRange(new object[] {
            "Alert",
            "Personal"});
            this.cbo_type_message.Location = new System.Drawing.Point(644, 0);
            this.cbo_type_message.Name = "cbo_type_message";
            this.cbo_type_message.Size = new System.Drawing.Size(122, 29);
            this.cbo_type_message.TabIndex = 43;
            this.cbo_type_message.UseCustomBackColor = true;
            this.cbo_type_message.UseSelectable = true;
            this.cbo_type_message.DropDownClosed += new System.EventHandler(this.cbo_type_message_DropDownClosed);
            this.cbo_type_message.TextChanged += new System.EventHandler(this.cbo_type_message_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialRaisedButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 57);
            this.panel2.TabIndex = 1;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialRaisedButton1.Location = new System.Drawing.Point(0, 0);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(766, 57);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Send";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // txt_content
            // 
            this.txt_content.BackColor = System.Drawing.Color.White;
            this.txt_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_content.Location = new System.Drawing.Point(20, 93);
            this.txt_content.Margin = new System.Windows.Forms.Padding(30);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_content.Size = new System.Drawing.Size(766, 334);
            this.txt_content.TabIndex = 2;
            // 
            // CreateMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 504);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateMessage";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "CreateMessage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CreateMessage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroComboBox cbo_type_message;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_title;
        private MaterialSkin.Controls.MaterialLabel lbl_bus_name;
        private MetroFramework.Controls.MetroComboBox cbo_bus_online;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.TextBox txt_content;
    }
}