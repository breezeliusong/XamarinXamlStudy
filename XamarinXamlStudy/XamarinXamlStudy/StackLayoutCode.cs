using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinXamlStudy
{
    public class StackLayoutCode:ContentPage
    {
        public StackLayoutCode()
        {
            var layout = new StackLayout();
            var button = new Button { Text = "StackLayout", VerticalOptions = LayoutOptions.Start, HorizontalOptions = LayoutOptions.FillAndExpand };
            button.Clicked += Button_Clicked;
            var redBox = new BoxView { Color = Color.Red, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            layout.Children.Add(button);
            layout.Children.Add(redBox);
            layout.Spacing = 10;
            Content = layout;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }

    }
}
