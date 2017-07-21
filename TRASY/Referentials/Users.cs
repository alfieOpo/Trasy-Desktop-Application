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
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.IO;
namespace TRASY
{
    public partial class Users : MetroForm
    {
        string action = "";
        string id_ = "";
        List<string> emptyvalue = new List<string>();
        OpenFileDialog ofd = new OpenFileDialog();
        private Image Value;
        string extension = "";
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            
            enableButton = false;
            txt_confirma_password.Visible = false;
            txt_password.Visible = false;
            lbl_confirm_password.Visible = false;
            lbl_password.Visible = false;
            Load_grid();
        }
        private void Load_grid() 
        {
            string sql="select  UPPER(CONCAT_WS(\" \",first_name,middle_name,last_name))as name,id from users order by id desc";
            DataTable dt = new System.Data.DataTable();
            if (Program.da.Select(sql))
            {
                dt = Program.da.getTable();
                mgrid.AllowUserToAddRows = false;
                mgrid.AutoGenerateColumns = false;
                mgrid.DataSource = dt;
                for (int i = 0; i < mgrid.Rows.Count; i++) 
                {
                    mgrid.Rows[i].Cells["no"].Value = i + 1 + ".)";
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_password.Hint = "";
            action = "add";
            lbl_confirm_password.Visible = true;
            lbl_password.Visible = true;
            txt_confirma_password.Visible = true;
            txt_password.Visible = true;
            enableButton = true;
            cleartxt();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_password.Hint = "";
            action = "edit";
            enableButton = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                msgbox.Warning2(this, "Please Complete the following: \n->" + String.Join("\n->", emptyvalue), "Warning");
                return;
            }
            
            StringBuilder sb = new StringBuilder();

            switch (action) 
            {
                case "add":
                    sb.Append("insert into users (");
                    sb.Append("first_name");
                    sb.Append(",middle_name");
                    sb.Append(",last_name");   
                    sb.Append(",username");
                    sb.Append(",password");
                    sb.Append(",user_level");
                    sb.Append(",image");
                    sb.Append(",extension");
                    sb.Append(",full_name");
                    sb.Append(",date_registered)");
                    sb.Append("values (");
                    sb.Append("'"+txt_first_name.Text+"'");
                    sb.Append(",'"+txt_middle_name.Text+"'");
                    sb.Append(",'"+txt_lastname.Text+"'");            
                    sb.Append(",'"+txt_username.Text+"'");
                    sb.Append(",'"+txt_password.Text+"'");
                    int is_admin=0;
                    if (chk_is_admin.Checked) 
                    {
                        is_admin = 1;
                    }
                    sb.Append(","+is_admin+"");
                    Image image = imageviewer.Image;                                                                        
                    sb.Append(",@name");
                    sb.Append(",'" + extension+"'");
                    sb.Append(",'"+ txt_first_name.Text + txt_middle_name.Text + txt_lastname.Text + "'");
                    sb.Append(",'"+DateTime.Now.ToString()+"')");
                        Program.da.name = "@name";
                        Program.da.value = imageToByteArray(image);
                    if (Program.da.insert(sb.ToString())) 
                    {
                        msgbox.Show(this,"Successfully saved","Message");
                        enableButton = false;
                        Load_grid();
                        action = ""; 
                    }
                    break;
                case "edit":
                    if (msgbox.Confirm(this, "Are you sure you want to save changes", "Update Confirmation"))
                    {
                        sb.Append("update users set ");
                        sb.Append("first_name='" + txt_first_name.Text + "'");
                        sb.Append(",middle_name='" + txt_middle_name.Text + "'");
                        sb.Append(",last_name='" + txt_lastname.Text + "'");
                        sb.Append(",username='" + txt_username.Text + "'");
                        sb.Append(",password='" + txt_password.Text + "'");

                        Image image1 = imageviewer.Image;


                        //extension
                        sb.Append(",image=@name" );
                        sb.Append(",extension='" + extension + "'");
                        sb.Append(",full_name='" + txt_first_name.Text + txt_middle_name.Text + txt_lastname.Text + "'");
                        int is_admin_ = 0;
                        if (chk_is_admin.Checked)
                        {
                            is_admin_ = 1;
                        }
                        sb.Append(",user_level= " + is_admin_ + " ");

                        sb.Append("where id =" + id_ + "");
                        Program.da.name = "@name";
                        Program.da.value = imageToByteArray(image1);
                        
                        if (Program.da.update(sb.ToString()))
                        {
                            msgbox.Show(this, "Successfully edited", "Message");
                            enableButton = false;
                            Load_grid();
                            action = "";
                            select(null);
                            txt_password.Hint = "";
                        }
                    }
                    break;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            enableButton = false;
            cleartxt();
            txt_password.Visible = false;
            txt_confirma_password.Visible = false;
            lbl_password.Visible = false;
            lbl_confirm_password.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void cleartxt() 
        {
          
            txt_confirma_password.Clear();
            txt_first_name.Clear();
            txt_lastname.Clear();
            txt_middle_name.Clear();
            txt_password.Clear();
            txt_username.Clear();
            chk_is_admin.Checked = false;
        }
        private bool enableButton
        {
            set {               
                    btn_add.Enabled = !value;
                    btn_edit.Enabled = !value;
                    btn_delete.Enabled = !value;
                    btn_save.Enabled = value;
                    btn_cancel.Enabled = value;
                     
                    txt_confirma_password.Enabled = value;
                    txt_first_name.Enabled = value;
                    txt_lastname.Enabled = value;
                    txt_middle_name.Enabled = value;
                    txt_password.Enabled = value;
                    txt_username.Enabled = value;
               }
             
        }

        
        private void mgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select(e) ;
        }
         
        private void mgrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            select(e);
        }
        private void select(DataGridViewCellEventArgs e)
        {
             
            try
            {
                if (e != null) { id_ = mgrid.Rows[e.RowIndex].Cells["id"].Value.ToString(); }

                string sql = "select  * from  users  where id =" + id_ + "";
                DataTable dt = new System.Data.DataTable();
                if (Program.da.Select(sql))
                {
                    dt = Program.da.getTable();
                    DataRow dr = dt.Rows[0];
                    
                    txt_first_name.Text = dr["first_name"].ToString();
                    txt_lastname.Text = dr["last_name"].ToString();
                    txt_middle_name.Text = dr["middle_name"].ToString();
                    txt_password.Text = dr["password"].ToString();
                    txt_username.Text = dr["username"].ToString();
                    try
                    {
                        lbl_date_registered.Text = "Date Registered :" + DateTime.Parse(dr["date_registered"].ToString()).ToShortDateString();
                    }
                    catch (Exception xx) { }
                    string is_admin = dr["user_level"].ToString();
                    chk_is_admin.Checked = false;
                    if (is_admin.Equals("1"))
                    {
                        chk_is_admin.Checked = true;
                    }
                    imageviewer.SizeMode = PictureBoxSizeMode.StretchImage;   
                    try
                    {
                        byte[] data = (byte[])dt.Rows[0]["image"];
                        MemoryStream ms = new MemoryStream(data);
                        imageviewer.Image = Image.FromStream(ms);
                    }
                    catch (Exception xx) { imageviewer.Image = Properties.Resources.businessman; }
                    txt_password.Visible = false;
                    txt_confirma_password.Visible = false;
                    lbl_confirm_password.Visible = false;
                    lbl_password.Visible = false;
                    enableButton = false;
                }
            }
            catch (Exception xx) 
            {
            }
        }

        private void txt_search_area_KeyUp(object sender, KeyEventArgs e)
        {
            mgrid.DataSource = null;
            if (txt_search_area.Text.Length > 0 && !txt_search_area.Text.Equals(" "))
            {
                string sql = "select  UPPER(CONCAT_WS(\" \",first_name,middle_name,last_name))as name,id from users where full_name like '%" +txt_search_area.Text+ "%' order by id desc";
                DataTable dt = new System.Data.DataTable();
                if (Program.da.Select(sql))
                {
                    dt = Program.da.getTable();
                    mgrid.AllowUserToAddRows = false;
                    mgrid.AutoGenerateColumns = false;
                    mgrid.DataSource = dt;
                    for (int i = 0; i < mgrid.Rows.Count; i++)
                    {
                        mgrid.Rows[i].Cells["no"].Value = i + 1 + ".)";
                    }
                }
            }
            else 
            {
                Load_grid();
            }
        }

        private void txt_search_area_Enter(object sender, EventArgs e)
        {
             
        }

        private void txt_search_area_Leave(object sender, EventArgs e)
        {  
        }

        private void txt_confirma_password_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (txt_password.Text.Replace(" ", "").Equals(""))
            {
                txt_confirma_password.Clear();
            }
            else 
            {
                if (txt_password.Text.Length == txt_confirma_password.Text.Length  )
                {
                    if (txt_confirma_password.Text.Equals(txt_password.Text))
                    {
                        pictureBox1.Image = Properties.Resources.success;
                    }
                    else 
                    {
                        pictureBox1.Image = Properties.Resources.x;
                    }
                }
                else 
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_confirma_password.Text.Length != txt_password.Text.Length)
            {
                txt_confirma_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_confirma_password.ForeColor = Color.Black;
            }
            else 
            {
                if (txt_confirma_password.Text.Equals(txt_password.Text))
                {
                    txt_password.ForeColor = Color.Green;
                    txt_confirma_password.ForeColor = Color.Green;
                }
                else
                {
                    txt_password.ForeColor = Color.Red;
                    txt_confirma_password.ForeColor = Color.Red;
                }
            }
        }

