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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private static ProgaChatDbEntities _context;
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User newUser = new User()
                {
                    ProgrammingLanguage = LanguageCmb.SelectedItem as ProgrammingLanguage,
                    Email = eEmailTb.Text,
                    Login = LoginTb.Text,
                    Password = PasswordTb.Password,
                    Photo = PhotoTb.Text
                };
                _context.User.Add(newUser);
                _context.SaveChanges();
                MessageBoxHelper.Information("Новый пользователь зарегистрирован.");
                AuthorisationWindow authorisation = new AuthorisationWindow();
                authorisation.ShowDialog();
                Close();
            }
            catch (InvalidOperationException)
            {
                MessageBoxHelper.Error("Не все поля для ввода были заполнены");
            }
        }

        private void AuthorisationHL_Click(object sender, RoutedEventArgs e)
        {
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.Show();
            Close();
        }
    }
}
