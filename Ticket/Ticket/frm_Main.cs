using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ShowTickets fst = new frm_ShowTickets();
            fst.ShowDialog();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void btnRegUser_Click(object sender, EventArgs e)
        {
            frm_RegUser fru = new frm_RegUser();
            fru.ShowDialog();
        }

        private void btnRegTicket_Click(object sender, EventArgs e)
        {
            frm_RegTicket frt = new frm_RegTicket();
            frt.ShowDialog();
        }
        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
