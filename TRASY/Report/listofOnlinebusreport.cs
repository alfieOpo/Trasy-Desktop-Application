using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRASY.Report
{
    public partial class listofOnlinebusreport : MetroForm
    {
        public listofOnlinebusreport()
        {
            InitializeComponent();
        }

        private void listofOnlinebusreport_Load(object sender, EventArgs e)
        {
            string sql = @"select 
buses.bus_name,
buses.bus_plate_no,
activebus.passesngercount,
concat(driver.first_name,' ',
driver.last_name) drivername,
concat(conductor.first_name,' ',conductor.last_name) conductorname
from activebus
left join buses on buses.id = activebus.bus_id
left
join employee driver on driver.id = activebus.driver_id
left
join employee conductor  on conductor.id = activebus.con_id";

            Program.da.Select(sql);
            DataTable dt = new System.Data.DataTable();
            dt = Program.da.getTable();
            ReportDataSource rds = new ReportDataSource("onlinebus",dt);
            ReportParameter p = new ReportParameter("fullname", Program.user.first_name+" "+Program.user.last_name);        
            ReportParameter p2 = new ReportParameter("date", DateTime.Now.ToLongDateString());
        
            this.vieweronlinebus.LocalReport.SetParameters(new ReportParameter[] { p, p2 });
            this.vieweronlinebus.LocalReport.DataSources.Clear();
            this.vieweronlinebus.LocalReport.DataSources.Add(rds);
            this.vieweronlinebus.LocalReport.Refresh();
            this.vieweronlinebus.RefreshReport();
        }
    }
}
