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
    /// Логика взаимодействия для SolutionWindow.xaml
    /// </summary>
    public partial class SolutionWindow : Window
    {
        public SolutionWindow(Solution selectedSolution)
        {
            InitializeComponent();
            SolutionGrid.DataContext = selectedSolution;
            TitleTbl.Text = selectedSolution.Title;
            TextTbl.Text = selectedSolution.Description;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
