using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb


{
    public class HCTFrontPage
    {
        public String Image { get; set; }

        public string Name { get; set; }
        public HCTFrontPage(string name, string image)
        {
            Name = name;
            Image = image;


        }

    }



    public class hct_page : ContentPage
    {
         private ListView _pharmacylist;
        private string _name;
        private string _description;

        public void refresh()
        {
     }

        public void NextClick(object sender, EventArgs e)
        {
            var tg = new pharmacy( _name, _description);
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public hct_page()
        {
            BackgroundColor = Color.FromHex("bdd1f6");
            var NextButton = new Button { Text = "Information" };
            NextButton.Clicked += NextClick;
         //   _database = database;
            Title = "HCT";
            var data = new List<HCTFrontPage>  {
                new HCTFrontPage(  "(HCT) Start Smart Then Focus","startsmart.jpg" ),
                 new HCTFrontPage (  "(HCT) Telephone Prescribing","telephone.jpg" ),
                 new HCTFrontPage (  "(HCT) IV to oral stepdown","iv.jpg" ),
              new HCTFrontPage (  "(HCT) Gentamicin prescribing","gentamicin.jpg" ),

            };
            _pharmacylist = new ListView
            {

                SeparatorColor = Color.FromHex("#ddd"),
            };
            _pharmacylist.ItemsSource = data;
         //   _pharmacylist.ItemTemplate = new DataTemplate(typeof(ImageCell));
         //   _pharmacylist.ItemTemplate.SetBinding(ImageCell.TextProperty, "Name");
         //   _pharmacylist.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Image");

            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("1760ae"));
            //  cell.SetValue(TextCell.TextProperty, );

            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
            _pharmacylist.ItemTemplate = cell;

            _pharmacylist.ItemSelected += (sender, e) =>
            {


                if (e.SelectedItem == null) return;
                var user = (HCTFrontPage)e.SelectedItem;
                      if (user.Name == "(HCT) Start Smart Then Focus")
                      {
                         var tg = new newpage( 12);
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "(HCT) Telephone Prescribing")
                     {
                         var tg = new newpage( 13);
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "(HCT) IV to oral stepdown")
                      {
                          var tg = new newpage( 14);
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name== "(HCT) Gentamicin prescribing")
                     {
                          var tg = new newpage( 15);
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }


                //     var tg = new warnings_2(database, user.drug);
                //      Navigation.PushAsync(tg);


                ((ListView)sender).SelectedItem = null; // de-select the row

            };


            var k = new StackLayout
            {
                BackgroundColor = Color.FromHex("bdd1f6"),

            //  BackgroundColor=Color.White,
            Children = {_pharmacylist}
            };
            Content = k;
        }
    }
}
