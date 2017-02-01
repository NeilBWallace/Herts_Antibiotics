using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb
{
   


    public class GetFrontPage
    {
        public String Image{ get; set; }

        public string Name { get; set; }
        public GetFrontPage(string name, string image)
        {
            Name = name;
            Image = image;
         

        }

    }

   


    public static class ContentsData
    {


        public static Color BrandColor = Color.FromHex("#FAA128");
   


       
    }

    public class Contents : ContentPage
    {
        private ListView listView;
        private ListView _pharmacylist;
        public static int iAppear = 0;

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var st = "This app is intended for use by Health Care Professionals who prescribe medication. \r\n";
            st = st + "This application is a decision support software that provides information to enable Healthcare Professionals ";
            st = st + "to use their knowledge to make clinical decisions.\r\n ";
            st = st + "The application will not document any decisions made by Healthcare Professionals. The full guidelines on which this summary guidance is based has been ratified by Herts Medicines Management Committee.\r\n ";
            st = st + "For the full guidelines please see respective CCG websites.";
            st = st + "It is your responsibility to ensure you have the most up to date version of the app downloaded.";


            //   var answer = App.Current.MainPage.DisplayAlert("Disclaimer", st, "I agree");



            if (iAppear == 0)
            {
               await DisplayAlert("Disclaimer", st, "I agree");
                iAppear = 1;
            }
        }
            


        public void refresh()
        { 
            //         listView.ItemsSource = _database.GetContents();
        }
       



        public Contents()
        {
            //version 1.1
            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Hertfordshire Primary Care", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };

         

            Title = "Hertfordshire primary care";
            var t= new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Antibiotics Guidelines ",   TextColor=Color.FromHex("1760ae"),  Font=Font.SystemFontOfSize(20,FontAttributes.Bold) };
            var u = new Label { Text = "", TextColor = Color.FromHex("1760ae"), FontSize = 10 };

            //    var u = new Label { Text = "Antibiotics Guidelines" , TextColor = Color.FromHex("1760ae"), FontSize = 10 };
            //   Title = "Contents";
            NavigationPage.SetHasNavigationBar(this, true);
               
            //  var pharm = database.GetContents();
            // BackgroundColor = Color.White;
            BackgroundColor = Color.FromHex("bdd1f6");
            var data = new List<GetFrontPage>  {
              new GetFrontPage (  "Treatment Guidelines","guidelines.png"),

                new GetFrontPage  ( "What's new in this version","whatsnew.png"),
       //         new GetFrontPage ("About this app","about.png"),
                   new GetFrontPage ( "Restricted Antibiotics", "restricted.png"),
               new GetFrontPage (  "Penicillin allergy","penicillin.png" ),
                 new GetFrontPage ( "Principles of Treatment","principles.png" ),
                 new GetFrontPage ( "About these guidelines","about_guideline.png" ),
      //   new GetFrontPage ( "Full (pdf) version of the guidelines","pdf.png" ),

         new GetFrontPage (  "Feedback","Feedback.png" ),
          //       new GetFrontPage (  "Clostridium difficile infection","cdiff.jpg" ),
           //      new GetFrontPage (  "CRP testing","CRP.png" ),
              //    new GetFrontPage (  "Specific Drug Warnings","warning.png" ),
  //               new GetFrontPage(  "(HCT) Guidance","HCT.png"),
       //          new GetFrontPage(  "(HCT) Start Smart Then Focus","startsmart.jpg" ),
       //          new GetFrontPage (  "(HCT) Telephone Prescribing","telephone.jpg" ),
       //          new GetFrontPage (  "(HCT) IV to oral stepdown","iv.jpg" ),
       //        new GetFrontPage (  "(HCT) Gentamicin prescribing","gentamicin.jpg" ),
       //new GetFrontPage (  "(HCT) Gentamicin prescribing","icon.png" ),
   //            new GetFrontPage (  "School Information","school.png"),

            };

            _pharmacylist = new ListView
            {
                BackgroundColor = Color.FromHex("bdd1f6"),
                
            SeparatorColor = Color.FromHex("#ddd"),
            };
            _pharmacylist.ItemsSource = data;
            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("1760ae"));
          //  cell.SetValue(TextCell.TextProperty, );

            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
            _pharmacylist.ItemTemplate = cell;
            // _pharmacylist.ItemTemplate = new DataTemplate(typeof(ImageCell));
            // _pharmacylist.ItemTemplate.SetBinding(ImageCell.TextProperty, "Name");
            // _pharmacylist.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Image");
            // _pharmacylist.SetValue(TextCell.TextColorProperty, Color.White);
          //  _pharmacylist.HeightRequest = 500;
            _pharmacylist.RowHeight = 65;

            var a = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand

                //  Padding = new Thickness (5, 5, 5, 5), 
            };
            if (Device.OS == TargetPlatform.Windows)
            {

                //  Padding = new Thickness (5, 5, 5, 5), 
                a.Children.Add(s);
                a.Children.Add(t);
                a.Children.Add(u);
                NavigationPage.SetHasNavigationBar(this, false);
                }
            else
            {
                a.Children.Add(t);
                a.Children.Add(u);


            }



            //   var p = new StackLayout
            //   {
            //       Padding = 5,
            //       Children = { title }
            //   };



            var logo = new StackLayout
            {
                Padding = new Thickness(5, 5, 5, 5),
                Orientation = StackOrientation.Horizontal,

                Children = {    new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                           HorizontalOptions = LayoutOptions.StartAndExpand,
                          HeightRequest=30,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "th.jpg" )
                },
          new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                           HorizontalOptions = LayoutOptions.EndAndExpand,
                          HeightRequest=30,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "hbl.png" )
            }
                }

            };

            var k = new StackLayout
            {
                BackgroundColor = Color.FromHex("bdd1f6"),
                Padding = 5,
                //  BackgroundColor = Color.White,
                Children = {a,
                    _pharmacylist,logo

                }
            };

            Content = k;
            





            _pharmacylist.ItemSelected += (sender, e) => {


                if (e.SelectedItem == null) return;
                var user = (GetFrontPage)e.SelectedItem  ;
                if (user.Name == "What's new in this version")
                {
                    var tg = new whats_new();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Feedback")
                {
                    var tg = new feedback();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

                }
                if (user.Name == "Treatment Guidelines")
                {
                    // var nav= new NavigationPage(new pharmacy(database));
                    //       var nav= new NavigationPage(new area_page(database));

                    var tg = new area_page();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Restricted Antibiotics")
                {
                    var tg = new newpage(1);
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }


                if (user.Name == "About these guidelines")
                {

                    var tg = new about_guideline();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Principles of Treatment")
                {
                    var tg = new newpage(2);
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Educational Resources")
                {
                    var tg = new newpage( 3);
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Full (pdf) version of the guidelines")
                {
                    var tg = new pdf();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));


                }


                if (user.Name == "Penicillin allergy")
                {
                    var tg = new penicillin();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "CRP testing")
                {
                    var tg = new newpage( 5);
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "School Information")
                {
                    var tg = new newpage(6) ;
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Specific Drug Warnings")
                {
            //        var tg = new specific_warnings();
              //      Navigation.PushAsync(tg);
                }
                if (user.Name == "(HCT) Guidance")
                {
                    var tg = new hct_page();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                

       
                if (e.SelectedItem == null) return; // don't do anything if we just de-selected the row
                                                    // do something with e.SelectedItem
                ((ListView)sender).SelectedItem = null; // de-select the row

            };
        }
    }
}