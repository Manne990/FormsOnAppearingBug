using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OnAppearingBug
{
    public partial class MyChildPage2 : ContentPage
    {
        public MyChildPage2()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            System.Diagnostics.Debug.WriteLine("MyChildPage2.OnAppearing");
        }
    }
}
