using MetroFramework.Forms;
using System;

using System.Data;

using System.Windows.Forms;

namespace TRASY
{
    public partial class messages : MetroForm
    {
        
        DataTable dt = new DataTable ();
        int _old = 0;
        public messages()
        {
            InitializeComponent();
        }

        private void messages_Load (object sender , EventArgs e)
        {
            tabControl1.SelectedIndexChanged += new EventHandler (tabControl1_SelectedIndexChanged);
            cbo_type.SelectedIndex = 0;
            tabControl1.SelectedIndex=0;
            LoadList ();
            cbo_message_type.SelectedIndex = 0;
            pnl_cbo_.Visible = false;
            mgrid.Visible = true;
            loadAlertCompany ();
            

         
        }
        private void LoadList () {
            string sql = "" ;
            if ( cbo_type.Text.Equals ("ALL") )
            {
                sql="SELECT m.id,CONCAT(em.first_name,' ' ,em.middle_name,' ',em.last_name) name FROM `message` m left join employee em on m.user_id=em.id ";
            }
            else {
                
                sql = "select x.* from  (SELECT m.id,CONCAT(em.first_name,' ' ,em.middle_name,' ',em.last_name) name FROM `message` m left join employee em on m.user_id=em.id and type='" + cbo_type.Text + "') x where x.`name` is not null";

            }
            DataTable dt = new DataTable ();
            Program.da.Select (sql);
            dt = Program.da.getTable ();
            mgrid.AutoGenerateColumns = false;
            mgrid.AllowUserToAddRows = false;
            mgrid.DataSource = dt;
            
        }
        private void Select (DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable ();
            try
            {
                string id = mgrid.Rows [e.RowIndex].Cells ["id"].ToString ();
                Program.da.Select ("SELECT m.id,CONCAT(em.first_name,' ' ,em.middle_name,' ',em.last_name) name FROM `message` m left join employee em on m.user_id=em.id where m.id="+id);
                dt = Program.da.getTable ();
            
            }
            catch ( Exception xx ) { }

        }

        private void mgrid_CellClick (object sender , DataGridViewCellEventArgs e)
        {
            Select (e);
        }

        private void mgrid_CellEnter (object sender , DataGridViewCellEventArgs e)
        {
            Select (e);
        }

        private void cbo_type_DropDownClosed (object sender , EventArgs e)
        {
            LoadList ();

        }

        private void tabControl1_SelectedIndexChanged (object sender , EventArgs e)
        {
            if ( tabControl1.SelectedTab ==message )
            {
                pnl_cbo.Visible = false;
                cbo_type.SelectedIndex = 0;
                cbo_type.Enabled = true;
                mgrid.Visible = false;


            }
            else { pnl_cbo.Visible = true; }
            if ( tabControl1.SelectedTab == alert )
            {
                cbo_type.SelectedIndex = 1;
                LoadList ();
                cbo_type.Enabled = false;
                mgrid.Visible = true;

            }
            if ( tabControl1.SelectedTab == emegency )
            {
                cbo_type.SelectedIndex = 2;
                LoadList ();
                cbo_type.Enabled = false;
                mgrid.Visible = true;
            }
            if ( tabControl1.SelectedTab == personal )
            {
                cbo_type.SelectedIndex = 3;
                LoadList ();
                cbo_type.Enabled = false;
                mgrid.Visible = true;
            }
        }

        private void metroComboBox1_SelectedIndexChanged (object sender , EventArgs e)
        {

        }

       

        private void button1_Click (object sender , EventArgs e)
        {
            string type = "";
            string title="no title";
            switch ( cbo_message_type.Text )
            {
                case "ALERT MESSAGE":
                    type = "alert";
                    if ( txt_alert.Text.Equals ("") )
                    {
                        msgbox.Warning2 (this , "No Title found." , "Warning");

                        return;
                    }
                    else {
                        title = txt_alert.Text;
                    }
                    break;
                case "EMERGENCY MESSAGE":
                    type = "emergency";
                    
                    break;
                case "PERSONAL MESSAGE":
                    type = "personal";
                    break;
            }
            string bus_id = "";
            try
            {
                bus_id = cbo_bus_name.SelectedValue.ToString ();
            }
            catch ( Exception xx )
            {
                bus_id = "0";
            }
            string sql = @"insert into message (message,user_id,date,type,plate_no,title) 
            values('" + txt_message.Text + "'," + Program.user.id + ",CURRENT_TIMESTAMP(),'" + type + "'," + bus_id + ",'" + title + "')";
            if ( Program.da.insert (sql) ) {
                msgbox.Show (this,"Successfully Sent","Message");
            }
        }

