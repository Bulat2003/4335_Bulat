﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Template_4335.Windows
{
    /// <summary>
    /// Логика взаимодействия для Zagidullin_4335.xaml
    /// </summary>
    public partial class Gazizullin_4335 : Window
    {
        public Gazizullin_4335()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window_lab2_3_Gazizullin window_Lab2_3_Gazizullin = new Window_lab2_3_Gazizullin();
            window_Lab2_3_Gazizullin.Show();
            this.Close();
        }
    }
}