        private void txt_password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_edit_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            confirmapassword form = new confirmapassword(txt_password.Text);
            form.ShowDialog();
            if (form.ValidPassword) 
            {
                form.Close();
                txt_password.Visible = true;
                txt_confirma_password.Visible = true;
                lbl_password.Visible = true;
                lbl_confirm_password.Visible = true;
                btn_edit_Click(null,null);
                txt_password.Text="";
                txt_password.Hint = "Enter New Password";
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(msgbox.Confirm(this,"Are you sure you want to delete "+txt_first_name.Text.ToUpper()+" "+txt_middle_name.Text.ToUpper()+" "+txt_lastname.Text.ToUpper(),"Delete Confirmation"))
            {
                if (Program.da.delete("delete from users where id = " + id_ + ""))
                {
                    msgbox.Show(this,"Successfully deleted","Message");
                    cleartxt();
                    enableButton = false;
                    Load_grid();
                }
            }
        }
        private bool Validate() 
        {
            emptyvalue.Clear();
                if(txt_username.Text.Equals(""))
                {
                    emptyvalue.Add("Username");
                }
                if (txt_password.Text.Equals(""))
                {
                    emptyvalue.Add("Password");
                }
                return !string.Join("\n",emptyvalue).Equals("");  
            
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

        private void Users_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|Bitmap(*.BMP)|*.BMP|Joint Photographic Experts Group(*.JPEG;*.JPG)|*.JPEG;*.JPG|Portable Network Graphics(*.PNG)|*.PNG";
            if (ofd.ShowDialog() ==DialogResult.OK)
            {
                try
                {
                    Value = Image.FromFile(ofd.FileName);
                    if (Value.Size.Width > imageviewer.Size.Width || Value.Size.Height > imageviewer.Size.Height)
                    {
                        imageviewer.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        imageviewer.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    imageviewer.Image = Value;
                }
                catch (Exception xx)
                {
                    imageviewer.SizeMode = PictureBoxSizeMode.StretchImage;                    
                    imageviewer.Image = Properties.Resources.businessman;   
                }
                extension=Path.GetExtension(ofd.FileName);
               
                
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            imageIn.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

            return memoryStream.ToArray();
            
        }
    }
}
