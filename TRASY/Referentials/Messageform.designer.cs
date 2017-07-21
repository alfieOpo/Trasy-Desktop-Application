namespace TRASY
{
    partial class Messageform
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
            this.txt_message = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_bus_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_message
            // 
            this.txt_message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_message.AutoCompleteCustomSource.AddRange(new string[] {
            "this",
            "are",
            "the",
            "where",
            "from",
            "management"});
            this.txt_message.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_message.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.Location = new System.Drawing.Point(25, 90);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_message.Size = new System.Drawing.Size(654, 346);
            this.txt_message.TabIndex = 0;
            this.txt_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(474, 39);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(46, 18);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "label1";
            // 
            // lbl_bus_name
            // 
            this.lbl_bus_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_bus_name.AutoSize = true;
            this.lbl_bus_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bus_name.Location = new System.Drawing.Point(18, 17);
            this.lbl_bus_name.Name = "lbl_bus_name";
            this.lbl_bus_name.Size = new System.Drawing.Size(124, 42);
            this.lbl_bus_name.TabIndex = 2;
            this.lbl_bus_name.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(674, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(21, 63);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(60, 24);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "label1";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Messageform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 448);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_bus_name);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_message);
            this.Name = "Messageform";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Messageform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_bus_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_title;
    }
}