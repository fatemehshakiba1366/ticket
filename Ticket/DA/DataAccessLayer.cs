using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DA
{
   public class DataAccessLayer
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dap;
        public DataAccessLayer()
        {
            con = new OleDbConnection();
            cmd = new OleDbCommand();
            dap = new OleDbDataAdapter();
            cmd.Connection = con;
            dap.SelectCommand = cmd;
        }
        public void connect()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\HW\\Ticket\\DA\\DB.accdb;Persist Security Info=True";
            con.Open();
        }
        public void disconnect()
        {
            con.Close();
        }
        public DataTable select(string sql)
        {
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public void docommand(string sql)
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
    }
}
