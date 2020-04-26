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
    public partial class Adress_dostav : Form
    {
        LoginRegistration LoginRegistration;
       
        Жанры generes;
        PersonalRoom personRoom;
        Регистрация registration;
        главная main;
        zakaz Zakaz;

        public Adress_dostav()
        {
            InitializeComponent();
        }
        public void Initialize(LoginRegistration lr,  Жанры gn, PersonalRoom pr, Регистрация rg, главная mn, zakaz z)
        {
            LoginRegistration = lr;
            generes = gn;
            personRoom = pr;
            registration = rg;
            main = mn;
            Zakaz = z;
        }

        private void Back_personal_address_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zakaz.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (number.Text == string.Empty || textBox2.Text == string.Empty || textBox1.Text == string.Empty )
            {
                MessageBox.Show("Вы ввели не все данные!");
            }
            else
            {
                MessageBox.Show("Товар заказан!");
                this.Hide();
                personRoom.Show();
            }
           
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
