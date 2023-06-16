using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Library_Management_System
{
    public partial class SignUp : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public SignUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createBTN_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`firstname`, `surname`, `college`," +
                "`course`, `year_level`, `student_no`, `email_add`, `username`, `password`) " +
                "VALUES (@fn, @ln, @univ, @crs, @yl, @sn, @email, @usn, @pass)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textFirstName.Texts;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textLastName.Texts;
            command.Parameters.Add("@univ", MySqlDbType.VarChar).Value = textSchool.Texts;
            command.Parameters.Add("@crs", MySqlDbType.VarChar).Value = textCourse.Texts;
            command.Parameters.Add("@yl", MySqlDbType.VarChar).Value = textYearLevel.Text;
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = textSN.Texts;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textEmail.Texts;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textUN.Texts;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = inputPass.Texts;

            /*passhash.hashPassword(inputPass.Texts)*/

            db.openConnection();

            if (checkTextBoxValues())
            {
                if (inputPass.Texts.Equals(confirmPass.Texts))
                {
                    if (checkUSN())
                    {
                        MessageBox.Show("This user already exist!");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("ACCOUNT CREATED");
                        }

                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Password doesn't match. Please confirm your password.");
                }
            }

            else
            {
                MessageBox.Show("Fill out the form, first.");
            }

            db.closeConnection();
        }

        private void hidePass1_CheckedChanged(object sender, EventArgs e)
        {
            if (hidePass1.Checked)
            {
                inputPass.PasswordChar = false;
            }

            else
            {
                inputPass.PasswordChar = true;
            }
        }

        private void hidePass2_CheckedChanged(object sender, EventArgs e)
        {
            if (hidePass2.Checked) confirmPass.PasswordChar = false;

            else confirmPass.PasswordChar = true;
        }

        public Boolean checkUSN()
        {
            DB db = new DB();
            string username = textUN.Texts;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn",
                db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public Boolean checkTextBoxValues()
        {
            string fname = textFirstName.Text;
            string lname = textLastName.Text;
            string school = textSchool.Text;
            string course = textCourse.Text;
            string yearlevel = textYearLevel.Text;
            string email = textEmail.Text;
            string username = textUN.Texts;
            string pass = inputPass.Texts;

            if (fname.Equals("") || lname.Equals("") || school.Equals("") || course.Equals("")
                || yearlevel.Equals("") || email.Equals("")
                || username.Equals("") || pass.Equals("")) return true;

            else return false;
        }

        private void exitBTN_MouseEnter(object sender, EventArgs e)
        {
            exitBTN.ForeColor = Color.White;
        }

        private void exitBTN_MouseLeave(object sender, EventArgs e)
        {
            exitBTN.ForeColor = Color.FromArgb(8, 31, 58);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
