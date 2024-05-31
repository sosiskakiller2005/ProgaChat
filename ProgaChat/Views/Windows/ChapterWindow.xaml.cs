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
    /// Логика взаимодействия для ChapterWindow.xaml
    /// </summary>
    public partial class ChapterWindow : Window
    {
        private static ProgaChatDbEntities _context = App.GetContext();
        public ChapterWindow(Chapter selectedChapter)
        {
            InitializeComponent();
            ChapterGrid.DataContext = _context.ChapterText.First(c => c.Id == selectedChapter.Id);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
