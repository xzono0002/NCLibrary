using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Siticone.Desktop.UI.Designer;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Image = System.Drawing.Image;

namespace Library_Management_System
{
    public partial class nclib : UserControl
    {
        MySqlCommand command;
        MySqlDataReader reader;
        private Panel panel;
        private PictureBox pictureBox;
        private Label title;
        private Label author;
        private Label genre;
        private Label published;
        private Button button;

        public nclib()
        {
            InitializeComponent();
        }

        private void nclib_Load(object sender, EventArgs e)
        {

            loadRecord();
        }

        public void loadRecord()
        {
            DB db = new DB();
            db.openConnection();
            command = new MySqlCommand("SELECT `img_drt`, `title`, `author`, `genre`, `yearpub`, `id` FROM `library`", db.getConnection());
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                long len = reader.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[Convert.ToInt32(len) + 1];
                reader.GetBytes(0, 0, array, 0 , Convert.ToInt32(len));
                pictureBox = new PictureBox();
                pictureBox.Width = 209;
                pictureBox.Height = 317;
                pictureBox.Location = new Point(12, 14);
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;

                System.IO.MemoryStream ms = new System.IO.MemoryStream(array);
                pictureBox.BackgroundImage = Image.FromStream(ms, true, true);

                panel = new Panel();
                panel.Location = new Point(25, 29);
                panel.Width = 551;
                panel.Height = 346;
                panel.Margin = new Padding(25, 29, 70, 56);
                panel.BackColor = Color.FromArgb(0, 166, 251);

                title = new Label();
                title.Text = reader["title"].ToString().ToUpper();
                title.AutoSize = true;
                title.MaximumSize = new Size(267, 87);
                title.Font = new Font("Inter Black", 11);
                title.ForeColor = Color.Black;
                title.Location = new Point(254, 14);
                
                author = new Label();
                author.Text = "BY: " + reader["author"].ToString().ToUpper();
                author.AutoSize = true;
                author.MaximumSize = new Size(267, 45);
                author.Font = new Font("Inter SemiBold", 9);
                author.ForeColor = Color.Black;
                author.Location = new Point(254, 119);

                genre = new Label();
                genre.Text = "GENRE: " + reader["genre"].ToString().ToUpper();
                genre.Size = new Size(284, 72);
                genre.Font = new Font("Inter SemiBold", 9);
                genre.ForeColor = Color.Black;
                genre.Location = new Point(254, 165);

                published = new Label();
                published.Text = "YEAR PUBLISHED: " + reader["yearpub"].ToString().ToUpper();
                published.Size = new Size(284, 24);
                published.Font = new Font("Inter SemiBold", 9);
                published.ForeColor = Color.Black;
                published.Location = new Point(254, 239);

                button = new Button();
                button.Text = "REQUEST BOOK";
                button.Font = new Font("inter black", 9);
                button.BackColor = Color.FromArgb(8, 31, 58);
                button.Size = new Size(209,45);
                button.ForeColor= Color.White;
                button.Location = new Point(254, 286);
                button.FlatStyle= FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Tag = reader["id"];

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(title);
                panel.Controls.Add(author);
                panel.Controls.Add(genre);
                panel.Controls.Add(published);
                panel.Controls.Add(button);
                flowLayout.Controls.Add(panel);

                button.Click += new EventHandler(OnClick);
            }
            reader.Close();
            db.closeConnection();
        }

        public void OnClick(object sender, EventArgs e)
        {

            DB dB = new DB();
            int book = Convert.ToInt32(((Button)sender).Tag);

            dB.openConnection();

            string query = "INSERT INTO `user_borrow`(`borrower`, `book`, `borrow_date`) VALUES (@ub, @bb, @bd)";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            command = new MySqlCommand(query, dB.getConnection());

            adapter.SelectCommand = command;

            command.Parameters.AddWithValue("@ub", login_user.id);
            command.Parameters.Add("@bb", MySqlDbType.Int32).Value = book;
            command.Parameters.AddWithValue("@bd", DateTime.Now );

            if (checkBook(book))
            {
                MessageBox.Show("This book already exist!");
            }

            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("BOOK REQUESTED!");
                }

                else
                {
                    MessageBox.Show("ERROR");
                }
            }

            dB.closeConnection();
        }

        public Boolean checkBook(int bookID)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user_borrow` WHERE `book` = @bID AND `borrower` = @ub" ,
                db.getConnection());

            command.Parameters.AddWithValue("@bID", bookID);
            command.Parameters.AddWithValue("@ub", login_user.id);

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0) return true;
            else return false;
        }
    }
}
