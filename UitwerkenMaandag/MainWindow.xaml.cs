﻿using System.Windows;
using System.Windows.Controls;
using UitwerkenMaandag.ViewModel;

namespace UitwerkenMaandag
{
    /// <summary>
    /// This application's main window.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
         
        }
    }
}