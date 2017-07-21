using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Runtime.InteropServices;
namespace TRASY
{
    public partial class location : MetroForm
    {
        string action = "";
        string id_ = "";
        public location()
        {
            InitializeComponent();
        }
        private void location_Load(object sender, EventArgs e)
        {
            load_list(false);
            
        }
        private void cleartxt() 
        {
            txt_code.Text="";
            txt_laltitude.Clear();
            txt_location.Clear();
            txt_logitude.Clear();
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
               
                txt_code.Enabled = false;
                txt_laltitude.Enabled = value;
                txt_location.Enabled = value;
                txt_logitude.Enabled = value;
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
            if(msgbox.Confirm(this,"Are you sure you want to delete "+txt_location.Text.ToUpper(),"Delete Confirmation"))
            {
                if (Program.da.delete("DELETE FROM location WHERE id="+txt_code.Text+"")) 
                {
                    enableButton = false;
                    cleartxt();
                    load_list(false);
                    action = "";
                    msgbox.Show(this, "Successfully deleted", "Message");
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (action) 
            {
                case"add":
                    if (Program.da.insert(@"INSERT INTO location( name, longitude, latitude) 
                    VALUES ('" + txt_location.Text + "','" + txt_logitude.Text + "','" + txt_laltitude.Text + "')"))
                    {
                        enableButton = false;                    
                        load_list(false);
                        action = "";
                        msgbox.Show(this,"Successfully saved","Message");
                    }
                    break;
                case"edit":
                    if (msgbox.Confirm(this, "Are you sure you want to delete " + txt_location.Text.ToUpper(), "Delete Confirmation"))
                    {
                        if (Program.da.update("UPDATE location SET  name='"+txt_location.Text+"',longitude='"+txt_logitude.Text+"',latitude='"+txt_laltitude.Text+"' WHERE id ="+txt_code.Text+""))
                        {
                            enableButton = false;                   
                            load_list(false);
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void load_list(bool search) 
        {
            mgrid.DataSource = null;
            string param = "";
            if (search) 
            {
                param = "where name like '%" + txt_search_area.Text + "%'";
            }
            DataTable dt = new DataTable();
            if (Program.da.Select("SELECT id, name, longitude, latitude FROM location "+param+" ")) 
            {
                dt = Program.da.getTable();
                mgrid.AutoGenerateColumns = false;
                mgrid.AllowUserToAddRows = false;
                mgrid.DataSource = dt;
                for (int i = 0; i < mgrid.Rows.Count;i++ )
                {
                    mgrid.Rows[i].Cells["no"].Value = i+1+".)";
                }
            }
        }

        private void txt_search_area_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_search_area.Text.Equals(""))
            {
                load_list(false);
            }
            else 
            {
                load_list(true);
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
            try {
                id_ = "";
                DataTable dt = new DataTable();
                if (id_.Equals("")) { id_ = mgrid.Rows[e.RowIndex].Cells["id"].Value.ToString(); }
                if (Program.da.Select("SELECT id, name, longitude, latitude FROM location where id="+id_+""))
                {
                    dt = Program.da.getTable();
                    DataRow dr = dt.Rows[0];
                    txt_code.Text = int.Parse(dr["id"].ToString()).ToString("D4");
                    txt_laltitude.Text = dr["latitude"].ToString();
                    txt_location.Text = dr["name"].ToString();
                    txt_logitude.Text = dr["longitude"].ToString();
                }
            }
            catch (Exception xxx) { }
        }

        private void txt_search_area_MouseEnter(object sender, EventArgs e)
        {
          
            
        }

        private void txt_search_area_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txt_search_area_Enter(object sender, EventArgs e)
        {
            if (txt_search_area.Text.Equals("Search"))
            {
                txt_search_area.Text = "";
            }
        }

        private void txt_search_area_Leave(object sender, EventArgs e)
        {
            if (txt_search_area.Text.Equals(""))
            {
                txt_search_area.Text = "Search";
            }
        }

        private void location_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 10;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
            {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
            {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
        };

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        private void txt_logitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            string longitude = "";
            longitude = txt_logitude.Text;
            try
            {
                decimal testlong = decimal.Parse(longitude);
            }
            catch (Exception xxx) 
            {
                txt_logitude.Text = txt_logitude.Text.Substring(txt_logitude.Text.Length - 1, 1);
            }
        }
    }
}
