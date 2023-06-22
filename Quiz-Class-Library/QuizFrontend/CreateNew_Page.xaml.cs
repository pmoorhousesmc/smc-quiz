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
    /// Interaction logic for CreateNew_Page.xaml
    /// </summary>
    public partial class CreateNew_Page : Page
    {
        Page2 _page2 = new Page2();
        
        public CreateNew_Page()
        {
            InitializeComponent();
        }

        private void Buttttttton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void xAddQ_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Page2.xaml", UriKind.Relative);
            this.QuestionFrame.Navigate(uri);
            if (Page2.xAddClicked) 
            {
                
            }
        }

        private void xRemoveQ_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Page3.xaml", UriKind.Relative);
            this.QuestionFrame.Navigate(uri);
        }


    }
}
