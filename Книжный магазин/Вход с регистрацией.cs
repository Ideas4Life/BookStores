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
    public partial class LoginRegistration : Form
    {
        Adress_dostav adress_dost;
        Жанры generes;
        PersonalRoom personRoom;
        Регистрация registration;
        главная main;
        zakaz zakaz;

        public LoginRegistration()
        {
            InitializeComponent();
        }
        public void Initialize(Adress_dostav ad, Жанры gn, PersonalRoom pr, Регистрация rg, главная mn, zakaz z)
        {
            adress_dost = ad;
            generes = gn;
            personRoom = pr;
            registration = rg;
            main = mn;
            zakaz = z;
        }

        private void Genres_entrance_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            generes.Show();
        }

        private void Personal_entrance_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            personRoom.Show();
        }
    }
}
