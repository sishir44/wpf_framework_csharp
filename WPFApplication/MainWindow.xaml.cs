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

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AllCheck_Checked(object sender, RoutedEventArgs e)
        {
            bool allstate = (AllCheck.IsChecked == true);
            first.IsChecked = allstate;
            second.IsChecked = allstate;
            third.IsChecked = allstate;
        }

        private void Child_Checked(object sender, RoutedEventArgs e)
        {
            AllCheck.IsChecked = null;
            if((first.IsChecked == true) && (second.IsChecked == true) && (third.IsChecked == true))
            {
                AllCheck.IsChecked = true;
            }
            if ((first.IsChecked == false) && (second.IsChecked == false) && (third.IsChecked == false))
            {
                AllCheck.IsChecked = false;
            }
        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            clickbtn.Content = "Save Me!";
        }
    }
}
