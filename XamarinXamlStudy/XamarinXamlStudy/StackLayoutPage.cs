using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinXamlStudy
{
    public class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label { Text = "Hello Page" }
            //    }
            //};
            var layout = new StackLayout();
            var button = new Button { Text = "StackLayout", VerticalOptions = LayoutOptions.Start, HorizontalOptions = LayoutOptions.FillAndExpand };
            button.Clicked += Button_Clicked;
            var greenBox = new BoxView { Color = Color.Green, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            layout.Children.Add(button);
            layout.Children.Add(greenBox);
            layout.Spacing = 10;
            Content = layout;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BindingPage());
        }
    }
}
