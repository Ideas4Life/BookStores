using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

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
        // вариант 2
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_BookStore.mdb;";

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
            string query = "SELECT [TitleBook],[PictureBook] FROM [ListBooks] WHERE [GenreBook] = @gen";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.Parameters.Add("gen", OleDbType.VarChar).Value = "Психология";

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // в цикле построчно читаем ответ от БД
            string panel = "panelBook";
            string textBox = "tBTitleBook";
            int i = 1;
            while (reader.Read())
            {
                Panel pn= tableBooks.Controls[panel+Convert.ToString(i)] as Panel;
                (pn.Controls[textBox + Convert.ToString(i++)] as TextBox).Text = reader[0].ToString();

                /*
                MemoryStream ms = new MemoryStream((Byte[])reader[1]);
                Image image1 = Image.FromStream(ms);
                pictureBook1.Image = image1;
                */
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Write(byteArrayIn, 0, byteArrayIn.Length);
            return Image.FromStream(ms, true);
        }

        private void Comiks_Click(object sender, EventArgs e)
        {
            genre.Text = "Комиксы,манга";
            //genre.Location = new Point(this.Size.Width - this.genre.Size.Width - 225, genre.Location.Y); 
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

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBook1_Click(object sender, EventArgs e)
        {

        }

        private void Жанры_Load(object sender, EventArgs e)
        {

        }
    }
}
