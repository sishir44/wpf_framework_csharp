using Microsoft.Win32;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Techy Ccr","Msgbox Header",MessageBoxButton.YesNoCancel,MessageBoxImage.Information,MessageBoxResult.Yes);
            switch(result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Click Yes");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Click No");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Cancel");
                    break;
            }
        }

        private void OpenFileDialogEvent(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png File (*.png) | *.png | All Files (*.*) | *.*";
            openFileDialog.Multiselect = true;
            if(openFileDialog.ShowDialog() == true) { 
                ResultOpen.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveFileDialogEvent(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt) | *.txt | Png File (*.png) | *.png | All Files (*.*) | *.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName,ResultOpen.Text);
            }
        }
    }
}
