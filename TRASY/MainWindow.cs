using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using TRASY._System;
using TRASY.Referentials;
using Tulpep.NotificationWindow;

namespace TRASY
{
    public partial class MainWindow : MetroForm
    {
        string bus_name = "";
        int old_emergency_count = 0;
        GMapOverlay _overlay;
        Label time;
        Panel BUSDETAILS;
        Label label;
        emergency emer = null;
        location loc = null;
        Employee emp = null;
        Users user = null;
        PoliceHotline police = null;
        buses bus = null;
        ListofOnlineBus olbus = null;
        ListofOfflineBus offbus = null;
        CreateMessage cm = null;
        AlertMessage alert = null;
        PersonalMessage pm = null;
        EmergencyMessage em=null;
        PopupNotifier popup = null;
        int old_count_bus = 0;
        static string baseUri = "http://maps.googleapis.com/maps/api/geocode/xml?latlng={0},{1}&sensor=false";
        string location = string.Empty;

        public MainWindow()
        {
            login login =new login();
            login.ShowDialog();

            if (!login.Valid) {
                Application.Exit();
                this.Dispose();
            }
           else { InitializeComponent(); }
            
        }

        private void cbo_map_setting_TextChanged(object sender, EventArgs e)
        {
            if (cbo_map_setting.Text.Equals("Map"))
            {
                mainmap.MapProvider = GoogleMapProvider.Instance;
                time.ForeColor = Color.Salmon;
               
            }
            else
            {
                mainmap.MapProvider = GMapProviders.GoogleSatelliteMap;
                time.ForeColor = Color.White;
                            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            popup = new PopupNotifier();
            mainmap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            GMapProvider.WebProxy = null;
            mainmap.Position = new PointLatLng(14.6804067, 121.0888618);
            time = new Label();
            time.Dock = DockStyle.Top;
            time.Font = new Font("Times New Roman", 18);
            time.ForeColor = Color.Salmon;
            time.Text = "im the time";
            time.TextAlign = ContentAlignment.TopRight;
            time.BackColor = Color.Transparent;
            BUSDETAILS = new Panel();
            BUSDETAILS.Dock = DockStyle.Right;
            BUSDETAILS.Width = 250;
            BUSDETAILS.BackColor = Color.Transparent;
            mainmap.Controls.Add(BUSDETAILS);
            mainmap.Controls.Add(time);
            _overlay = new GMapOverlay();
            TimeChecker.Enabled = true;
            UpdateTheCurrentlocationOftheBus.Enabled = true;
            BusChecker.Enabled = true;
            DetailsChecker.Enabled = true;
            EmergencyMessageChecker.Enabled = true;
            cbo_map_setting.SelectedIndex = 0;
        }
        private void TimeChecker_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.Date.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        private void emergencyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (emer == null)
            {
                emer = new emergency();
            }
            if (emer.IsDisposed)
            {
                emer = new emergency();
            }
           
            emer.Show();

        }
        private bool NEWBUS
        {
            get
            {
                if (Program.da.Select("select count(id) cnt from activebus   "))
                {
                    DataTable dt = new DataTable();
                    dt = Program.da.getTable();

                    int newcount = int.Parse(dt.Rows[0][0].ToString());
                    if (old_count_bus < newcount)
                    {
                        int total = newcount - old_count_bus;
                        string descrotion = "1 bus is online";
                        if (total > 1)
                        {
                            descrotion = total + " buses are online";
                        }

                        Notifyme("Online Bus", descrotion, Properties.Resources.bus64, "B");

                        old_count_bus = int.Parse(dt.Rows[0][0].ToString());
                        return true;
                    }
                    else {
                        if (newcount == old_count_bus)
                        {
                            return false;
                        }
                        else {
                            int totalleav = old_count_bus - newcount;
                            Notifyme("Offline Bus", totalleav +" bus get offline", Properties.Resources.bus64, "B");
                            old_count_bus = int.Parse(dt.Rows[0][0].ToString());
                            return true;
                        }
                    }
                }

                return false;
            }
        }
        private void UpdateTheCurrentlocationOftheBus_Tick(object sender, EventArgs e)
        {
            if (Program.da.Select(@" 
select buses.bus_name,activebus.latitude,activebus.longitude,activebus.speed from activebus LEFT JOIN buses on buses.id=activebus.bus_id where buses.isuse=1"))
            {
                DataTable dt = new DataTable();
                dt = Program.da.getTable();
                try
                {
                    for (int i = 0; i < mainmap.Overlays[0].Markers.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        if (mainmap.Overlays[0].Markers[i].Tag.Equals(dr["bus_name"].ToString()))
                        {
                            try { mainmap.Overlays[0].Markers[i].Position = new PointLatLng(double.Parse(dr["latitude"].ToString()), double.Parse(dr["longitude"].ToString())); } catch (Exception xx) { }
                            try { mainmap.Overlays[0].Markers[i].ToolTipText = dr["bus_name"].ToString() + " SPEED :" + dr["speed"].ToString() + " km/h"; } catch (Exception xx) { }
                            if (bus_name.Equals(""))
                            {
                                try { mainmap.Overlays[0].Markers[i].ToolTip.Fill = Brushes.Orange; } catch (Exception xx) { }
                            }
                            else {
                                if (mainmap.Overlays[0].Markers[i].Tag.Equals(bus_name))
                                {
                                    mainmap.Overlays[0].Markers[i].ToolTip.Fill = Brushes.Red;
                                }
                            }
                        }

                    }
                }
                catch (Exception xx) { }
                mainmap.Refresh();
                mainmap.Update();
            }
        }

        private void BusChecker_Tick(object sender, EventArgs e)
        {
            if (NEWBUS)
            {
                 mainmap.Overlays.Clear();
                _overlay.Markers.Clear();
                if (Program.da.Select(@" 
select * from vw_details where id in(select x.id from(
select max(id) as id, bus_name from vw_details GROUP BY bus_name
)x)"))
                {
                    DataTable dt = new DataTable();
                    dt = Program.da.getTable();
                    try
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DataRow dr = dt.Rows[i];
                            _overlay.Markers.Add(marker(dr["bus_name"].ToString(), dr["bus_name"].ToString(), "overlay1", double.Parse(dr["longitude"].ToString()), double.Parse(dr["latitude"].ToString())));
                            Play();
                        }
                        mainmap.Overlays.Add(_overlay);
                        mainmap.Refresh();
                        mainmap.Update();
                    }
                    catch (Exception xx)
                    {
                    }

                }
            }
        }
        private GMarkerGoogle marker(string markertag, string bus_name, string overlayID, double longitude, double latitude)
        {
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.orange);
            marker.Tag = markertag;
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTip = new GMapBaloonToolTip(marker);
            marker.ToolTip.Fill = Brushes.Orange;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.Font = new Font("", 10, FontStyle.Bold, GraphicsUnit.World);
            marker.ToolTipText = bus_name+ " 0 km/h";//name of the bus         
            return marker;
        }
        private void Play()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Store_Door_Chime_Mike_Koenig_570742973);
            player.Play();
        }
        private void PlayEmergency()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Fire_pager);
            player.Play();
        }
        private void DetailsChecker_Tick(object sender, EventArgs e)
        {

            if (Program.da.Select(@" select buses.bus_plate_no,buses.bus_name,activebus.latitude,activebus.longitude,activebus.speed,passesngercount,CONCAT(employee.first_name ,' ',employee.last_name) fullname from activebus 
                                    LEFT JOIN buses on buses.id=activebus.bus_id 
                                    left join employee on employee.id=activebus.driver_id
                                    where buses.isuse=1"))
            {
                DataTable dt = new DataTable();
                dt = Program.da.getTable();
                try
                {
                    try { BUSDETAILS.Controls.Clear(); } catch (Exception xx) { }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                          label = new Label();
                        label.Text = "PLATE NUMBER  : " + dt.Rows[i]["bus_plate_no"].ToString() + "\nBUS NAME :" + dt.Rows[i]["bus_name"].ToString() + "\nDRIVER NAME:" + dt.Rows[i]["fullname"].ToString() + "\nLOCATION :" + RetrieveFormatedAddress(dt.Rows[i]["latitude"].ToString(), dt.Rows[i]["longitude"].ToString()) + "\nCOUNT OF PASSENGER/S :" + dt.Rows[i]["passesngercount"].ToString();
                        label.Height = 100;
                        label.Dock = DockStyle.Top;
                        label.FlatStyle = FlatStyle.Popup;
                        label.BackColor = Color.FromArgb(120,Color.Black);
                        label.ForeColor = Color.White;
                        BUSDETAILS.Controls.Add(label);
                    }
                }
                catch (Exception xx) { MessageBox.Show(xx.Message); }

            }
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

        private void cbo_map_setting_DropDownClosed(object sender, EventArgs e)
        {
            if (cbo_map_setting.Text.Equals("Map"))
            {
                mainmap.MapProvider = GoogleMapProvider.Instance;
                time.ForeColor = Color.Salmon;

            }
            else
            {
                mainmap.MapProvider = GMapProviders.GoogleSatelliteMap;
                time.ForeColor = Color.White;

            }
        }

        private void emergencyMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbo_map_setting_Click(object sender, EventArgs e)
        {

        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loc == null)
            {
                loc = new TRASY.location();
            }
            if (loc.IsDisposed)
            {
                loc = new TRASY.location();
            }

            loc.Show();
        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bus == null)
            {
                bus = new buses();
            }
            if (bus.IsDisposed)
            {
                bus = new buses();
            }

            bus.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (emp == null)
            {
                emp = new Employee();
            }
            if (emp.IsDisposed)
            {
                emp = new Employee();
            }

            emp.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new Users();
            }
            if (user.IsDisposed)
            {
                user = new Users();
            }

            user.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void policeHotlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (police == null)
            {
                police = new PoliceHotline();
            }
            if (police.IsDisposed)
            {
                police = new PoliceHotline();
            }

            police.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void listOfOnlineBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (olbus == null)
            {
                olbus = new ListofOnlineBus();
            }
            if (olbus.IsDisposed)
            {
                olbus = new ListofOnlineBus();
            }

            olbus.Show();
        }

        private void listOfCodingBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (offbus == null)
            {
                offbus = new ListofOfflineBus();
            }
            if (offbus.IsDisposed)
            {
                offbus = new ListofOfflineBus();
            }

            offbus.Show();
        }

        private void createMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cm == null)
            {
                cm = new CreateMessage();
            }
            if (cm.IsDisposed)
            {
                cm = new CreateMessage();
            }

            cm.Show();
        }

        private void alertMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alert == null)
            {
                alert = new AlertMessage();
            }
            if (alert.IsDisposed)
            {
                alert = new AlertMessage();
            }

            alert.Show();
        }

        private void personalMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pm == null)
            {
                pm = new PersonalMessage();
            }
            if (pm.IsDisposed)
            {
                pm = new PersonalMessage();
            }

            pm.Show();
        }

        private void emergencyMessageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (em == null)
            {
                em = new EmergencyMessage();
            }
            if (em.IsDisposed)
            {
                em = new EmergencyMessage();
            }
            bus_name = "";
            em.Show();
        }
 

        private void NotifClick(object sender, EventArgs e)
        {
            if (popup.TitleText.Equals("EMERGENCY")) {
                if (em == null)
                {
                    em = new EmergencyMessage(bus_name);
                }
                if (em.IsDisposed)
                {
                    em = new EmergencyMessage(bus_name);
                }
                bus_name = "";
                em.Show();
            }
        }

        private void Notifyme(string title,string content ,Bitmap image,string tag) {
            popup.Image = image;
            popup.TitleText =title;
            popup.ContentText = content;
            popup.Click += new EventHandler(NotifClick);
            switch (tag) {
                case "B":
                    popup.TitleFont = new Font("Tahoma", 12);
                    popup.ContentColor = Color.SeaGreen;
                    popup.ContentFont = new Font("Tahoma",8);
                    break;
                case "E":
                    popup.TitleFont = new Font("Tahoma", 12);
                    popup.ContentColor = Color.LightSalmon;
                    popup.ContentFont = new Font("Tahoma", 8);
                    break;
            }
            popup.Popup();
        }

        private void EmergencyMessageChecker_Tick(object sender, EventArgs e)
        {
            if (Program.da.Select(@"
select count(message.id) cnt, buses.bus_name from message
left join buses on buses.id = message.bus_id
where message.type = 'emergency'   GROUP BY buses.bus_name order by message.id desc ")) {
                DataTable dt = new DataTable();
                dt = Program.da.getTable();

                try
                {
                    int newCount = int.Parse(dt.Rows[0][0].ToString());
                    if (old_emergency_count == 0 && newCount == 0)
                    {
                        return;
                    }
                    else if (old_emergency_count == 0 && newCount != 0)
                    {
                        old_emergency_count = newCount;
                        return;
                    }
                    else
                    {
                        if (old_emergency_count != newCount)
                        {
                            int total = newCount - old_emergency_count;
                            old_emergency_count = int.Parse(dt.Rows[0][0].ToString());
                            Notifyme("EMERGENCY", "You Have " + total + " Emergency Message", Properties.Resources.ambulance64, "E");
                            bus_name = dt.Rows[0]["bus_name"].ToString();

                            for (int i = 0; i < mainmap.Overlays[0].Markers.Count; i++)
                            {
                                

                                if (mainmap.Overlays[0].Markers[i].Tag.Equals(bus_name))
                                {
                                    
                                    try { mainmap.Overlays[0].Markers[i].ToolTip.Fill = Brushes.Red;
                                        mainmap.Overlays[0].Markers[i].ToolTipText = bus_name+" Is On Emergency " ;
                                    } catch (Exception xx) { }
                                }

                            }
                            PlayEmergency();
                        }
                    }
                }
                catch (Exception xx)
                {

                }
                
            }
        }
    }
}
/*
 *  
 */
