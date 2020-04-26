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
    public partial class Вход : Form
    {
        Adress_dostav adress_dost;
        LoginRegistration loginRegistr;
        Жанры generes;
        PersonalRoom personRoom;
        Регистрация registration;
        главная main;
        zakaz Zakaz;

        public Вход()
        {
            InitializeComponent();
        }

        public void Initialize(Adress_dostav ad, LoginRegistration lr, Жанры gn, PersonalRoom pr, Регистрация rg, главная mn, zakaz z)
        {
            adress_dost = ad;
            loginRegistr = lr;
            generes = gn;
            personRoom = pr;
            registration = rg;
            main = mn;
            Zakaz = z;
        }

        private void Back_entrance_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (password_entrance.PasswordChar == '*')
                password_entrance.PasswordChar= '\0';
            else password_entrance.PasswordChar = '*';
        }

        private void Entrance_entrance_Click(object sender, EventArgs e)
        {
            if (login_entrance.Text == string.Empty || password_entrance.Text == string.Empty)
            {
                MessageBox.Show("Вы ввели не все данные!");
            }
            else
            {
                MessageBox.Show("Вы вошли с систему!");
               // bLogin = true;  //изменить когда подключим бд и сделаем авторизацию
                this.Hide();
              //  if (bLogin)
                 loginRegistr.Show();
            }
        }

        private void Registration_entrance_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration.Show();
        }

        private void Login_entrance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void Password_entrance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back)
            {
                return;
            }
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
    }
}
