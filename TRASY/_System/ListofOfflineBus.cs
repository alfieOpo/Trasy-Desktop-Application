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
    public partial class ListofOfflineBus : MetroForm
    {
        public ListofOfflineBus()
        {
            InitializeComponent();
        }

        private void ListofOfflineBus_Load(object sender, EventArgs e)
        {
            loadList(txt_search_area.Text);
        }
        private void loadList(string search)
        {
            string param = "";
            if (!search.Equals(""))
            {
                param = "where buses.bus_name like '%" + search + "%'";
            }
            DataTable dt = new DataTable();
            mgrid.DataSource = null;
            if (Program.da.Select(@"select * from buses where id not in( select bus_id from activebus)" + param))
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
                    mgrid.Rows[i].Cells["no"].Value = i + 1 + "";
                }
                lbl_rows.Text = dt.Rows.Count + " Bus";
            }
        }

        private void txt_search_area_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter==e.KeyCode) {
                loadList(txt_search_area.Text);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            loadList(txt_search_area.Text);
        }
    }
}
