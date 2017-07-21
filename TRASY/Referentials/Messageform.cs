using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRASY
{
    public partial class Messageform : MetroForm
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
         
        string title;
        string Message , Bus_name , Date;
        public Messageform (string message,string bus_name,string date,string _title)
        {
            InitializeComponent ();
            Message = message;
            Bus_name = bus_name;
            Date = date;
            title = _title;
            lbl_title.Text = "TITLE : "+title.ToUpper ();
            txt_message.Text =  Message;
            lbl_bus_name.Text = "BUS NAME : "+Bus_name;
            lbl_date.Text = "DATE : "+Date;
        }      
        private void button1_Click (object sender , EventArgs e)
        {
            this.Close ();
        }
    }
}
