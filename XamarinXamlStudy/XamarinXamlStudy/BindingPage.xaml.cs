﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinXamlStudy
{
    public partial class BindingPage : ContentPage
    {
        public BindingPage()
        {
            InitializeComponent();
        }

        private async void click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BackwardsBindingPage());
        }
    }
}
