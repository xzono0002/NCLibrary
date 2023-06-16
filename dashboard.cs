using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
        }

        private void libBTN_Click(object sender, EventArgs e)
        {
            nclib1.BringToFront();
        }



        private void dashBTN_Click(object sender, EventArgs e)
        {
            main_dash1.BringToFront();
        }

        private void outBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void borrowBTN_Click(object sender, EventArgs e)
        {
            book_request1.BringToFront();
        }
    }
}
