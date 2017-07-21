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

namespace TRASY.Referentials
{
    public partial class AlertMessage : MetroForm
    {

        string BID = "0";
        public AlertMessage()
        {
            InitializeComponent();
        }

        private void AlertMessage_Load(object sender, EventArgs e)
        {
            load_list(txt_search_area.Text);
            
            
               
        }

        private void load_list(string search)
        {
            mgrid.DataSource = null;
            string param = "";
            if (!search.Equals(""))
            {
                param = "and title like '%" + txt_search_area.Text + "%'";
            }
            DataTable dt = new DataTable();
            if (Program.da.Select("select CONCAT(title,' - ',year(date)) title,id from message where type = 'alert' "+param))
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

        private void txt_search_area_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter==e.KeyCode) {
                load_list(txt_search_area.Text);
            }
        }

        private void mgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            list_clicks(e);
        }

        private void mgrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            list_clicks(e);
        }
        private void list_clicks(DataGridViewCellEventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();
                BID = mgrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                if (Program.da.Select("select message,title,date from message where type = 'alert' and id =" + BID))
                {
                    dt = Program.da.getTable();
                    DataRow dr = dt.Rows[0];
                    txt_content.SelectionIndent = 20;
                    txt_content.Font = new Font("Lucinda Console", 12);
                    txt_content.Text ="\t\t"+ dr["message"].ToString();
                    lbl_date.Text = DateTime.Parse(dr["date"].ToString()).ToLongDateString()+" "+ DateTime.Parse(dr["date"].ToString()).ToLongTimeString();
                    lbl_title.Text = dr["title"].ToString();               
                }
            }
            catch (Exception xxx) { }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            load_list(txt_search_area.Text);
        }
    }
}
