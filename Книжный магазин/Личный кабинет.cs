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
    public partial class PersonalRoom : Form
    {

        Adress_dostav adress_dost;
        LoginRegistration loginRegistr;
        Жанры generes;
        Регистрация registration;
        главная main;
        zakaz Zakaz;
        public PersonalRoom()
        {
            InitializeComponent();
        }
        public void Initialize(Adress_dostav ad, LoginRegistration lr, Жанры gn, Регистрация rg, главная mn, zakaz z)
        {
            adress_dost = ad;
            loginRegistr = lr; 
            generes = gn;
            registration = rg;
            main = mn;
            Zakaz = z;
        }

        private void Home_address_Click(object sender, EventArgs e)
        {
            this.Hide();
            adress_dost.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void Back_peronal_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginRegistr.Show();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zakaz.Show();
        }
    }
}
