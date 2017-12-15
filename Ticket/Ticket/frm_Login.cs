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
    public partial class frm_Login : Form
    {
        public static string UNAMEFAMILY = "", UID = "", UPASSWORD = "";
        DataAccessLayer da = new DataAccessLayer();
        User us = new User();

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        public frm_Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            da.connect();
            DataTable user = us.selectUserInfo(txtUsername.Text);
            if (user.Rows.Count != 0)
            {
                UID = user.Rows[0].Field<string>(0);
                UPASSWORD = user.Rows[0].Field<string>(1);
                UNAMEFAMILY = user.Rows[0].Field<string>(2);
            }
            da.disconnect();
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtUsername.Text == UID && txtPassword.Text == UPASSWORD)
            {
                txtUsername.Clear();
                txtPassword.Clear();
                this.Hide();
                frm_Main fm = new frm_Main();
                fm.ShowDialog();
            }
            else
            {
                lblError.Text = "نام کاربری و یا رمز عبور اشتباه است!";
            }
        }
    }

}

        
    

