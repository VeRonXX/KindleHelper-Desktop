﻿
using KindleHelper.ViewModels;
using Ookii.Dialogs.Wpf;
using System;
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

namespace KindleHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += (s, e) =>
            {
                WPFUI.Appearance.Watcher.Watch(this, WPFUI.Appearance.BackgroundType.Tabbed, true);
            };

            this.DataContext = new MainViewModel();
        }

        private void btn_Select_Click(object sender, RoutedEventArgs e)
        {

            var fileopen = new VistaFolderBrowserDialog();
            if (fileopen.ShowDialog() == true)
            {
               this.targetFolder.Text = fileopen.SelectedPath;
            }
           
        }
    }
}
