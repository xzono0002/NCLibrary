using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Siticone.Desktop.UI.Native.WinApi;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Library_Management_System
{
    public partial class main_dash : UserControl
    {
        public main_dash()
        {
            InitializeComponent();
        }

        private void main_dash_Load(object sender, EventArgs e)
        {
            onFormLoad();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void onFormLoad()
        {
            helloUser.Text = "H E L L O  " + login_user.username.ToUpper();
            studentNo.Text = "S T U D E N T  N U M B E R: " + login_user.studentNo.ToString();
            studentNo.Location = new Point(865, 181);

            DB dB = new DB();
            dB.openConnection();
            string query = "SELECT COUNT(book) FROM user_borrow WHERE borrower = @ub";
            MySqlCommand command = new MySqlCommand(query, dB.getConnection());
            command.Parameters.AddWithValue("@ub", login_user.id);
            Int32 count1 = Convert.ToInt32(command.ExecuteScalar());
            borrowLabel.Text = count1.ToString();

            dB.closeConnection();
        }
    }
}
