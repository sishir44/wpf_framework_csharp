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
    /// Interaction logic for SliderExample.xaml
    /// </summary>
    public partial class SliderExample : Window
    {
        public SliderExample()
        {
            InitializeComponent();
        }

        public SolidColorBrush Background { get; private set; }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)slider1.Value,(byte)slider2.Value,(byte)slider3.Value);
            this.Background = new SolidColorBrush(color); 
        }
    }
}
