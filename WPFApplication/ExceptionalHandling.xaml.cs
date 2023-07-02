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

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for ExceptionalHandling.xaml
    /// </summary>
    public partial class ExceptionalHandling : Window
    {
        public ExceptionalHandling()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            try
            {
                s.Trim();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception Occurs"+ex.Message, "Simple Exception", MessageBoxButton.OK,MessageBoxImage.Exclamation);

            }
        }
    }
}
