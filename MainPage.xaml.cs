﻿namespace MauiFlyout
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(new MainFlyout()));
        }
    }

}
