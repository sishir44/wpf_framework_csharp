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
    /// Interaction logic for WebBrowserControl.xaml
    /// </summary>
    public partial class WebBrowserControl : Window
    {
        public WebBrowserControl()
        {
            InitializeComponent();
            weBrowser.Navigate("https://www.instagram.com/sishir_4/");
        }

        private void weBrowser_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            MessageBox.Show(e.Uri.OriginalString);
        }
    }
}
