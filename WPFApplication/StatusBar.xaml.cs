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
    /// Interaction logic for StatusBar.xaml
    /// </summary>
    public partial class StatusBar : Window
    {
        public StatusBar()
        {
            InitializeComponent();
        }

        private void inputtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            int row = inputtxt.GetLineIndexFromCharacterIndex(inputtxt.CaretIndex);
            int column = inputtxt.CaretIndex - inputtxt.GetLineIndexFromCharacterIndex(row);
            
            resultlbl.Text = "Line No:" + (row + 1) + ",Character:" + (column + 1);
        }
    }
}
