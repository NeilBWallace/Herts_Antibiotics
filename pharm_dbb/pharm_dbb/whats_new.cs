using pharm_dbb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Version.Plugin;
using Xamarin.Forms;

namespace pharm_dbb

{
    public class whats_new : ContentPage
    {
        public whats_new()
        {
            
            //  IApp popupService = DependencyService.Get<IApp>();
            //  var i = popupService.GetBuildNumber();

            Title = "What's New?";
             var l = new Label { TextColor = Color.FromHex("1760ae"), Text = "This is version " + CrossVersion.Current.Version + " of the Hertfordshire Health Economy Antibiotics Guidelines. \r\n\r\n Credits: \r\n Icons made my madebyoliver from www.flaticon.com \r\n http://www.flaticon.com/authors/madebyoliver.\r\n\r\n This app will be formally reviewed in March 2017." };

            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
                l.FontSize = 20;
                BackgroundColor = Color.FromHex("1760ae");
            }

              var cellLayout = new StackLayout
            {
                BackgroundColor = Color.White,
                 Spacing = 0,
                Padding = new Thickness(10, 5, 10, 5),
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                 Children = { l }
            };
            Content = cellLayout;
        }
    }
}

