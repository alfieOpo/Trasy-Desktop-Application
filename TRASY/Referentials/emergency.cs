using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TRASY
{
    public partial class emergency : MetroForm
    {
       
 
        string title;
        string action = "";
        string EID = "";
        public emergency ()
        {
            InitializeComponent ();
          
        }

       

        private void cleartxt ()
        {
            txt_content.Clear ();
            txt_title.Clear ();
            
            txt_search_area.Clear ();
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
                
                txt_content.Enabled = value;
                txt_title.Enabled = value;
                 
            }
        }

        private void btn_add_Click (object sender , EventArgs e)
        {
            action = "add";
            cleartxt ();
            enableButton = true;
        }

        private void btn_edit_Click (object sender , EventArgs e)
        {
            action = "edit";
            enableButton = true;
        }

        private void btn_delete_Click (object sender , EventArgs e)
        {
            if ( msgbox.Confirm (this , "Are you sure you want to delete " + txt_title.Text.ToUpper () , "Delete Confirmation") )
            
                if ( Program.da.delete ("DELETE FROM emergency WHERE id=" +EID + "") )
                {
                    enableButton = false;
                    cleartxt ();
                    load_list (false);
                    action = "";
                    msgbox.Show (this , "Successfully deleted" , "Message");
                }
            }
        

        private void btn_save_Click (object sender , EventArgs e)
        {
            switch ( action )
            {
                case "add":
                    if ( Program.da.insert (@"insert into emergency set name='"+txt_title.Text+"',message='"+txt_content.Text+"'") )
                    {
                        enableButton = false;
                        load_list (false);
                        action = "";
                        msgbox.Show (this , "Successfully saved" , "Message");
                    }
                    break;
                case "edit":
                    if ( msgbox.Confirm (this , "Do you want to save Changes" , "Update Confirmation") )
                    {
                        if ( Program.da.update (@"update emergency set name='" + txt_title.Text + "',message='" + txt_content.Text + "' where id ="+EID) )
                        {
                            enableButton = false;
                            load_list (false);
                            action = "";
                            msgbox.Show (this , "Successfully edited" , "Message");
                        }
                    }
                    break;
            }
        }

        private void btn_cancel_Click (object sender , EventArgs e)
        {
            cleartxt ();
            enableButton = false;
            action = "";
        }

        private void btn_close_Click (object sender , EventArgs e)
        {
            this.Visible = false;
        }
        private void load_list (bool search)
        {
            mgrid.DataSource = null;
            string param = "";
            if ( search )
            {
                param = "where name like '%" + txt_search_area.Text + "%'";
            }
            DataTable dt = new DataTable ();
            if ( Program.da.Select ("SELECT id, name,message FROM emergency " + param + " ") )
            {
                dt = Program.da.getTable ();
                mgrid.AutoGenerateColumns = false;
                mgrid.AllowUserToAddRows = false;
                mgrid.DataSource = dt;
                for ( int i = 0; i < mgrid.Rows.Count; i++ )
                {
                    mgrid.Rows [i].Cells ["no"].Value = i + 1 + ".)";
                }
            }
        }

        private void txt_search_area_KeyUp (object sender , KeyEventArgs e)
        {
            if ( txt_search_area.Text.Equals ("") )
            {
                load_list (false);
            }
            else
            {
                load_list (true);
            }

        }

        private void mgrid_CellClick (object sender , DataGridViewCellEventArgs e)
        {
            list_clicks (e);
        }

        private void mgrid_CellEnter (object sender , DataGridViewCellEventArgs e)
        {
            list_clicks (e);
        }
        private void list_clicks (DataGridViewCellEventArgs e)
        {
            try
            {
                
                DataTable dt = new DataTable ();
                 EID = mgrid.Rows [e.RowIndex].Cells ["id"].Value.ToString (); 
                if ( Program.da.Select ("SELECT name,message FROM emergency where id=" + EID + "") )
                {
                    dt = Program.da.getTable ();
                    DataRow dr = dt.Rows [0];
                    txt_title.Text = dr ["name"].ToString ();
                    txt_content.Text = dr ["message"].ToString ();
                   
                }
            }
            catch ( Exception xxx ) { }
        }

        private void txt_search_area_MouseEnter (object sender , EventArgs e)
        {


        }

        private void txt_search_area_MouseLeave (object sender , EventArgs e)
        {

        }

        private void txt_search_area_Enter (object sender , EventArgs e)
        {
            if ( txt_search_area.Text.Equals ("Search") )
            {
                txt_search_area.Text = "";
            }
        }

        private void txt_search_area_Leave (object sender , EventArgs e)
        {
            if ( txt_search_area.Text.Equals ("") )
            {
                txt_search_area.Text = "Search";
            }
        }

       

       
        private void emergency_Load (object sender , EventArgs e)
        {
            load_list (false);
        }

        private void emergency_MouseDown(object sender, MouseEventArgs e)
        {
          
            
        }
    }
}
