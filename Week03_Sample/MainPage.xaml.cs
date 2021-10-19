using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Week03_Sample
{
    public partial class MainPage : ContentPage
    {
        //Part2-2
        Entry phoneNumberText;
        Button translateButton;
        Button callButton;

        string translatedNumber;

        public MainPage()
        {
            //Default
            //InitializeComponent();

            /* Part2
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Welcome to Bim493 Course"
                    }
                }
            };
            */


            //Part2-2
            this.Padding = new Thickness(20, 20, 20, 20);
            StackLayout panel = new StackLayout
            {
                Spacing = 15
            };

            panel.Children.Add(new Label
            {
                Text = "Enter a Phoneword:",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            });

            panel.Children.Add(phoneNumberText = new Entry
            {
                Text = "1-855-XAMARIN",
            });

            panel.Children.Add(translateButton = new Button
            {
                Text = "Translate"
            });

            panel.Children.Add(callButton = new Button
            {
                Text = "Call",
                IsEnabled = false,
            });

            translateButton.Clicked += OnTranslate;

            //Part3 added with using Xamarin.Essentials API
            callButton.Clicked += OnCall;

            this.Content = panel;

            void OnTranslate(object sender, System.EventArgs e)
            {
                translatedNumber = PhonewordTranslator.ToNumber(phoneNumberText.Text);
                if (!string.IsNullOrEmpty(translatedNumber))
                {
                    callButton.IsEnabled = true;
                    callButton.Text = "Call " + translatedNumber;
                }
                else
                {
                    callButton.IsEnabled = false;
                    callButton.Text = "Call";
                }
            }


            //Part3 added with using Xamarin.Essentials API
            void OnCall(object sender, System.EventArgs e)
            {
                //Using Xamarin.Essentials API
                try
                {
                    PhoneDialer.Open(translatedNumber);
                }
                catch (Exception ex)
                {
                    DisplayAlert("Unable to make call", "Please enter a number", "OK");
                }
            }

        }
    }
}
