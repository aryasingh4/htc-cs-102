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

namespace week_3_code_along
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string dogName;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            dog dog = new dog();
            dog.bark(); 
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            string dogName = DogName.Text;
            dog dog = new dog();
            dog.name = dogName;
            dog.SayName(); 
        }
    }
}
