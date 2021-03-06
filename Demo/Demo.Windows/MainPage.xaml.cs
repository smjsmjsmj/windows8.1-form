﻿using Demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Demo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Character> MarvelCharacters { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            MarvelCharacters = new ObservableCollection<Character>();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            while (MarvelCharacters.Count < 10)
            {
                Task t = MarvelFacade.PopulateMarvelCharactersAsync(MarvelCharacters);
                await t;
            }

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;

            MasterListView.ItemsSource = MarvelCharacters;

        }

        private void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedCharacter = (Character)e.ClickedItem;

            DetailNameTextBlock.Text = selectedCharacter.name;
            DetailDescriptionTextBlock.Text = selectedCharacter.description;

            var largeImage = new BitmapImage();
            Uri uri = new Uri(selectedCharacter.thumbnail.large, UriKind.Absolute);
            largeImage.UriSource = uri;
            DetailImage.Source = largeImage;
        }
    }
}
