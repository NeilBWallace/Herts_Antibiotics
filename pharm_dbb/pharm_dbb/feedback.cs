using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb
{







    public class feedback : ContentPage
    {
    

        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }



        public feedback()
        {
            Title = "Feedback";
            Device.OpenUri(new Uri("mailto:david.ladenheim@enhertsccg.nhs.uk?subject=Feedback on Antibiotics App&body=Please provide your feedback here:"));
            var k = new StackLayout
            {
                BackgroundColor = Color.FromHex("bdd1f6"),
                Padding = 5,
                //  BackgroundColor = Color.White,
                Children = {

                }
            };
            Content = k;

        }
    }
}