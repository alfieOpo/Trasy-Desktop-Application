using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRASY
{
   public class users_info
    {
       private string _username = "";
       private string _password = "";
       private string _first_name = "";
       private string _last_name = "";
       private string _middle_name = "";
       private string _bus_no = "";
       private string _plate_no = "";
       private string _license_no = "";
       private string _is_admin = "";
       private string _id = "";
       private Image _image;
       public string is_admin
       {
           get { return this._is_admin; }
           set { this._is_admin = value; }
       }
       public Image Image
       {
           get { return this._image; }
           set { this._image = value; }
       }
       public string id
       {
           get { return this._id; }
           set { this._id = value; }
       }
       public string license_no
       {
           get { return this._license_no; }
           set { this._license_no = value; }
       }
       public string plate_no
       {
           get { return this._plate_no; }
           set { this._plate_no = value; }
       }
       public string bus_no
       {
           get { return this._bus_no; }
           set { this._bus_no = value; }
       }

       public string username 
       {
           get { return this._username; }
           set { this._username = value; }
       }
       public string password
       {
           get { return this._password; }
           set { this._password = value; }
       }
       public string first_name
       {
           get { return this._first_name; }
           set { this._first_name = value; }
       }
       public string middle_name
       {
           get { return this._middle_name; }
           set { this._middle_name = value; }
       }
       public string last_name
       {
           get { return this._last_name; }
           set { this._last_name = value; }
       }
       public users_info() { }
       public users_info(
           	  string __username ,
      string __password ,
      string __first_name ,
      string __last_name ,
      string __middle_name ,
      string __bus_no ,
      string __plate_no ,
      string __license_no ,
      string __is_admin 
           ) 
       {
           this._bus_no = __bus_no;
           this._first_name = __first_name;
           this._is_admin = __is_admin;
           this._last_name = __last_name;
           this._license_no = __license_no;
           this._middle_name = __middle_name;
           this._password = __password;
           this._plate_no = __plate_no;
           this._username = __username;
       }
 
   }
}
