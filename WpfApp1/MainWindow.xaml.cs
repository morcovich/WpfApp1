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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonTask1_Click(object sender, RoutedEventArgs e)
        {
            new Task1Window().ShowDialog();
        }

        private void ButtonTask2_Click(object sender, RoutedEventArgs e)
        {
            new Task2Window().ShowDialog();
        }

        private void ButtonTask3_Click(object sender, RoutedEventArgs e)
        {
            new Task3Window().ShowDialog();
        }

        private void ButtonTask4_Click(object sender, RoutedEventArgs e)
        {
            new Task4Window().ShowDialog();
        }
    }
}
