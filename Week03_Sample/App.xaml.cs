using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week03_Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());

            // The root page of your application
            /*
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Welcome to Xamarin Forms!"
                    }
                }
            };

            MainPage = new ContentPage
            {
                Content = layout
            };

            Button button = new Button
            {
                Text = "Click Me"
            };

            button.Clicked += async (s, e) => {
                await MainPage.DisplayAlert("Alert", "You clicked me", "OK");
            };

            layout.Children.Add(button);
            */
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
