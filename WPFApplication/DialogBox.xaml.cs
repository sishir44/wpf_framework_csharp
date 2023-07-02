using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for DialogBox.xaml
    /// </summary>
    public partial class DialogBox : Window
    {
        public DialogBox()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.Filter = "Text File(*.txt) | *.txt | C# File(*.cs) | *.cs";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName,t1.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                t1.FontFamily = new FontFamily(dialog.Font.Name);
                t1.FontSize = dialog.Font.Size * 90.0 / 72.0;
                t1.FontWeight = dialog.Font.Bold ? FontWeights.Bold : FontWeights.Regular;
                t1.FontStyle = dialog.Font.Italic ? FontStyles.Italic : FontStyles.Normal;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                t1.Foreground = new SolidColorBrush(Color.FromArgb(dialog.Color.A, dialog.Color.R, dialog.Color.G, dialog.Color.B));
            }
        }
    }
}
