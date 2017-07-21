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
using System.IO;
namespace TRASY
{
    public partial class login : Form
    {
        int c = 0;
        int i = 0;

        bool valid = false;
        public login()
        {
            InitializeComponent();
        }
      
        Label label = new Label();
        Random r = new Random();
        private void login_Load(object sender, EventArgs e)
        {
            enablelogin = false;
            timer1.Enabled = true;
            this.Visible = false;
            //splash.ShowDialog();
            //if (splash.DONELOADING) 
            //{
              
                this.Visible = true;
                lbl_version.Text = "Develop by TRASY GROUP.\n© ALL RIGHTS RESERVED 2017 \nVersion 1.0.0 ";        
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            activelogin();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            valid = false;
            this.Hide();
        }
        private bool check_users(string username,string password) {
            DataTable dt = new DataTable();
            if (Program.da.Select("select * from users where password ='"+password+"' and username='"+username+"'")) 
            {
                dt = Program.da.getTable();
                DataRow dr = dt.Rows[0];                
                Program.user.first_name = dr["first_name"].ToString();
                Program.user.middle_name = dr["middle_name"].ToString();
                Program.user.last_name = dr["last_name"].ToString();
                Program.user.password = dr["password"].ToString();
                Program.user.username = dr["username"].ToString();
                Program.user.id = dr["id"].ToString();
                 try
                    {
                        byte[] data = (byte[])dt.Rows[0]["image"];
                        MemoryStream ms = new MemoryStream(data);
                         
                        Program.user.Image = Image.FromStream(ms);
                    }
                 catch (Exception xx) {   Program.user.Image = Properties.Resources.employees; }


                valid = true;
                
                this.Hide();        
                return true;
            }
            return false;
        }
        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode) 
            {
                activelogin();
            }
        }
        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                activelogin();
            }
        }
        private void activelogin()
        {
            if (txt_username.Text.Equals(""))
            {
                msgbox.Warning2(this, "NO USERNAME FOUND", "WARNING");
                return;
            }
            if (txt_password.Text.Equals(""))
            {
                msgbox.Warning2(this, "NO PASSWORD FOUND", "WARNING");
                return;
            }
            if (check_users(txt_username.Text, txt_password.Text))
            {
            }
            else
            {
                msgbox.Warning2(this, "ERROR", "ERROR");
            }
        }
         public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();            
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }        
        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            
            if (4 == c)
            {
                i++;
                lbl_percent.Text = i + "%";
                label.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                c = 0;
            }
            if (lbl_load.Width < this.Width)
            {
                lbl_load.Width = lbl_load.Width + 1;
            }
            else
            {
                enablelogin = true;
          
                timer1.Enabled = false;
            }
        }
        private bool enablelogin 
        {
            set
            {
                if (value)
                {
                    lbl_label.Text = "LOGIN";
                    lbl_label.Location = new Point(-10, 4);
                    lbl_load.Controls.Clear();
                }
                if (!value)
                {
                    lbl_label.Location = new Point(78, 5);
                    lbl_label.Text = "TRASY";
                    lbl_load.Width = 0;
                 
                    label.BackColor = Color.Blue;
                    label.Width = 10;
                    label.Dock = DockStyle.Right;
                    lbl_load.Controls.Add(label);
                }
                
                lbl_version.Visible = !value;
               
                txt_password.Visible = value;
                txt_username.Visible = value;
                p_password.Visible = value;
                p_username.Visible = value;
                lbl_percent.Visible = !value;
                btn_cancel.Visible = value;
                btn_login.Visible = value;
            }
        }
       public bool Valid {
            get { return valid; }
        }
    }
}
