namespace TRASY
{
    partial class confirmapassword
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
            this.lbl_error = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_cancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error.Location = new System.Drawing.Point(33, 8);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(35, 19);
            this.lbl_error.TabIndex = 2;
            this.lbl_error.Text = "Alfie";
            this.lbl_error.UseCustomBackColor = true;
            this.lbl_error.UseCustomForeColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Press Enter...";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Depth = 0;
            this.metroTextBox1.Hint = "Password";
            this.metroTextBox1.Location = new System.Drawing.Point(40, 28);
            this.metroTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(305, 23);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSystemPasswordChar = false;
            this.metroTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox1_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Location = new System.Drawing.Point(270, 57);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = true;
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // confirmapassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(368, 85);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_error);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "confirmapassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.Load += new System.EventHandler(this.confirmapassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lbl_error;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField metroTextBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cancel;
    }
}