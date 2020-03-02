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

namespace _315870_Whileloop_IMPORTANT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            try {
                System.IO.StreamReader sr = new System.IO.StreamReader("names.txt");
                string output = "";

                while(!sr.EndOfStream)
                {
                    output += sr.ReadLine() + Environment.NewLine;
                }
                lblOutput.Content = output;
            } catch(Exception ex) { }
        }
    }
}
