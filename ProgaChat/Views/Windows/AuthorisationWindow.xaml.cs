using ProgaChat.AppData;
using ProgaChat.Model;
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

namespace ProgaChat.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorisationWindow.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window
    {
        public AuthorisationWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text != "" && PasswordTb.Password != "")
            {
                if (AuthorisationHelper.Authorise(LoginTb.Text, PasswordTb.Password) == true)
                {
                    UserWindow userWindow = new UserWindow();
                    userWindow.Show();
                    Close();
                }
            }
            else
            {
                MessageBoxHelper.Error("Не все поля для ввода были заполнены.");
            }
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            Close();
        }
    }
}
