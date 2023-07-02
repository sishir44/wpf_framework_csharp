using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using static System.Net.Mime.MediaTypeNames;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for DataBinding.xaml
    /// </summary>
    public partial class DataBinding : Window
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>();
        public DataBinding()
        {
            InitializeComponent();
            this.DataContext = this;
            Binding b1 = new Binding("Text");
            b1.Source = nametxt;
            resultblock.SetBinding(TextBlock.TextProperty, b1);

            // List of Data
            products.Add(new Product { Name = "Camera" });
            products.Add(new Product { Name = "Mobile" });
            products.Add(new Product { Name = "TV" });
            products.Add(new Product { Name = "Radio" });
            list1.ItemsSource = products;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression exp = heighttext.GetBindingExpression(TextBox.TextProperty);
            exp.UpdateSource();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            products.Add(new Product { Name = "Watch" });
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(list1.SelectedItem != null)
            {
                (list1.SelectedItem as Product).Name = "Electronic Gadget";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (list1.SelectedItem != null)
            {
                products.Remove(list1.SelectedItem as Product);              
            }
        }

        [AddINotifyPropertyChangedInterface] // get this property from (PropertyChanged.Fody) NutGet 
        public class Product
        {
            public string Name { get; set; }
        }
        
    }
}


namespace ChangeVal { 
    public class ChangeValue : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().ToLower() == "yes")
            {
                return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value == true)
            {
                return "yes";
            }
            return false;
        }
    }
}