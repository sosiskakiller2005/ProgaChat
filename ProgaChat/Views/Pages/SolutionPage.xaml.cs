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
    /// Логика взаимодействия для SolutionPage.xaml
    /// </summary>
    public partial class SolutionPage : Page
    {
        private static ProgaChatDbEntities _context = App.GetContext();
        public SolutionPage()
        {
            InitializeComponent();
            SolutionsLV.ItemsSource = _context.Solution.ToList();
        }

        private void SolutionsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SolutionWindow solutionWindow = new SolutionWindow(SolutionsLV.SelectedItem as Solution);
            solutionWindow.ShowDialog();
        }
    }
}