        private void personal_Click (object sender , EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {

        }

        private void mgrid_company_personal_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {

        }

        private void cbo_message_type_DropDownClosed_1 (object sender , EventArgs e)
        {
            pnl_cbo_.Visible = false;
            pnl_alert.Visible = false;
            if ( cbo_message_type.Text.Equals ("PERSONAL MESSAGE") ) {
                pnl_cbo_.Visible = true;
                pnl_alert.Visible = false;
            }
            if ( cbo_message_type.Text.Equals ("ALERT MESSAGE") )
            {
                pnl_cbo_.Visible = false;
                pnl_alert.Visible = true;
            }

        }
        private void loadBusname () {
            DataTable dt = new DataTable ();
        if(Program.da.Select("select * from buses where isuse =1")){
            dt = Program.da.getTable ();
            cbo_bus_name.ValueMember = "bus_plate_no";
            cbo_bus_name.DisplayMember = "bus_name";
            cbo_bus_name.DataSource = dt;
        }
        
        }
        private void loadAlertCompany () {
            string sql = @"select CONCAT(UPPER(buses.bus_name),'-',UPPER(message.title))as  name,message.message,message.id,message.date,message.longitude,message.latitude,buses.bus_name,message.title from message 
LEFT JOIN buses on buses.id=message.bus_id where CONCAT(UPPER(buses.bus_name),'-',message.message) is not null and message.type='alert' order by id desc";
            if ( Program.da.Select (sql) ) {

                dt = Program.da.getTable ();
                mgrid_alert_company.AutoGenerateColumns=false;
                mgrid_alert_company.DataSource = dt;
            }
        }
        private void loadEmergencyCompany () {
            string sql = @"select CONCAT(UPPER(buses.bus_name),'-',message.message)as  name,message.message,message.id,message.date,message.longitude,message.latitude,buses.bus_name from message 
LEFT JOIN buses on buses.id=message.bus_id where CONCAT(UPPER(buses.bus_name),'-',message.message) is not null and message.type='emergency' order by id desc";
            if ( Program.da.Select (sql) )
            {
                 
                dt = Program.da.getTable ();
                mgrid_emergency.AutoGenerateColumns = false;
                mgrid_emergency.DataSource = dt;
            }
        }
        private void loadPersonalCompany () { }        
        private void loadPersonalBus () { }
        private void loadEmergencyBus () { }

        private void mgrid_alert_company_CellDoubleClick (object sender , DataGridViewCellEventArgs e)
        {
            string Message = mgrid_alert_company.Rows [e.RowIndex].Cells ["realmessage"].Value.ToString ()
                  , Bus_name = mgrid_alert_company.Rows [e.RowIndex].Cells ["busname"].Value.ToString ()
                  , Date = mgrid_alert_company.Rows [e.RowIndex].Cells ["date"].Value.ToString ()
                  ,title=mgrid_alert_company.Rows[e.RowIndex].Cells["title"].Value.ToString();
            Messageform form = new Messageform (Message , Bus_name , Date , title);
              form.Show ();
        }
        private void mgrid_emergency_CellDoubleClick (object sender , DataGridViewCellEventArgs e)
        {
            string Message = mgrid_emergency.Rows [e.RowIndex].Cells ["_message"].Value.ToString ()
                 , Bus_name = mgrid_emergency.Rows [e.RowIndex].Cells ["_bus_name"].Value.ToString ()
                 , Date = mgrid_emergency.Rows [e.RowIndex].Cells ["_date"].Value.ToString ()
                 , title = "NOT TITLE FOUND";
            Messageform form = new Messageform (Message , Bus_name , Date , title);
            form.Show ();
        }

        private void timer1_Tick (object sender , EventArgs e)
        {
            CheckOnlineBus ();
            loadAlertCompany ();
            loadEmergencyCompany ();
        }

        private void mgrid_alert_company_CellPainting (object sender , DataGridViewCellPaintingEventArgs e)
        {
             
        }

        private void mgrid_alert_company_RowPrePaint (object sender , DataGridViewRowPrePaintEventArgs e)
        {
             
        }

        private void CheckOnlineBus(){
             
                DataTable dt = new DataTable ();
                if ( Program.da.Select ("select count(id) cnt from buses where isuse=1") )
                {
                    dt = Program.da.getTable ();
                    try {
                        int _new=  int.Parse (dt.Rows [0] ["cnt"].ToString ());
                        if(_new!=_old){
                            loadBusname ();
                            _old = _new;
                        }

                    }
                    catch ( Exception xx ) { }
                    
                }
                
            
        }
                             
    }
}
