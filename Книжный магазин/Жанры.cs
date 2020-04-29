using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
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

            int count=listDataBase.Count();
            if (count > 6 && tableBooks.ColumnCount!=count)
            {
                
                for (int f = 6; f < count; f++)
                {
                    tableBooks.RowCount = 1;
                    tableBooks.ColumnCount += count-6;
                    tableBooks.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
                    Panel pnl = new Panel();
                    pnl.BackColor = Color.FromArgb(224, 224, 224);
                    pnl.BorderStyle = BorderStyle.Fixed3D;
                    pnl.Dock = DockStyle.Fill;
                    pnl.Name = "panelBook"+Convert.ToString(f+1);
                    pnl.Size = new Size(129,172);
                    
                    TextBox tb = new TextBox();
                    tb.ReadOnly = true;
                    tb.Name = "tBTitleBook" + Convert.ToString(f + 1);
                    tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16);
                    tb.BackColor = Color.FromArgb(224, 224, 224);
                    tb.Dock = DockStyle.Bottom;
                    pnl.Controls.Add(tb);
                    tableBooks.Controls.Add(pnl, f, 0);
                }
                tableBooks.AutoScroll = true;
                tableBooks.Size = new Size(810, 200);
            }
            string panel = "panelBook";
            string textBox = "tBTitleBook";
            for (int i=1; i<count+1; i++)
            {
                Panel pn = tableBooks.Controls[panel + Convert.ToString(i)] as Panel;
                (pn.Controls[textBox + Convert.ToString(i)] as TextBox).Text = listDataBase[i-1].title;

                Object rm = Properties.Resources.ResourceManager.GetObject("adad-awd");
                //Bitmap myImage = (Bitmap)rm;
                //pictureBook1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBook1.Image = (Image) rm;
            }

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
