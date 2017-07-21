using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TRASY
{
    public static class msgbox
    {
        public static Boolean yes;
       
        public static void Show(MetroForm frm, string message, string label)
        {        
            MetroMessageBox.Show(frm, message, label, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Show(Form frm, string message, string label)
        {
            MetroMessageBox.Show(frm, message, label, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowSkip(MetroForm frm, string message, string label)
        {

            MetroMessageBox.Show(frm, message, label, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public static void ShowSkip(Form frm, string message, string label)
        {

            MetroMessageBox.Show(frm, message, label, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public static void Warning(MetroForm frm, string message, string label)
        {
            MetroMessageBox.Show(frm, message, label, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Warning(Form frm, string message, string label)
        {
            MetroMessageBox.Show(frm, message, label, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Warning2(MetroForm frm, string message, string label)
        {
            MetroMessageBox.Show(frm, message, label, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Warning2(Form frm, string message, string label)
        {
            MetroMessageBox.Show(frm, message, label, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static bool Confirm(MetroForm frm, string message, string label){
          var confirm=  MetroMessageBox.Show(frm,message,label,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          return confirm == DialogResult.Yes;
           
        }
        public static bool Confirm(Form frm, string message, string label)
        {
            var confirm = MetroMessageBox.Show(frm, message, label, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return confirm == DialogResult.Yes;

        }

     

    }
}
