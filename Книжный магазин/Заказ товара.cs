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
    public partial class zakaz : Form
    {
        Adress_dostav adress_dost;
        LoginRegistration LoginRegistration;
        Жанры generes;
        PersonalRoom personRoom;
        Регистрация registration;
        главная main; 

        public zakaz()
        {
            InitializeComponent();
        }

        public void Initialize(Adress_dostav ad, LoginRegistration lr, Жанры gn, PersonalRoom pr, Регистрация rg, главная mn)
        {
            adress_dost = ad;
            LoginRegistration = lr; 
            generes = gn;
            personRoom = pr;
            registration = rg;
            main = mn;
        }

        private void Back_personal_address_Click(object sender, EventArgs e)
        {
            this.Hide();
            personRoom.Show();
        }

        private void Savezac_Click(object sender, EventArgs e)
        {
            if (numberzac.Text == string.Empty || colzac.Text == string.Empty )
            {
                MessageBox.Show("Вы ввели не все данные!");
            }
            else
            {
                this.Hide();
                adress_dost.Show();
            }
        }

        private void Numberzac_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Colzac_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
