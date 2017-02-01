using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb


{

    
  
    public class warnings_2: ContentPage
    {
        private ListView _pharmacylist;
        private string name;

        public void refresh()
        {
           // _pharmacylist.ItemsSource = _database.GetItems(name);
    }

        public warnings_2(string name)
        {

         //   _database = database;
            Title = "Antibiotics Guidelines";
         //   var pharm = _database.GetWarnings(name);
          //  var k= pharm.First();
       
            var browser =new WebView();
            var htmlSource = new HtmlWebViewSource();   
      //      htmlSource.Html = "<div style='font-family:Helvetica;padding:5px;background-color:#1760ae;padding:5px;width=100%;color:white'></div><div style='font-family:Helvetica;padding:5px;background-color:#1760ae;padding:5px;width=100%;color:white'>" + " </div><p><div style='font-family:Helvetica'>" + k.warning  + "</div><p><div style='font-family:Helvetica;padding:5px;background-color:#1760ae;padding:5px;width=100%;color:white'>"  + "</div><p><div style='font-family:Helvetica'>"  + "</div>" ;
            browser.BackgroundColor = Color.Blue;
            browser.Source = htmlSource;          
            Content = browser;
       
 
        
        }
    }
}

