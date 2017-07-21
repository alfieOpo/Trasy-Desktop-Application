using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Data;
using System.Runtime.InteropServices;
namespace TRASY
{
    public partial class PoliceHotline :   MetroForm
    {
        string action = "";
        string id_ = "";
        bool _visible = false;
        public bool visible 
        {
            set { _visible = value; }
            get { return _visible; }
        }
        public PoliceHotline()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cleartxt();
            enableButton = true;
            action = "add";
            laod_cbo();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            enableButton = true;
            action = "edit";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (action) 
            {
                case"add":
                    string sql = @"INSERT INTO police_stations (name, location_id, number) 
                                   VALUES ( '"+txt_statation_name.Text+"', '"+cbo_location.SelectedValue+"', '"+txt_hot_line_number.Text+"');";
                    if (Program.da.insert(sql)) 
                    {
                        msgbox.Show(this,"Successfully saved","Message");
                        enableButton = false;
                        action = "";
                        load_list(false);
                    }
                    break;
                case"edit":
                    if(msgbox.Confirm(this,"Do you want to save changes?","Update Confirmation"))
                    {
                        string sql_ = @"UPDATE police_stations SET  name='" + txt_statation_name.Text + @"'
                            ,location_id=" +cbo_location.SelectedValue+",number="+txt_hot_line_number.Text+" WHERE where id ="+txt_code.Text+"";
                        if (Program.da.update(sql_)) 
                        {
                            msgbox.Show(this, "Successfully edited", "Message");
                            enableButton = false;
                            action = "";
                            load_list(false);
                        }
                    }
                    break;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cleartxt();
            enableButton = true;
            action = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            _visible = false;
            this.Close();
        }
        private void cleartxt() 
        {
            txt_code.Text="";
            txt_hot_line_number.Clear();
            txt_search_area.Clear();
            txt_statation_name.Clear();
            cbo_location.DataSource = null;
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
                txt_code.Enabled = value;
                txt_hot_line_number.Enabled = value;
                txt_statation_name.Enabled = value;
                cbo_location.Enabled = value;             
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (msgbox.Confirm(this, "Are you sure you want to delete " + txt_statation_name.Text.ToUpper(), "Delete Confirmation")) 
            {
                if (Program.da.delete("DELETE FROM police_stations WHERE id=" + txt_code.Text + "")) 
                {
                    msgbox.Show(this,"Successfully deleted","Message");
                    cleartxt();
                    enableButton = false;
                    load_list(false);
                }
            }
        }

        private void PoliceHotline_Load(object sender, EventArgs e)
        {
            
            enableButton = false;
            if (this.Visible)
            {
                _visible = true;
            }
            else 
            {
                _visible = false;
            }
            cleartxt();
            load_list(false);
            laod_cbo();
            
        }
        private void load_list(bool search)
        {
            string param = "";
            mgrid.DataSource = null; 
            if (search)
            {
               param = "where name like '%" + txt_search_area.Text+ "%'";
            }
            DataTable dt = new System.Data.DataTable();
            string sql = "SELECT id,name FROM police_stations " + param + "";
            if (Program.da.Select(sql))
            {
                dt = Program.da.getTable();
                mgrid.AllowUserToAddRows = false;
                mgrid.AutoGenerateColumns = false;
                mgrid.DataSource = dt;
                for (int i = 0; i < mgrid.Rows.Count;i++ )
                {
                    mgrid.Rows[i].Cells["_no"].Value = i + 1+".)"; 
                }
            }
        }

        private void mgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            list_click(e);
        }
        private void list_click(DataGridViewCellEventArgs e)
        {
           
            try
            {
                if (e != null) { id_ = mgrid.Rows[e.RowIndex].Cells["_id"].Value.ToString(); }
                DataTable dt = new System.Data.DataTable();
                if (Program.da.Select("SELECT * FROM police_stations where id=" + id_ + "")) ;
                {
                    dt = Program.da.getTable();
                    DataRow dr = dt.Rows[0];
                    txt_code.Text = int.Parse(dr["id"].ToString()).ToString("D4");
                    txt_hot_line_number.Text = dr["number"].ToString();
                    txt_statation_name.Text = dr["name"].ToString();
                    cbo_location.SelectedValue = dr["location_id"].ToString();
                }
            }
            catch (Exception xx) { }
        }

        private void mgrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            list_click(e);
        }
        private void laod_cbo ()
        {
            DataTable dt = new System.Data.DataTable();
            if (Program.da.Select("SELECT id, name, longitude, latitude FROM location "))
            {
                dt = Program.da.getTable();
                cbo_location.DataSource = dt;
                cbo_location.DisplayMember = "name";
                cbo_location.ValueMember = "id";                
            }
        }

        private void txt_hot_line_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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

        private void mgrid_CellErrorTextChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PoliceHotline_Paint(object sender, PaintEventArgs e)
        {
        
        }
        #region FLATSCREEN
        private void PoliceHotline_MouseDown(object sender, MouseEventArgs e)
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
        #endregion FLATSCREEN

        private void mgrid_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {

        }
    }
}
