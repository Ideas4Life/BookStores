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
    public partial class главная : Form
    {
        Adress_dostav adress_dost;
        LoginRegistration LoginRegistration;
        Жанры generes;
        PersonalRoom personRoom;
        Регистрация registration;
        zakaz Zakaz;

        public главная()
        {
            adress_dost = new Adress_dostav();
            LoginRegistration = new LoginRegistration();
            generes = new Жанры();
            personRoom = new PersonalRoom();
            registration = new Регистрация();
            Zakaz = new zakaz();

            generes.Initialize(adress_dost, LoginRegistration,  personRoom, registration, this, Zakaz);
            registration.Initialize(adress_dost, LoginRegistration,  generes, personRoom, this, Zakaz);
            LoginRegistration.Initialize(adress_dost, generes, personRoom, registration, this, Zakaz);
            personRoom.Initialize(adress_dost, LoginRegistration, generes, registration, this, Zakaz);
            adress_dost.Initialize(LoginRegistration, generes, personRoom, registration, this, Zakaz);
            Zakaz.Initialize(adress_dost, LoginRegistration, generes, personRoom, registration, this);

            InitializeComponent(); 
        }

        private void genres_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            generes.Show();
            generes.genre.Text = "Жанры";
            //generes.genre.Location = new Point(this.Size.Width - generes.genre.Size.Width - 290, generes.genre.Location.Y); 
        }

        private void Reg_window_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration.Show();
        }

        private void Главная_FormClosed(object sender, FormClosedEventArgs e)
        {
            adress_dost.Close();
            LoginRegistration.Close();   
            generes.Close();
            personRoom.Close();
            registration.Close();
            Zakaz.Close();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
