﻿using System.Collections.ObjectModel;
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
using System;
using Microsoft.Win32;

namespace ClientTCP.Launcher
{
    /// <summary>
    /// Логика взаимодействия для Launcher.xaml
    /// </summary>
    public partial class Launcher : Window
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Exit_from_Launcher(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Upi_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Settings_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Assets_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Builder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Update_Delete_Icons(object sender, RoutedEventArgs e)
        {
            if (UpdateImageButton.Visibility == Visibility.Hidden)
            {
                UpdateImageButton.Visibility = Visibility.Visible;
                DeleteImageButton.Visibility = Visibility.Visible;
            }
            else
            {
                UpdateImageButton.Visibility = Visibility.Hidden;
                DeleteImageButton.Visibility = Visibility.Hidden;
            }

        }
        //TODO: сохранять и подгружать аватарку локально 
        private void Update_Avatar_Button(object sender, RoutedEventArgs e)
        {
            Update_Picture.Visibility = Visibility.Visible;
            UpdateImageButton.Visibility = Visibility.Hidden;
            DeleteImageButton.Visibility = Visibility.Hidden;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files| *.bmp; *.jpg; *.png";
            openDialog.FilterIndex = 1;
            if (openDialog.ShowDialog() == true)
            {
                avatarPicture.Source = new BitmapImage(new Uri(openDialog.FileName));

            }
        }
        private void Delete_Avatar_Button(object sender, RoutedEventArgs e)
        {
            UpdateImageButton.Visibility = Visibility.Hidden;
            DeleteImageButton.Visibility = Visibility.Hidden;
            Update_Picture.Visibility = Visibility.Hidden;
            avatarPicture.Source = null;
        }
    }
}
