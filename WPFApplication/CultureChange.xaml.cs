using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Globalization;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for CultureChange.xaml
    /// </summary>
    public partial class CultureChange : Window
    {
        public CultureChange()
        {
            InitializeComponent();
        }

        private void Click_Button(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo((sender as Button).Tag.ToString());
            lblnumber.Content = (6578278.45d).ToString("N2");
            lblDate.Content = DateTime.Now.ToString();
        }
    }
}
