using Microsoft.VisualBasic;
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
    /// Interaction logic for DatePicker.xaml
    /// </summary>
    public partial class DatePicker : Window
    {
        private DateTime DisplayDateStart;
        public DateTime DisplayDateEnd;
        private string? FirstDayOfWeek;
        private bool IsTodayHighlighted;
        public DatePicker()
        {
            InitializeComponent();
            DatePicker obj = new DatePicker();
            obj.Name = "DatePicker";
            obj.DisplayDateStart = new DateTime(2023, 01, 01);
            obj.DisplayDateEnd = new DateTime(2025, 12, 30);
            obj.FirstDayOfWeek = "Sunday";
            obj.IsTodayHighlighted = false;
            sp1.Children.Add(obj);
        }       
    }
}
