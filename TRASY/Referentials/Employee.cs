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
    public partial class Employee : MetroForm
    {
        string action = "";
        string EMPID = "";
        int gender = 0;
   
   
        public Employee()
        {
            InitializeComponent();
        }         
        private void Users_Load(object sender, EventArgs e)
        {
            
            enableSave = false;
            enableText = false;
            LoadList ();
            pnl_advance.Visible = false;
            laod_cbo ();
        }   
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            action = "add";
            enableText = true;
            enableSave = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            action = "edit";
            enableText = true;
            enableSave = true;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
           
            switch (action) 
            {
                case"add":

                    if ( !rdn_female.Checked )
                    {
                        gender = 1;
                    }
                    else { gender = 0; }
                    string sql = @"insert into employee (first_name,middle_name,
                    last_name,gender,age,date_start,date_register,position) values ('"+txt_first_name.Text+"','"+txt_middle_name.Text+"','"+txt_lastname.Text+"','"+gender+"','"+txt_age.Text+"','"+dt_datestart.Value.ToShortDateString()+"','"+DateTime.Now.ToShortDateString()+"','"+cbo_position.SelectedValue.ToString()+"')";

                    if ( Program.da.insert (sql) )
                    {
                        msgbox.Show (this , "Success fully saved." , "Messsage");
                        GENERATE_USERNAMEN_and_PASSWORD ();
                        enableSave = false;
                        enableText = false;
                        LoadList () ;
                    }
                    break;
                case "edit":
                    if(msgbox.Confirm(this,"Do you want to save changes.?","Update Confirmation")){
                        if ( !rdn_female.Checked )
                        {
                            gender = 1;
                        }
                        else { gender = 0; }
                        string udpatesql = "update   employee  set first_name='" + txt_first_name.Text + "',middle_name='" + txt_middle_name.Text + "',last_name='" + txt_lastname.Text + "',gender='" + gender + "',age='" + txt_age.Text + "',date_start='" + dt_datestart.Value.ToShortDateString () + "',date_register='" + DateTime.Now.ToShortDateString () + "',position='" + cbo_position.SelectedValue.ToString () + "' where id =" + EMPID;
                        if ( Program.da.update (udpatesql) )
                        {
                            msgbox.Show (this,"Success fully edited.","Messsage");
                            enableSave = false;
                            enableText = false;
                            LoadList ();
                        }
                    }
                   
                    break;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            enableText = false;
            enableSave = false;
        }


        private bool enableText {
            set {
                txt_age.Enabled = value;
                txt_first_name.Enabled = value;
                txt_lastname.Enabled = value;
                txt_middle_name.Enabled = value;
                txt_password.Enabled = value;                
                txt_uisername.Enabled = value;
                cbo_position.Enabled = value;
                rdn_female.Enabled = value;
                rdn_male.Enabled = value;
                if(action.Equals("add")){

                    txt_age.Clear ();
                  
                    txt_first_name.Clear ();
                    txt_lastname.Clear ();
                    txt_middle_name.Clear ();
                    txt_password.Clear ();
                    txt_search_area.Clear ();
                    txt_uisername.Clear ();
                    rdn_female.Checked = false;
                    rdn_male.Checked = false;
                }
            }
        }
        private bool enableSave {
            set {
                btn_add.Enabled = !value;
                btn_cancel.Enabled = value;
          
                btn_edit.Enabled = !value;
                btn_save.Enabled = value;
                
            }
        }

        private void btn_delete_Click (object sender , EventArgs e)
        {
            if ( msgbox.Confirm (this , "Are you sure you want to delete "+txt_first_name.Text.ToUpper()+" "+txt_lastname.Text.ToUpper() , "Delete Confirmation") )
            {
                if ( !rdn_female.Checked )
                {
                    gender = 1;
                }
                string deletesql = "delete  from  employee  where id =" + EMPID;
                if ( Program.da.delete (deletesql) )
                {
                    msgbox.Show (this,"Successfully deletd.","Message");
                    enableSave = false;
                    enableText = false;
                    LoadList ();
                }
            }
        }
        private void LoadList () {
            Program.da.Select ("SELECT id,CONCAT(first_name,' ',middle_name,' ',last_name) name  FROM `employee`");
            DataTable dt = new System.Data.DataTable ();
            dt = Program.da.getTable ();
            mgrid.AutoGenerateColumns = false;
            mgrid.AllowUserToAddRows = false;
            mgrid.DataSource = dt;
        }

        private void Select (DataGridViewCellEventArgs e)
        {
            if ( e != null )
            {

                try
                {
                    EMPID =  mgrid.Rows [e.RowIndex].Cells ["id"].Value.ToString ();
                    Program.da.Select ("SELECT * FROM `employee` where id =" + EMPID);
                    DataTable dt = new System.Data.DataTable ();
                    dt = Program.da.getTable ();
                    DataRow dr = dt.Rows [0];

                    rdn_female.Checked = false;
                    rdn_male.Checked = false;
                    if ( dr ["gender"].ToString ().Equals ("1") )
                    {
                        rdn_female.Checked = false;
                        rdn_male.Checked = true;
                    }
                    else {
                        rdn_female.Checked = true;
                        rdn_male.Checked = false;
                    }
                    cbo_position.SelectedValue = dr ["position"].ToString ();
                    txt_age.Text = dr ["age"].ToString ();
                    txt_first_name.Text = dr ["first_name"].ToString ();
                    txt_lastname.Text = dr ["last_name"].ToString ();
                    txt_middle_name.Text = dr ["middle_name"].ToString ();
                    try
                    {
                        dt_datestart.Value = DateTime.Parse (dr ["date_start"].ToString ());
                    }
                    catch ( Exception xx ) { }
                    txt_password.Text = dr ["generated_password"].ToString ();
                    txt_uisername.Text = dr ["generated_username"].ToString ();
                    lbl_date_registered.Text="Date Register: "+dr["date_register"].ToString();

                    
                }
                catch ( Exception xx )
                {

                }
            }
        }

        private void mgrid_CellClick (object sender , DataGridViewCellEventArgs e)
        {

            Select (e);
        }

        private void mgrid_CellEnter (object sender , DataGridViewCellEventArgs e)
        {
            Select (e);
        }

        private void lbl_advance_LinkClicked (object sender , LinkLabelLinkClickedEventArgs e)
        {
            if ( lbl_advance.Text.Equals ("HIDE") )
            {
                OBJECTVISIBLE = true;
                pnl_advance.Visible = false;
                lbl_advance.Text = "Advance";
            }
            else {
                OBJECTVISIBLE = false;
                pnl_advance.Visible = true;
                lbl_advance.Text = "HIDE";
            }
           
        }

        private bool OBJECTVISIBLE {
            set {
                groupBox1.Visible = false;
                txt_age.Visible = value;
                txt_first_name.Visible = value;
                txt_lastname.Visible = value;
                txt_middle_name.Visible = value;              
                cbo_position.Visible = value;
                rdn_female.Visible = value;
                rdn_male.Visible = value;
                lbl1.Visible = value;               
                lbl2.Visible = value;
                lbl3.Visible = value;
                lbl5.Visible = value;
                lbl6.Visible = value;
                lbl_3453.Visible = value;
                dt_datestart.Visible = value;

            }
        
        }
        private void laod_cbo ()
        {
            DataTable dt = new System.Data.DataTable ();
            if ( Program.da.Select ("SELECT id, name  FROM positions ") )
            {
                dt = Program.da.getTable ();
                cbo_position.DataSource = dt;
                cbo_position.DisplayMember = "name";
                cbo_position.ValueMember = "id";
            }
        }
        private string LATESTEMPID {
            get {
                DataTable dt = new System.Data.DataTable ();
                Program.da.Select ("select max(id) id from employee ");
                dt = Program.da.getTable ();
                return dt.Rows [0] ["id"].ToString ();
                }
        }
        private void GENERATE_USERNAMEN_and_PASSWORD () {
            string username="";
            if ( cbo_position.Text.ToLower ().Equals ("driver") )
            {
                username = "BD-" + int.Parse (LATESTEMPID).ToString ("D4") + "-SP";
            }
            else {
                username = "BC-" + int.Parse (LATESTEMPID).ToString ("D4") + "-SP";
            }
            Program.da.update ("update employee set generated_password='" + CreatePassword (8) + "',generated_username='" + username + "' where id =" + LATESTEMPID);
        }
        public string CreatePassword (int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder ();
            Random rnd = new Random ();
            while ( 0 < length-- )
            {
                res.Append (valid [rnd.Next (valid.Length)]);
            }
            return res.ToString ();
        }
    }
}
