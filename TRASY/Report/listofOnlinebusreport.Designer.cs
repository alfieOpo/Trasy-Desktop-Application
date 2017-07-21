namespace TRASY.Report
{
    partial class listofOnlinebusreport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new TRASY.Report.DataSet1();
            this.vieweronlinebus = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataMember = "bus";
            this.busBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vieweronlinebus
            // 
            this.vieweronlinebus.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "onlinebus";
            reportDataSource1.Value = this.busBindingSource;
            this.vieweronlinebus.LocalReport.DataSources.Add(reportDataSource1);
            this.vieweronlinebus.LocalReport.ReportEmbeddedResource = "TRASY.Report.Report1.rdlc";
            this.vieweronlinebus.Location = new System.Drawing.Point(20, 60);
            this.vieweronlinebus.Name = "vieweronlinebus";
            this.vieweronlinebus.Size = new System.Drawing.Size(825, 605);
            this.vieweronlinebus.TabIndex = 0;
            // 
            // listofOnlinebusreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 685);
            this.Controls.Add(this.vieweronlinebus);
            this.Name = "listofOnlinebusreport";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "List of Online Bus";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.listofOnlinebusreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer vieweronlinebus;
        private System.Windows.Forms.BindingSource busBindingSource;
        private DataSet1 DataSet1;
    }
}