using MySql.Data.MySqlClient;
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
    public partial class book_request : UserControl
    {
        MySqlCommand command;
        MySqlDataReader reader;
        private Panel panel;
        private PictureBox pictureBox;
        private Label title;
        private Label author;
        private Label genre;
        private Label published;
        private Label isbn;
        private Label publisher;
        private Label borrow_date;
        private Label description;

        public book_request()
        {
            InitializeComponent();
        }

        private void flowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void book_request_Load(object sender, EventArgs e)
        {
            loadRecord();
        }

        public void loadRecord()
        {
            DB db = new DB();

            db.openConnection();
            String query = "SELECT a.img_drt, a.title, a.author, a.genre, a.publisher, a.yearpub, a.isbn, a.description, b.borrow_date FROM library a INNER JOIN user_borrow b ON a.id = b.book WHERE b.borrower = @user ";

            command = new MySqlCommand(query, db.getConnection()) ;
            command.Parameters.AddWithValue("@user", login_user.id);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                long len = reader.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[Convert.ToInt32(len) + 1];
                reader.GetBytes(0, 0, array, 0, Convert.ToInt32(len));
                pictureBox = new PictureBox();
                pictureBox.Width = 209;
                pictureBox.Height = 324;
                pictureBox.Location = new Point(12, 14);
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(array);
                pictureBox.BackgroundImage = Image.FromStream(ms, true, true);

                panel = new Panel();
                panel.Location = new Point(31, 20);
                panel.Width = 1263;
                panel.Height = 352;
                panel.Margin = new Padding(25, 29, 31, 56);
                panel.BackColor = Color.FromArgb(0, 166, 251);

                title = new Label();
                title.Text = reader["title"].ToString().ToUpper();
                title.AutoSize = true;
                title.MaximumSize = new Size(997, 29);
                title.Font = new Font("Inter Black", 11);
                title.ForeColor = Color.Black;
                title.Location = new Point(254, 14);

                author = new Label();
                author.Text = "BY: " + reader["author"].ToString().ToUpper();
                author.AutoSize = true;
                author.MaximumSize = new Size(997, 24);
                author.Font = new Font("Inter SemiBold", 9);
                author.ForeColor = Color.Black;
                author.Location = new Point(254, 62);

                genre = new Label();
                genre.Text = "GENRE: " + reader["genre"].ToString().ToUpper();
                genre.Size = new Size(997, 24);
                genre.Font = new Font("Inter SemiBold", 9);
                genre.ForeColor = Color.Black;
                genre.Location = new Point(254, 98);

                publisher = new Label();
                publisher.Text = "PUBLISHER: " + reader["publisher"].ToString().ToUpper();
                publisher.Size = new Size(997, 24);
                publisher.Font = new Font("Inter SemiBold", 9);
                publisher.ForeColor = Color.Black;
                publisher.Location = new Point(254, 134);
                
                description = new Label();
                description.Text = reader["description"].ToString().ToUpper();
                description.Size = new Size(997, 100);
                description.Font = new Font("Inter SemiBold", 9);
                description.ForeColor = Color.Black;
                description.Location = new Point(254, 170);

                published = new Label();
                published.Text = "YEAR PUBLISHED: " + reader["yearpub"].ToString().ToUpper();
                published.Size = new Size(260, 24);
                published.Font = new Font("Inter SemiBold", 9);
                published.ForeColor = Color.Black;
                published.Location = new Point(254, 278);

                isbn = new Label();
                isbn.Text = "ISBN-13: " + reader["isbn"].ToString().ToUpper();
                isbn.Size = new Size(305, 24);
                isbn.Font = new Font("Inter SemiBold", 9);
                isbn.ForeColor = Color.Black;
                isbn.Location = new Point(711, 273);

                borrow_date = new Label();
                borrow_date.Text = "Borrowed on: " + reader["borrow_date"].ToString().ToUpper();
                borrow_date.Size = new Size(997, 24);
                borrow_date.Font = new Font("Inter SemiBold", 9);
                borrow_date.ForeColor = Color.Black;
                borrow_date.Location = new Point(254, 314);

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(title);
                panel.Controls.Add(author);
                panel.Controls.Add(genre);
                panel.Controls.Add(publisher);
                panel.Controls.Add(isbn);
                panel.Controls.Add(published);
                panel.Controls.Add(description);
                panel.Controls.Add(borrow_date);
                flowLayout.Controls.Add(panel);
            }
            reader.Close();
            db.closeConnection();
        }
    }
}

