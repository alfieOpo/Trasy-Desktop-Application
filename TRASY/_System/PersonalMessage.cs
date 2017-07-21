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
   
    public partial class PersonalMessage : MetroForm
    {
        string PID = "0";
        public PersonalMessage()
        {
            InitializeComponent();
        }
        private void load_list(string search)
        {
            mgrid.DataSource = null;
            string param = "";
            if (!search.Equals(""))
            {
                param = "and x.bus_name  like '%" + txt_search_area.Text + "%'";
            }
            DataTable dt = new DataTable();
            if (Program.da.Select(@"select DISTINCT x.* from (SELECT buses.bus_name,buses.bus_plate_no FROM `message` 
left join buses on buses.bus_plate_no = message.plate_no
where type = 'personal' order by date desc )x where x.bus_name is not null  " + param))
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
                MetroFramework.Controls.MetroPanel panel  = new MetroFramework.Controls.MetroPanel();
                DataTable dt = new DataTable();
                PID = mgrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                messagelist.Controls.Clear();
                if (Program.da.Select("select message,title,date,isread from message where type = 'personal' and plate_no ='" + PID+"'" ))
                {
                    dt = Program.da.getTable();
                   
                    foreach (DataRow dr in dt.Rows)
                    {

                        Label title = new Label();
                        title.Dock = DockStyle.Top;
                        string isSeen = "";
                        if (dr["isread"].ToString().Equals("1"))
                        {
                            isSeen= " - Seen";
                        }
                        else {
                            isSeen= " - Havnt Seen";
                        }
                        title.Text = dr["title"].ToString()+isSeen;
                        title.ForeColor = Color.Gray;
                        title.BackColor = Color.Transparent;
                        title.Font=new   Font("Lucinda Console", 8,FontStyle.Italic);
                         
                        
                        
                        Label content = new Label();
                        
                        content.Font = new Font("Lucinda Console", 12);
                        content.Text = "\n\t\t" + dr["message"].ToString();                         
                        content.Dock = DockStyle.Bottom;
                        content.MaximumSize = new Size(messagelist.Width-20, 0);
                        content.AutoSize = true;
                        content.BackColor = Color.AliceBlue;
                     
                        content.Controls.Add(title);
                      
                        Label divider = new Label();
                        divider.Dock = DockStyle.Bottom;
                        divider.Height = 10;
                        divider.BackColor = Color.White;
                     
                       
                       
                       
                        panel.Controls.Add(divider);
                        panel.Controls.Add(content);
                        panel.Height += (content.Height+10);
                        panel.Width = messagelist.Width;
                         


                    }

                    messagelist.Controls.Add(panel);
                    messagelist.VerticalScroll.Value = messagelist.VerticalScroll.Maximum;
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
            if (Keys.Enter == e.KeyCode) {
                load_list(txt_search_area.Text);
            }
        }

        private void PersonalMessage_Load(object sender, EventArgs e)
        {
            load_list(txt_search_area.Text);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            load_list(txt_search_area.Text);
        }

        private void messagelist_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
