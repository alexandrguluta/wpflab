﻿using System;
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
using Entities;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            Manager.window=this;
        }
        //Validator.PassValid(Passwordbox) && Validator.EmailValid(Emailbox) && Validator.RepeatPassValid(Repeatpasswordbox, Passwordbox) && Validator.NameValid(Usernamebpx))
        private void Button_Register(object sender, RoutedEventArgs e)
        {
            if (Validator.PassValid(Passwordbox) && Validator.EmailValid(Emailbox) && Validator.RepeatPassValid(Repeatpasswordbox, Passwordbox) && Validator.NameValid(Usernamebpx))
            {

                if (UserRepository.UserAdd(Emailbox.Text, Passwordbox.Text, Usernamebpx.Text))
                {
                    MessageBox.Show("Пользователь с таким логином уже существует. Попробуйте другой.");
                }
                else
                {
                    var wind = new LogIn();
                    wind.Show();
                    this.Close();
                }
            }
            else if (!Validator.PassValid(Passwordbox))
            {
                MessageBox.Show("Пароль должен состаять более чем из 6 символов!");
            } 
            else if (!Validator.EmailValid(Emailbox))
            {
                MessageBox.Show("Неверный адрес E-mail");
            }
            else if (!Validator.RepeatPassValid(Repeatpasswordbox, Passwordbox))
            {
                MessageBox.Show("Пароли должны совпадать!");
            }
            else if (!Validator.NameValid(Usernamebpx))
            {
                MessageBox.Show("Имя пользователя должно состоять более чем из 3 символов!");
            }
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
           
            var wind = new LogIn();
            wind.Show();
            this.Close();
        }
    }
}
    
