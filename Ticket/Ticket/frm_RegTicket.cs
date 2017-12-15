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
    public partial class frm_RegTicket : Form
    {
        public frm_RegTicket()
        {
            InitializeComponent();
        }

        private void btnRegTicketNow_Click(object sender, EventArgs e)
        {
            DataAccessLayer da = new DataAccessLayer();
            Customer co = new Customer();
            da.connect();
            if (txtName.Text != "" && txtFamily.Text != "" && txtPhone.Text != "")
            {
                try
                {
                    co.ADD(txtName.Text, txtFamily.Text, txtPhone.Text,frm_Login.UNAMEFAMILY);
                    da.disconnect();
                    MessageBox.Show("بلیط ثبت شد", "ثبت بلیط", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch (Exception er)
                {
                    da.disconnect();
                    MessageBox.Show("ثبت انجام نشد :\n" + er.ToString(), "ثبت بلیط", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                da.disconnect();
                MessageBox.Show("تمام فیلد ها را پر کنید", "ثبت بلیط", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void frm_RegTicket_Load(object sender, EventArgs e)
        {

        }
    }
    }

