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

namespace QuizFrontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Uri uri = new Uri("CreateNew_Page.xaml", UriKind.Relative);
            this.PageFrame.Navigate(uri);
        }

        private void CreateNewBtn_Click(object sender, RoutedEventArgs e)
        {
            var createNewQuiz = new Window1();
            createNewQuiz.Show();
            this.Close();
        }

        private void StatsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditExistingBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PageFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
