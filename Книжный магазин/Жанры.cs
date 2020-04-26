using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Жанры()
        {
            InitializeComponent();
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
    }
}
