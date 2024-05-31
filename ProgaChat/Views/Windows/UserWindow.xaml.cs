using ProgaChat.AppData;
using ProgaChat.Views.Pages;
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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            ProfilePage profilePage = new ProfilePage(AuthorisationHelper.selectedUser);
            MainFrame.Navigate(profilePage); 
        }

        private void SolutionBtn_Click(object sender, RoutedEventArgs e)
        {
            SolutionPage solutionPage = new SolutionPage();
            MainFrame.Navigate(solutionPage);
        }

        private void BookBtn_Click(object sender, RoutedEventArgs e)
        {
            BookPage bookPage = new BookPage();
            MainFrame.Navigate(bookPage);
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            ProfilePage profilePage = new ProfilePage(AuthorisationHelper.selectedUser);
            MainFrame.Navigate(profilePage);
        }
    }
}
