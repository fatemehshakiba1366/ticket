using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA;
using BL;

namespace Ticket
{
    public partial class frm_RegUser : Form
    {
        public frm_RegUser()
        {
            InitializeComponent();
        }

        private void txtFamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_RegUser_Load(object sender, EventArgs e)
        {

        }

        private void btnRegUserNow_Click(object sender, EventArgs e)
        {
            DataAccessLayer da = new DataAccessLayer();
            User us = new User();
            da.connect();
            if (txtUID.Text != "" && txtUNameFamily.Text != "" && txtUPassword.Text != "")
            {
                try
                {
                    us.ADD(txtUID.Text, txtUPassword.Text, txtUNameFamily.Text);
                    da.disconnect();
                    MessageBox.Show("کاربر ثبت شد", "ثبت کاربر", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch (Exception er)
                {
                    da.disconnect();
                    MessageBox.Show("ثبت انجام نشد :\n" + er.ToString(), "ثبت کاربر", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                da.disconnect();
                MessageBox.Show("تمام فیلد ها را پر کنید", "ثبت کاربر", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
