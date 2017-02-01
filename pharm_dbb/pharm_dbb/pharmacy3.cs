using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb


{
    public class CustomCell : ViewCell
    {
        public CustomCell()
        {
            Label left = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                TextColor = Color.Black,
                LineBreakMode = Xamarin.Forms.LineBreakMode.WordWrap,

            };

            left.SetBinding(Label.TextProperty, "Infection");
        }
    }


    public class pharmacy3 : ContentPage
    {
    //    public PharmacyDatabase _database;
        private ListView _pharmacylist;
        private string _name;
        private string _description;
        public void refresh()
        {
      //      _pharmacylist.ItemsSource = _database.GetItems(_name);
        }

        
        public pharmacy3( string name, string description)
        {
            _name = name;
            _description = description;
          //  _database = database;
            Title = "Herts Antiobiotics Guidelines";
            //var pharm = _database.GetItems(name);

        
   
            var b = new WebView();
            var h = new HtmlWebViewSource();
            h.Html = description;
            b.BackgroundColor = Color.Blue;
            b.Source = h;
  
            Content = new ScrollView {Content = b };

        }
    }
}


        
   
  
