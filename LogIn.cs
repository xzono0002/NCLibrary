using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class LogIn : Form
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

        public LogIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void custombtn1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DashBoard dashBoard = new DashBoard();
            string username = UNText.Texts;
            string password = PassText.Texts;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass", db.getConnection());


            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;


            /*            passhash.verify(password);*/

            db.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                DataRow userRow = table.Rows[0];

                login_user.username = userRow["username"].ToString();
                login_user.id = Convert.ToInt32(userRow["id"]);
                login_user.studentNo = Convert.ToInt32(userRow["student_no"]);

                this.Hide();
                dashBoard.Show();
            }
            else
            {
                incorText.Visible = true;
            }

            db.closeConnection();
        }

        private void signUpBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void hidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (hidePass.Checked)
            {
                PassText.PasswordChar = false;
            }

            else
            {
                PassText.PasswordChar = true;
            }
        }

        private void exitBTN_MouseEnter(object sender, EventArgs e)
        {
            exitBTN.ForeColor = Color.White;
        }

        private void exitBTN_MouseLeave(object sender, EventArgs e)
        {
            exitBTN.ForeColor = Color.FromArgb(8, 31, 58);
        }
    }
}