using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Version.Plugin;
using Xamarin.Forms;

namespace pharm_dbb
{
    public class about_guideline : ContentPage
    {
        public about_guideline()
        {
            Title = "About these Guidelines";
            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Version:" + CrossVersion.Current.Version + "\r\n About These Guidelines", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };

            if (Device.OS == TargetPlatform.Windows)
            {

                   NavigationPage.SetHasNavigationBar(this, false);

            }
            BackgroundColor = Color.White;

            var h = new StackLayout
            {
                Padding = new Thickness(20, 20, 20, 20),
                Orientation = StackOrientation.Vertical,
                //            
                BackgroundColor = Color.White,
                };

           
                var q = new Label { FontSize = 20, TextColor = Color.Black, Text = "About these Guidelines" };
            


            var r = new Label { FontSize = 20, TextColor = Color.Black, Text = "This guideline is for antibiotic use in non-pregnant adults (i.e aged 16 years and over) with normal renal and liver function unless specifically stated. All doses given therefore assume normal renal function. \r\n\r\n The full guideline has been ratified by Hertfordshire Medicines Management Committee on behalf of East and North Herts CCG and Herts Valleys CCG. The full guideline is available on the respective intranet site." };
            if (Device.OS == TargetPlatform.Windows)
            {
                h.Children.Add(q);
            };
            h.Children.Add(r);
                var k = new StackLayout
            {
                Padding = new Thickness(5, 5, 5, 5),
                Orientation = StackOrientation.Horizontal,
                //            
                BackgroundColor = Color.White,

                Children = {
                    new Image {
 
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                           HorizontalOptions = LayoutOptions.CenterAndExpand,
                          HeightRequest=30,
                          WidthRequest=180,
                                  Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "hert_logo.png" )} ,
                 new Image
{

    //     BackgroundColor =Color.White,
    VerticalOptions = LayoutOptions.FillAndExpand,
    HorizontalOptions = LayoutOptions.CenterAndExpand,
    HeightRequest = 30,
    WidthRequest = 180,
    Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
    Source = ImageSource.FromFile("hvccg.png")
}



            }
            };


   
            var m = new StackLayout
            {
                Padding = new Thickness(5,5,5,5),
                Orientation = StackOrientation.Horizontal,
                Children = {
                    new Image
                {

                    //     BackgroundColor =Color.White,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    HeightRequest = 30,
                       WidthRequest=180,
                    //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                    Source = ImageSource.FromFile("hpft.png")
                },


                    new Image
                {

                    //     BackgroundColor =Color.White,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    HeightRequest = 30,
                      WidthRequest=180,
                    Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                    Source = ImageSource.FromFile("hct_logo.png")
                } } };


            var z = new StackLayout();
            if (Device.OS == TargetPlatform.Windows)
            {
                 z = new StackLayout { Children = {s, h, k, m } };
            }

            { 
                 z = new StackLayout { Children = { h, k, m } };
            }

            Content = new ScrollView { Content = z };



        }

            };


        }
    
