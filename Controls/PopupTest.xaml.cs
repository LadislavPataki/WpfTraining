﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Controls
{
    /// <summary>
    /// Interaction logic for PopupTest.xaml
    /// </summary>
    public partial class PopupTest : Window
    {
        public PopupTest()
        {
            InitializeComponent();
        }

        //private void run_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    popLink.IsOpen = true;
        //}
        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(((Hyperlink)sender).NavigateUri.ToString());
        }
    }
}
