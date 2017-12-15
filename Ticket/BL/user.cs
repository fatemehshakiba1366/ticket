using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class User : DataAccessLayer
    {
        public string ID;
        public string Password;
        public string NameFamily;

        public void ADD(string ID, string Password, string NameFamily)
        {
            base.connect();
            String sql = "Insert into Users (UID, UPassword, UNameFamily) values ('" + ID + "', '" + Password + "', '" + NameFamily + "') ";
            base.docommand(sql);
            base.disconnect();
        }
        public void delete(int ID)
        {
            base.connect();
            string sql = "Delete from Users where UID = " + ID;
            base.docommand(sql);
            base.disconnect();
        }
        public void update(int ID, string Password, string NameFamily)
        {
            base.connect();
            string sql = "Update Users set UPassword = '" + Password + "', UNameFamily = '" + NameFamily + "' where UID = " + ID;
            base.disconnect();
            base.disconnect();

        }
        public DataTable select()
        {
            base.connect();
            string sql = "Select * from Users";
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;

        }
        public DataTable selectUserInfo(string ID)
        {
            try
            {
                base.connect();
                string sql = "select * from Users where UID = '" + ID + "'";
                DataTable dt = base.select(sql);
                base.disconnect();
                return dt;
            }
            catch
            {
                return null;
            }
        }

    }
}
