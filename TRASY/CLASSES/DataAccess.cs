using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TRASY
{
    class DataAccess
    {
        private MySqlConnection con;
        private DataTable table;
        private int rows_affected;
        public long insert_id;
        private string error;

        public DataAccess()
        {
            this.connect();
        }

        public bool connect() {
            try
            {
                this.con = new MySqlConnection("server=absn.com.ph;database=absncomp_trasy;uid=absncomp_sa;password=abc123!@#");
                this.con.Open();
                return true;
            }
            catch (Exception ex) {
                this.error = ex.Message;
                return false;
            }
        }

        public bool is_connected() {
            if (!this.con.Ping())
            {
                this.error = "Connection cannot be established. Please contact your system administrator";
                return false;
            }
            return true;
        }

        public bool Select(string query)
        {
            try
            {
                if (!this.is_connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }
                string aa="";
                MySqlCommand cmd = new MySqlCommand(query, this.con);   
                
                this.table = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(this.table);
                if (this.table.Rows.Count.Equals(0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex) {
                this.error = ex.Message;
                return false;
            }
        }
        
        
        
        public DataTable getTable() {
            return this.table;
        }

        public bool insert(string sql) {
            try
            {
                if (!this.is_connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }

                MySqlCommand cmd = new MySqlCommand(sql, this.con);
                cmd.Parameters.Add(name, value);
                this.rows_affected = cmd.ExecuteNonQuery();
                if (this.rows_affected == 0)
                {
                    this.error = "No record was inserted. Please contact your system administrator.";
                    return false;
                }
                this.insert_id = cmd.LastInsertedId;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }

        public bool update(string sql) {
            try
            {
                if (!this.is_connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }               

                MySqlCommand cmd = new MySqlCommand(sql, this.con);
                cmd.Parameters.Add(name, value);
                this.rows_affected = cmd.ExecuteNonQuery();
                if (this.rows_affected == 0)
                {
                    this.error = "No record was updated. Please contact your system administrator.";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }

        public bool delete(string sql) {

            try 
            {
                if (!this.is_connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }

                MySqlCommand cmd = new MySqlCommand(sql, this.con);
           
                this.rows_affected = cmd.ExecuteNonQuery();
                if (this.rows_affected == 0)
                {
                    this.error = "No record was deleted. Please contact your system administrator.";
                    return false;
                }
                return true;
            }
            catch (Exception ex) {
                this.error = ex.Message;
                return false; 
            }
            
        }
        public string name
        {
            get;
            set;
        }
        public byte[] value
        {
            get;
            set;
        }

    }
}
