using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRASY._System
{
    public partial class EmergencyMessage : MetroForm
    {
        string _bus_name = "";
        string EID = "0";
        public EmergencyMessage()
        {
            InitializeComponent();
        }

        public EmergencyMessage(string bus_name)
        {
            _bus_name = bus_name;
            InitializeComponent();
        }


        private void EmergencyMessage_Load(object sender, EventArgs e)
        {
            txt_search_area.Text = _bus_name;
            load_list(txt_search_area.Text);
        }

        private void load_list(string search)
        {
            mgrid.DataSource = null;
            string param = "";
            if (!search.Equals(""))
            {
                param = "and buses.bus_name  like '%" + txt_search_area.Text + "%'";
            }
            DataTable dt = new DataTable();
            if (Program.da.Select(@"
select DISTINCT buses.bus_name,buses.bus_plate_no from message  
left join buses on buses.id=message.bus_id
where type='emergency' "+param + " order by message.id desc   " ))
            {
                dt = Program.da.getTable();
                mgrid.AutoGenerateColumns = false;
                mgrid.AllowUserToAddRows = false;
                mgrid.DataSource = dt;
                for (int i = 0; i < mgrid.Rows.Count; i++)
                {
                    if ((i % 2) == 0)
                    {
                        mgrid.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    mgrid.Rows[i].Cells["no"].Value = i + 1 + ".)";
                }
            }
        }

        private void list_clicks(DataGridViewCellEventArgs e)
        {
            try
            {
                MetroFramework.Controls.MetroPanel panel = new MetroFramework.Controls.MetroPanel();
                DataTable dt = new DataTable();
                EID = mgrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                messagelist.Controls.Clear();
                if (Program.da.Select("select message,title,date,isread from message where type = 'emergency' and plate_no ='" + EID + "' order by id desc"))
                {
                    dt = Program.da.getTable();

                    foreach (DataRow dr in dt.Rows)
                    {

                        Label title = new Label();
                        title.Dock = DockStyle.Top;
                        
                        title.Text = dr["title"].ToString();
                        title.ForeColor = Color.Gray;
                        title.BackColor = Color.Transparent;
                    
                        title.Font = new Font("Lucinda Console", 14, FontStyle.Italic| FontStyle.Bold);



                        Label content = new Label();

                        content.Font = new Font("Lucinda Console", 12);
                        content.Text = "\n\t\t" + dr["message"].ToString();
                        content.Dock = DockStyle.Bottom;
                        content.MaximumSize = new Size(messagelist.Width - 20, 0);
                        content.AutoSize = true;
                        content.BackColor = Color.LightSalmon;

                        content.Controls.Add(title);
                        




                        Label divider = new Label();
                        divider.Dock = DockStyle.Bottom;
                        divider.Height = 20;
                        divider.TextAlign = ContentAlignment.BottomCenter;
                        divider.BackColor = Color.White;
                        divider.Text = DateTime.Parse(dr["date"].ToString()).ToLongDateString() + "  " + DateTime.Parse(dr["date"].ToString()).ToLongTimeString();
                        divider.Font = new Font("Adobe Fan Heiti Std", 8, FontStyle.Italic);
                        divider.ForeColor = Color.Gray;


                        panel.Controls.Add(divider);
                        panel.Controls.Add(content);
                        panel.Height += (content.Height+20);
                        panel.Width = messagelist.Width - 15;



                    }
                    messagelist.VerticalScroll.Value = messagelist.VerticalScroll.Maximum;
                    messagelist.Controls.Add(panel);
                  
                    lbl_title.Text = mgrid.Rows[e.RowIndex].Cells["name"].Value.ToString();






                }
            }
            catch (Exception xxx) { }
        }

        private void mgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            list_clicks(e);
        }

        private void mgrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            list_clicks(e);
        }

        private void txt_search_area_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                load_list(txt_search_area.Text);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            load_list(txt_search_area.Text);
        }
    }
}
