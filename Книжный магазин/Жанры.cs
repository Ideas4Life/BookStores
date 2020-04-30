using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Книжный_магазин.Properties;

namespace Книжный_магазин
{
    public partial class Жанры : Form
    {
        Adress_dostav adress_dost;
        LoginRegistration loginRegistr;
        PersonalRoom personRoom;
        Регистрация registration;
        главная main;
        zakaz Zakaz;


        // строка подключения к MS Access
        // вариант 1
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBase\\DB_BookStore.mdb;";


        // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
        public OleDbConnection myConnection;

        public Жанры()
        {
            InitializeComponent();

            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();
        }

        public void Initialize(Adress_dostav ad, LoginRegistration lr,  PersonalRoom pr, Регистрация rg, главная mn, zakaz z)
        {
            adress_dost = ad;
            loginRegistr = lr;
            personRoom = pr;
            registration = rg;
            main = mn;
            Zakaz = z;
        }
        private void Back_genres_Click(object sender, EventArgs e)
        {
            this.Hide();
            //if (login.bLogin)
            //    loginRegistr.Show();
             main.Show();
        }

        private void Hud_literature_Click_1(object sender, EventArgs e)
        {
            genre.Text = "Художественная литература";
            //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 120, genre.Location.Y);
        }

        private void Nehud_literature_Click(object sender, EventArgs e)
        {
            genre.Text = "Психология";
            //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 100, genre.Location.Y);

            // текст запроса
            string query = "SELECT * FROM [ListBooks] WHERE [GenreBook] = @gen";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.Parameters.Add("gen", OleDbType.VarChar).Value = "Психология";

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // в цикле построчно читаем ответ от БД
            List<DataBase> listDataBase = new List<DataBase>();
            while (reader.Read())
            {
                listDataBase.Add(new DataBase(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString())));
            }
            writeTable(listDataBase);
        }
       

        private void Comiks_Click(object sender, EventArgs e)
        {
            genre.Text = "Комиксы,манга";
            //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 225, genre.Location.Y); 
            // текст запроса
            string query = "SELECT * FROM [ListBooks] WHERE [GenreBook] = @gen";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.Parameters.Add("gen", OleDbType.VarChar).Value = "Комиксы, манга";

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // в цикле построчно читаем ответ от БД
            List<DataBase> listDataBase = new List<DataBase>();
            while (reader.Read())
            {
                listDataBase.Add(new DataBase(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString())));
            }
            writeTable(listDataBase);
        }

        private void Ycheb_literature_Click(object sender, EventArgs e)
        {
            genre.Text = "Учебная литература";
            //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 200, genre.Location.Y);
        }

        private void Child_literature_Click(object sender, EventArgs e)
        {
            genre.Text = "Книги для детей";
           //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 215, genre.Location.Y);
        }

        private void writeTable(List<DataBase> lDB)
        {
            //tableBooks.RowStyles.Clear();
            //очистка таблицы
            for (int i = 1; i < tableBooks.ColumnCount + 1; i++)
            {
                Panel pn = tableBooks.Controls["panelBook" + Convert.ToString(i)] as Panel;
                (pn.Controls["tBTitleBook" + Convert.ToString(i)] as TextBox).Text = "";
                (pn.Controls["pictureBook" + Convert.ToString(i)] as PictureBox).Image = null;
                
                if (i > 6)
                {
                    tableBooks.Controls.Remove(pn);
                    tableBooks.AutoScroll = false;
                    tableBooks.ColumnCount = 6;
                    tableBooks.Size = new Size(810, 220);
                }
            }

            List<DataBase> listDataBase = lDB;
            int count = listDataBase.Count();

            if (count > 6 && tableBooks.ColumnCount != count)
            {

                for (int f = 6; f < count; f++)
                {
                    tableBooks.RowCount = 1;
                    tableBooks.ColumnCount += count - 6;
                    tableBooks.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
                    Panel pnl = new Panel();
                    pnl.BackColor = Color.FromArgb(224, 224, 224);
                    pnl.BorderStyle = BorderStyle.Fixed3D;
                    pnl.Dock = DockStyle.Fill;
                    pnl.Name = "panelBook" + Convert.ToString(f + 1);
                    pnl.Size = new Size(129, 215);
                    tableBooks.Controls.Add(pnl, f, 0);

                    TextBox tb = new TextBox();
                    tb.ReadOnly = true;
                    tb.Name = "tBTitleBook" + Convert.ToString(f + 1);
                    tb.BackColor = Color.FromArgb(224, 224, 224);
                    tb.Dock = DockStyle.Bottom;
                    pnl.Controls.Add(tb);


                    PictureBox pb = new PictureBox();
                    pb.Name = "pictureBook" + Convert.ToString(f + 1);
                    pb.Dock = DockStyle.Top;
                    pnl.Controls.Add(pb);
                }
                tableBooks.AutoScroll = true;
                tableBooks.Size = new Size(810, 240);
            }

            for (int i = 1; i < count + 1; i++)
            {
                Panel pn = tableBooks.Controls["panelBook" + Convert.ToString(i)] as Panel;

                var textBx = (pn.Controls["tBTitleBook" + Convert.ToString(i)] as TextBox);
                textBx.Text = listDataBase[i - 1].title;
                textBx.Font = new Font("Microsoft Sans Serif", 12);
                textBx.Multiline = true;
                textBx.Size = new Size(textBx.Width, 50);
                textBx.TextAlign = HorizontalAlignment.Center;

                //добавление правльной картинки не получается
                var pictBox = (pn.Controls["pictureBook" + Convert.ToString(i)] as PictureBox);
                pictBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictBox.Size = new Size(pictBox.Width, pn.Height - textBx.Height);
                Object rm = Resources.ResourceManager.GetObject(listDataBase[i - 1].author);
                pictBox.Image = (Image)rm;

                //добавлениие события нажатия на фотографии
                pictBox.Click += pictureBook_Click;
            }
        }

        private void pictureBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите один из вариантов", "Сообщение");
        }
    }
    public class DataBase
    {
        public string title, author, discription;
        public int price;
        public DataBase(string name, string authr, string discr, int prc)
        {
            title=name;
            author = authr;
            discription = discr;
            price = prc;
        }
    }

}
