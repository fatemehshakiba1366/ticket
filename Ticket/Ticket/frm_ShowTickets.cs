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
    public partial class frm_ShowTickets : Form
    {
        private bool flagCustomers = false;
        public frm_ShowTickets()
        {
            InitializeComponent();
        }

        private void btnShowTickets_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer da = new DataAccessLayer();
                Customer co = new Customer();
                da.connect();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = co.select();
                flagCustomers = true;
            }
            catch (Exception er)
            {
                MessageBox.Show("جدول بروزرسانی نشد\n" + er.ToString(), "مسافران و کاربران", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flagCustomers)
            {
                lblID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                lblName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lblFamily.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                lblPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                lblUserNameFamily.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();



            }
        }

        private void frm_ShowTickets_Load(object sender, EventArgs e)
        {

        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            lblFamily.Text = "";
            lblID.Text = "";
            lblName.Text = "";
            lblPhone.Text = "";
            lblUserNameFamily.Text = "";
            try
            {
                DataAccessLayer da = new DataAccessLayer();
                User us = new User();
                da.connect();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = us.select();
                flagCustomers = false;
            }
            catch (Exception er)
            {
                MessageBox.Show("جدول بروزرسانی نشد\n" + er.ToString(), "مسافران و کاربران", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
       
    }
