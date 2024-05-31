using ProgaChat.AppData;
using ProgaChat.Model;
using ProgaChat.Views.Windows;
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
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        private static ProgaChatDbEntities _context = App.GetContext();
        public BookPage()
        {
            InitializeComponent();
            ChaptersLV.ItemsSource = _context.Chapter.ToList();
            LanguageTbl.Text = AuthorisationHelper.selectedUser.ProgrammingLanguage.Title;
        }

        private void ChaptersLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChapterWindow chapterWindow = new ChapterWindow(ChaptersLV.SelectedItem as Chapter);
            chapterWindow.ShowDialog();
        }
    }
}
