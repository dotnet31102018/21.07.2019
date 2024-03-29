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

namespace _2107
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Resources["DynamicColorPink"] = new SolidColorBrush(Colors.LightPink);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColorPink"] = new SolidColorBrush(Colors.Yellow);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColorPink"] = new SolidColorBrush(Colors.LightBlue);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColorPink"] = new SolidColorBrush(Colors.LightGreen);
        }
    }
}
