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
        AddBooks addBook;

        ToolTip t;

        // строка подключения к MS Access
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBase\\DB_BookStore.mdb;";

        // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
        public OleDbConnection myConnection;

        public Жанры()
        {
            InitializeComponent();

            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            t = new ToolTip();

            // открываем соединение с БД
            myConnection.Open();
            writeTable("Художественная литература");
        }

        public void Initialize(Adress_dostav ad, LoginRegistration lr,  PersonalRoom pr, Регистрация rg, главная mn, zakaz z, AddBooks ab)
        {
            adress_dost = ad;
            loginRegistr = lr;
            personRoom = pr;
            registration = rg;
            main = mn;
            Zakaz = z;
            addBook = ab;
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

            writeTable("Художественная литература");
        }

        private void Nehud_literature_Click(object sender, EventArgs e)
        {
            genre.Text = "Психология";
            //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 100, genre.Location.Y);

            writeTable("Психология");
        }
       

        private void Comiks_Click(object sender, EventArgs e)
        {
            genre.Text = "Комиксы,манга";
            //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 225, genre.Location.Y);

            writeTable("Комиксы, манга");
        }

        private void Ycheb_literature_Click(object sender, EventArgs e)
        {
            genre.Text = "Учебная литература";
            //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 200, genre.Location.Y);

            writeTable("Учебная литература");
        }

        private void Child_literature_Click(object sender, EventArgs e)
        {
            genre.Text = "Книги для детей";
            //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 215, genre.Location.Y);

            writeTable("Книги для детей");
        }

        private void writeTable(string str)
        {
            //очистка таблицы
            for (int i = 1; i < tableBooks.ColumnCount + 1; i++)
            {
                Panel pnl = tableBooks.Controls["panelBook" + Convert.ToString(i)] as Panel;
                (pnl.Controls["tBTitleBook" + Convert.ToString(i)] as TextBox).Text = "";
                (pnl.Controls["pictureBook" + Convert.ToString(i)] as PictureBox).Image = null;
                
                if (i > 6)
                {
                    tableBooks.Controls.Remove(pnl);
                    tableBooks.AutoScroll = false;
                    tableBooks.ColumnCount = 6;
                    tableBooks.Size = new Size(810, 220);
                }
            }

            // текст запроса
            string query = "SELECT * FROM [ListBooks] WHERE [GenreBook] = @gen";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            //Устанавливаем параметр для запроса
            command.Parameters.Add("gen", OleDbType.VarChar).Value = str;

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // в цикле построчно читаем ответ от БД
            List<DataBase> listDataBase = new List<DataBase>();
            while (reader.Read())
            {
                listDataBase.Add(new DataBase(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString())));
            }

            int count = listDataBase.Count();

            //цикл по обработке ячеек таблицы, добавлении в них книг
            for(int i = 1; i < count + 1; i++)
            {
                Panel pnl;
                TextBox tb;
                PictureBox pb;

                //добавление ячеек в таблицу если книг больше 6
                if (i == 7)
                {
                    tableBooks.RowCount = 1;
                    tableBooks.ColumnCount += count - 6;
                    tableBooks.AutoScroll = true;
                    tableBooks.Size = new Size(810, 240);
                }
                if (i<7)
                {
                    pnl = tableBooks.Controls["panelBook" + Convert.ToString(i)] as Panel;
                    tb = (pnl.Controls["tBTitleBook" + Convert.ToString(i)] as TextBox);
                    pb = (pnl.Controls["pictureBook" + Convert.ToString(i)] as PictureBox);
                }
                else
                {
                    //Добавление панели
                    pnl = new Panel();
                    tableBooks.Controls.Add(pnl, i, 0);

                    //добавление текстБокса с нужным текстом
                    tb = new TextBox();
                    pnl.Controls.Add(tb);

                    //Добавление pictureBox
                    pb = new PictureBox();
                    pnl.Controls.Add(pb);
                }
                //установление свойств для Panel
                tableBooks.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
                pnl.BackColor = Color.FromArgb(224, 224, 224);
                pnl.BorderStyle = BorderStyle.Fixed3D;
                pnl.Dock = DockStyle.Fill;
                pnl.Name = "panelBook" + Convert.ToString(i);
                pnl.Size = new Size(129, 215);

                //установление свойств и содержания для textBox
                tb.ReadOnly = true;
                tb.Multiline = true;
                tb.Name = "tBTitleBook" + Convert.ToString(i);
                tb.BackColor = Color.FromArgb(224, 224, 224);
                tb.Text = listDataBase[i - 1].title;
                t.SetToolTip(tb, listDataBase[i - 1].title);
                tb.Font = new Font("Microsoft Sans Serif", 12);
                tb.Dock = DockStyle.Bottom;
                tb.Size = new Size(tb.Width, 50);
                tb.TextAlign = HorizontalAlignment.Center;

                //установление свойств и содержания для pictureBox
                pb.Name = "pictureBook" + Convert.ToString(i);
                pb.Size = new Size(pb.Width, pnl.Height - tb.Height);
                pb.Dock = DockStyle.Top;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                t.SetToolTip(pb, "кликните для получения подробного описания");
                Object rM = Resources.ResourceManager.GetObject(listDataBase[i - 1].author);
                pb.Image = (Image)rM;

                //добавлениие события нажатия на PictureBox
                pb.Click += pictureBook_Click;
            }

        }

        private void pictureBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите один из вариантов","Сообщение");
        }

        private void addBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            //if (login.bLogin)
            //    loginRegistr.Show();
            addBook.Show();
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
