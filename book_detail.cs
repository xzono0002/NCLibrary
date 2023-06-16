using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Library_Management_System
{
    public partial class book_detail : Form
    {

        MySqlCommand command;
        MySqlDataReader reader;
        private Label title;
        private Label author;
        private Label genre;
        private Label published;
        private Label publisher;
        private Label isbn;

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

        public book_detail()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void book_detail_Load(object sender, EventArgs e)
        {
            loadRecord();
        }

        public void loadRecord()
        {
            DB db = new DB();
            db.openConnection();
            command = new MySqlCommand("SELECT `img_drt`, `title`, `author`, `genre`, `publisher`, `yearpub`, `isbn` FROM `library`", db.getConnection());
            reader = command.ExecuteReader();
            reader.Read();

            long len = reader.GetBytes(0, 0, null, 0, 0);
            byte[] array = new byte[Convert.ToInt32(len) + 1];
            reader.GetBytes(0, 0, array, 0, Convert.ToInt32(len));
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            System.IO.MemoryStream ms = new System.IO.MemoryStream(array);
            pictureBox1.BackgroundImage = Image.FromStream(ms, true, true);
            pictureBox1.Tag = reader["img_drt"].ToString();

            title = new Label();
            title.Text = "TITLE: " + reader["title"].ToString().ToUpper();
            title.AutoSize = true;
            title.MaximumSize = new Size(735, 0);
            title.Font = new Font("Inter Black", 11);
            title.ForeColor = Color.Black;
            title.Location = new Point(254, 23);

            author = new Label();
            author.Text = "WRITTEN BY: " + reader["author"].ToString().ToUpper();
            author.AutoSize = true;
            author.MaximumSize = new Size(735, 0);
            author.Font = new Font("Inter SemiBold", 9);
            author.ForeColor = Color.Black;
            author.Location = new Point(254, 71);

            genre = new Label();
            genre.Text = "GENRE: " + reader["genre"].ToString().ToUpper();
            genre.AutoSize = true;
            genre.Size = new Size(735, 0);
            genre.Font = new Font("Inter SemiBold", 9);
            genre.ForeColor = Color.Black;
            genre.Location = new Point(254, 114);

            publisher = new Label();
            publisher.Text = "PUBLISHER: " + reader["publisher"].ToString().ToUpper();
            publisher.AutoSize = true;
            publisher.Size = new Size(735, 0);
            publisher.Font = new Font("Inter SemiBold", 9);
            publisher.ForeColor = Color.Black;
            publisher.Location = new Point(254, 157);

            published = new Label();
            published.Text = "PUBLISHED DATE: " + reader["yearpub"].ToString().ToUpper();
            published.AutoSize = true;
            published.Size = new Size(735, 0);
            published.Font = new Font("Inter SemiBold", 9);
            published.ForeColor = Color.Black;
            published.Location = new Point(254, 339);

            isbn = new Label();
            isbn.Text = "ISBN: " + reader["isbn"].ToString().ToUpper();
            isbn.AutoSize = true;
            isbn.Size = new Size(735, 0);
            isbn.Font = new Font("Inter SemiBold", 9);
            isbn.ForeColor = Color.Black;
            isbn.Location = new Point(254, 382);

            panel1.Controls.Add(title);
            panel1.Controls.Add(author);
            panel1.Controls.Add(genre);
            panel1.Controls.Add(published);
            panel1.Controls.Add(publisher);
            panel1.Controls.Add(isbn);

            reader.Close();
            db.closeConnection();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void siticoneButton1_Click(object sender, EventArgs e)
        {
            String tag = ((PictureBox)sender).Tag.ToString();

            DB dB = new DB();
            dB.openConnection();
            command = new MySqlCommand("INSERT INTO `user_borrow` (`borrower`, `book`) + VALUES (@isbn, @user) FROM `library` AND `users`" + dB.getConnection());
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                command.Parameters.Add("@isbn", MySqlDbType.VarChar).Value = isbn.Text;
                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = isbn.Tag;
            }
            reader.Close();
            dB.closeConnection();
        }
    }
}
