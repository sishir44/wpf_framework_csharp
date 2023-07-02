﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for UserControlDesign.xaml
    /// </summary>
    public partial class DesignUserControl : UserControl
    {
        public DesignUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string Title { get; set; }
        public string MaxLength { get; set; }
        public DesignUserControl DataContext { get; } // optional
    }
}
