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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgaChat.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        private static ProgaChatDbEntities _context = App.GetContext();
        private static User _selectedUser;
        public ProfilePage(User selectedUser)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
            UserGrid.DataContext = selectedUser;
            PasswordTb.Password = selectedUser.Password;
            LanguageCmb.ItemsSource = _context.ProgrammingLanguage.ToList();
            LanguageCmb.DisplayMemberPath = "Title";
            LanguageCmb.SelectedItem = selectedUser.ProgrammingLanguage;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxHelper.Question("Сохранить изменения") == true)
            {
                _selectedUser.Email = EmailTb.Text;
                _selectedUser.Email = EmailTb.Text;
                _selectedUser.Password = PasswordTb.Password;
                _selectedUser.ProgrammingLanguage = LanguageCmb.SelectedItem as ProgrammingLanguage;
                _context.SaveChanges();
            }
        }
    }
}
