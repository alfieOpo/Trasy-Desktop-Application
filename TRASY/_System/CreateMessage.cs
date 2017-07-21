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
    public partial class CreateMessage : MetroForm
    {
        public CreateMessage()
        {
            InitializeComponent();
        }

        private void CreateMessage_Load(object sender, EventArgs e)
        {
            cbo_type_message.SelectedIndex = 0;
            loadBusname(); 

        }
        private void loadBusname()
        {
            DataTable dt = new DataTable();
            if (Program.da.Select("select * from buses where isuse =1"))
            {
                dt = Program.da.getTable();
                cbo_bus_online.ValueMember = "bus_plate_no";
                cbo_bus_online.DisplayMember = "bus_name";
                cbo_bus_online.DataSource = dt;
            }

        }

        private void cbo_type_message_DropDownClosed(object sender, EventArgs e)
        {
            if (cbo_type_message.Text.Equals("Personal"))
            {
                enablebus(true);
                loadBusname();
            }
            else
            {
                enablebus(false);
            }
        }

        private void cbo_type_message_TextChanged(object sender, EventArgs e)
        {

           
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string type = "";
            string title = "no title";
            if (txt_title.Text.Equals(""))
            {
                msgbox.Warning2(this, "No Title found.", "Warning");

                return;
            }
            else
            {
                title = txt_title.Text;
            }
            switch (cbo_type_message.Text.ToLower())
            {
                case "personal":
                    type = "personal";
                    
                    break;
                case "emergency":
                    type = "emergency";

                    break;
                case "alert":
                    type = "alert";
                    break;
            }          
            string bus_id = "";
            try
            {
                bus_id = cbo_bus_online.SelectedValue.ToString();
            }
            catch (Exception xx)
            {
                bus_id = "0";
            }
            string sql = @"insert into message (message,user_id,date,type,plate_no,title) 
            values('" + txt_content.Text.Replace("'","''") + "'," + Program.user.id + ",CURRENT_TIMESTAMP(),'" + type + "','" + bus_id + "','" + title + "')";
            
            if (Program.da.insert(sql))
            {
                msgbox.Show(this, "Successfully Sent", "Message");
            }
        }
        private bool enablebus(bool value)
        {
            lbl_bus_name.Enabled = value;
            cbo_bus_online.Enabled = value;
            return false;
        }
    }
}
