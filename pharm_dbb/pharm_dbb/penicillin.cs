using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb
{


    public class penicillin : ContentPage
    {
        private ListView listView;
        private ListView _pharmacylist;


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }



        public penicillin()
        {   BackgroundColor = Color.White;
            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Penicillin Allergy", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };

           
            Title = "Penicillin Allergy";
            var t = new Label { Text = "Individuals with a history of anaphylaxis, urticaria or rash immediately after penicillin administration are at risk of immediate hypersensitivity to penicillin; these individuals should not receive penicillin, a cephalosporin or another beta-lactam antibiotic. If necessary, seek further advice regarding altenative therapy" };
            t.TextColor = Color.Black;
            t.FontSize = 15;
            var u = new Image { Source = "diagram.png" };
            var a = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                MinimumHeightRequest=2000,
                 Padding = new Thickness (10, 10, 10,10), 
            
            };

            if (Device.OS == TargetPlatform.Windows)
            {
                s.FontSize = 20;
                NavigationPage.SetHasNavigationBar(this, false);
                a.Children.Add(s);
            };


            a.Children.Add(t);
            a.Children.Add(u);

            Content = new ScrollView { Content = a,MinimumHeightRequest=2000};

        }
    }
}