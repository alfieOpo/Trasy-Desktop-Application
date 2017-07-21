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

namespace TRASY
{
    public partial class buses : MetroForm
    {

        string action = "";
        string BID = "0";
        public buses()
        {
            InitializeComponent();
        }

        private void cleartxt()
        {
            txt_bus_name.Clear();
            txt_platenumber.Clear();
            chk_is_use.Checked = false;
            txt_search_area.Clear();
        }
        private bool enableButton
        {
            set
            {
                btn_add.Enabled = !value;
                btn_edit.Enabled = !value;
                btn_delete.Enabled = !value;
                btn_save.Enabled = value;
                btn_cancel.Enabled = value;

            
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            action = "add";
            cleartxt();
            enableButton = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            action = "edit";
            enableButton = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (msgbox.Confirm(this, "Are you sure you want to delete " + txt_bus_name.Text.ToUpper(), "Delete Confirmation"))

                if (Program.da.delete("DELETE FROM buses WHERE id=" + BID + ""))
                {
                    enableButton = false;
                    cleartxt();
                    load_list(txt_search_area.Text);
                    action = "";
                    msgbox.Show(this, "Successfully deleted", "Message");
                }
        }

        private void buses_Load(object sender, EventArgs e)
        {
            load_list(txt_search_area.Text);
            enableButton = false;
        }
        private void load_list(string search)
        {
            mgrid.DataSource = null;
            string param = "";
            if (!search.Equals(""))
            {
                param = "where bus_name like '%" + txt_search_area.Text + "%'";
            }
            DataTable dt = new DataTable();
            if (Program.da.Select("SELECT id, bus_name,bus_plate_no FROM buses " + param + " order by id desc "))
            {
                dt = Program.da.getTable();
                mgrid.AutoGenerateColumns = false;
                mgrid.AllowUserToAddRows = false;
                mgrid.DataSource = dt;
                for (int i = 0; i < mgrid.Rows.Count; i++)
                {
                    mgrid.Rows[i].Cells["no"].Value = i + 1 + ".)";
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "add":
                    int ischeck2 = chk_is_use.Checked ? 1 : 0;
                    if (Program.da.insert(@"insert into buses set bus_name='" + txt_bus_name.Text + "',bus_plate_no='" + txt_platenumber.Text + "',isuse="+ischeck2))
                    {
                        enableButton = false;
                        load_list(txt_search_area.Text);
                        action = "";
                        msgbox.Show(this, "Successfully saved", "Message");
                    }
                    break;
                case "edit":
                    if (msgbox.Confirm(this, "Do you want to save Changes", "Update Confirmation"))
                    {
                        int ischeck = chk_is_use.Checked ? 1 : 0;
                        if (Program.da.update(@"update buses set bus_name='" + txt_bus_name.Text + "',bus_plate_no='" + txt_platenumber.Text + "',isuse="+ ischeck + " where id ="+BID))
                        {
                            enableButton = false;
                            load_list(txt_search_area.Text);
                            action = "";
                            msgbox.Show(this, "Successfully edited", "Message");
                        }
                    }
                    break;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cleartxt();
            enableButton = false;
            action = "";
        }

        private void txt_search_area_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.Enter==e.KeyCode) {

            }
        }

        private void list_clicks(DataGridViewCellEventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();
                BID = mgrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                if (Program.da.Select("SELECT bus_name,bus_plate_no,isuse FROM buses where id=" + BID + ""))
                {
                    dt = Program.da.getTable();
                    DataRow dr = dt.Rows[0];
                    txt_bus_name.Text= dr["bus_name"].ToString();
                    txt_platenumber.Text = dr["bus_plate_no"].ToString();
                    chk_is_use.Checked= dr["bus_name"].ToString().Equals("1");

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
    }


}
