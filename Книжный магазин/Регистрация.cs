using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Книжный_магазин
{
    public partial class Регистрация : Form
    {
        Adress_dostav adress_dost;
        LoginRegistration LoginRegistration;
        Жанры generes;
        PersonalRoom personRoom;
        главная main;
        zakaz Zakaz;

        public Регистрация()
        {
            InitializeComponent();
        }
        public void Initialize(Adress_dostav ad, LoginRegistration lr, Жанры gn, PersonalRoom pr, главная mn, zakaz z)
        {
            adress_dost = ad;
            LoginRegistration = lr;     
            generes = gn;
            personRoom = pr;
            main = mn;
            Zakaz = z;
        }

        private void Back_regisstration_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if (phoneTextBox.Text == string.Empty || nameTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty)
            {
                MessageBox.Show("Вы ввели не все данные!");  
            }
            else
            {
                MessageBox.Show("Вы вошли в систему!");
                this.Hide();
                LoginRegistration.Show();
            }

        }

        private void Eye_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*')
                passwordTextBox.PasswordChar = '\0';
            else passwordTextBox.PasswordChar = '*';
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
// string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Avt_reg;Integrated Security=True";
            //SqlConnection connection = new SqlConnection(connectionString);

            //using (connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand addUserCmd = new SqlCommand("Insert into Table1 (Phone,Name,Password) VALUES (234,'Polina','Pol2')", connection);
            //    addUserCmd.CommandText = "Insert into Table1 (Phone,Name,Password) VALUES (@Phone, @Name, @Password)";
            //    addUserCmd.Parameters.AddWithValue("@Phone", Phone.Text);
            //    addUserCmd.Parameters.AddWithValue("@Name", name.Text);
            //    addUserCmd.Parameters.AddWithValue("@Password", password_regisstration.Text);
            //    addUserCmd.ExecuteNonQuery();
            //    connection.Close();
            //}
