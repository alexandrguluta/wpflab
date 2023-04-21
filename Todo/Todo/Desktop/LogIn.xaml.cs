using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            if (UserRepository.GetUser(Login.Text, Pass.Text) is UserModel)
            {
                var wind = new Window1();
                wind.Show();
                this.Close();
                UserRepository.CurrentUser = UserRepository.GetUser(Login.Text, Pass.Text);
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }          

        private void Button_Registration(object sender, RoutedEventArgs e)
        {
            var wind = new Registration();
            wind.Show();
            this.Close();
        }


        private void Button_Forgot_Password(object sender, RoutedEventArgs e)
        {
            var wind = new Registration();
            wind.Show();
            this.Close();
        }
    }
}
