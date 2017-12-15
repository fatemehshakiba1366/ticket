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
    public class Customer : DataAccessLayer
    {
        public string ID;
        public string Name;
        public string Family;
        public string Phone;
        public string UNameFamily;

        public void ADD(string Name, string Family, string Phone, string UNameFamily)
        {
            base.connect();
            String sql = "Insert into Tickets (TName, TFamily, TPhone, UNameFamily) values ('" + Name + "', '" + Family + "', '" + Phone + "', '" + UNameFamily + "')";
            base.docommand(sql);
            base.disconnect();
        }
        public void delete(int ID)
        {
            base.connect();
            string sql = "Delete from Tickets where TID = " + ID;
            base.docommand(sql);
            base.disconnect();
        }
        public void update(int ID, string Name, string Family, string Phone, string UNameFamily)
        {
            base.connect();
            string sql = "Update Tickets set TName = '" + Name + "', TFamily = '" + Family + "', TPhone = '" + Phone + "', UNameFamily = '" + UNameFamily + "' where ID = " + ID;
            base.disconnect();
            base.disconnect();

        }
        public DataTable select()
        {
            base.connect();
            string sql = "Select * from Tickets";
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;

        }
    }

    
}
