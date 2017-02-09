using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OnAppearingBug
{
    public partial class MyChildPage1 : ContentPage
    {
        public MyChildPage1()
        {
            InitializeComponent();

            myLabel.Text = Guid.NewGuid().ToString();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            System.Diagnostics.Debug.WriteLine($"MyChildPage1.OnAppearing with ID: {myLabel.Text}");
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyChildPage1());
        }
    }
}