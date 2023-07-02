using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void WindowStart(object sender, StartupEventArgs e)
        {
            MainWindow obj = new MainWindow();
            obj.Title = "First Page";
            obj.Show();
        }
    }
}
