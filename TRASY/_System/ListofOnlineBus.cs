using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TRASY.Report;

namespace TRASY._System
{
    public partial class ListofOnlineBus : MetroForm
    {
        static string baseUri = "http://maps.googleapis.com/maps/api/geocode/xml?latlng={0},{1}&sensor=false";
        public ListofOnlineBus()
        {
            InitializeComponent();
        }

        private void ListofOnlineBus_Load(object sender, EventArgs e)
        {
            loadList(txt_search_area.Text);
        }

         public  String RetrieveFormatedAddress(string lat, string lng)
        {
            string requestUri = string.Format(baseUri, lat, lng);

            using (WebClient wc = new WebClient())
            {
                string result = wc.DownloadString(requestUri);
                var xmlElm = XElement.Parse(result);
                var status = (from elm in xmlElm.Descendants()
                              where
                                    elm.Name == "status"
                              select elm).FirstOrDefault();
                if (status.Value.ToLower() == "ok")
                {
                    var res = (from elm in xmlElm.Descendants()
                               where
                                    elm.Name == "formatted_address"
                               select elm).FirstOrDefault();
                    requestUri = res.Value;

                    return requestUri;
                }                
            }
            return "";
        }
        private void loadList(string search) {
            string param = "";
            if (!search.Equals("")) {
                param = "where buses.bus_name like '%"+ search + "%'";
            }
            DataTable dt = new DataTable();
            mgrid.DataSource = null;
            if (Program.da.Select(@"select 
                                    buses.bus_name,
                                    activebus.longitude,
                                    activebus.latitude,
                                    activebus.passesngercount,
                                    concat(driver.first_name,
                                    driver.last_name) drivername,
                                    concat(conductor.first_name,
                                    conductor.last_name) conductorname
                                    from activebus
                                    left join buses on buses.id = activebus.bus_id
                                    left
                                    join employee driver on driver.id = activebus.driver_id
                                    left
                                    join employee conductor  on conductor.id = activebus.con_id "+param))
            {


               
                dt = Program.da.getTable();
                mgrid.AutoGenerateColumns = false;
                mgrid.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    DataRow dr = dt.Rows[i];
                    if ((i % 2) == 0)
                    {
                        mgrid.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    mgrid.Rows[i].Cells["address"].Value = RetrieveFormatedAddress(dr["latitude"].ToString(), dr["longitude"].ToString());
                    mgrid.Rows[i].Cells["no"].Value = i + 1 + "";
                    
                }

            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            loadList(txt_search_area.Text);
        }

        private void txt_search_area_KeyUp(object sender, KeyEventArgs e)
        {

           
            
        }

        private void txt_search_area_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                loadList(txt_search_area.Text);
            }
        }

        private void btn_viewReport_Click(object sender, EventArgs e)
        {
            listofOnlinebusreport onlinereport = new listofOnlinebusreport();
            onlinereport.Show();

        }
    }
}
