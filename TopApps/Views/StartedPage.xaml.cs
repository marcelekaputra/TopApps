﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace TopApps
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/HomePage.xaml", UriKind.Relative));
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
        }
    }
}