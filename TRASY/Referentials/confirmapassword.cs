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
namespace TRASY
{
    public partial class confirmapassword : Form
    {
        string current_password = "";
        bool valid = false;
        public confirmapassword(string _current_password)
        {
            current_password = _current_password;
            InitializeComponent();
        }

        private void confirmapassword_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_error.Visible = false;
            if(Keys.Enter==e.KeyCode)
            {
                if (current_password.Equals(metroTextBox1.Text))
                {
                    valid = true;
                    this.Close();
                }
                else 
                {
                    valid = false;
                    lbl_error.Visible = true;
                    lbl_error.Text = "Warning: Invalid Password.";
                    
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool ValidPassword 
        {
            get { return valid; }
        }
    }
}
