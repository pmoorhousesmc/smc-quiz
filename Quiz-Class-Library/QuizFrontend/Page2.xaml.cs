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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public static bool xAddClicked;

        public static string sQuestion;
        
        public Page2()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void xQFinished_Click(object sender, RoutedEventArgs e)
        {
            sQuestion = sQuestionBox.Text;
            xButton1Text.Text = sQuestion;
        }

        private void sQuestionBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
