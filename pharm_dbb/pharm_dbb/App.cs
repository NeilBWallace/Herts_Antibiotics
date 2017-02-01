using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb
{
    public class App : Application
    {
       public NavigationPage nav;

        public void Home_Clicked(object sender, EventArgs args)
        {
            if ((Device.OS == TargetPlatform.WinPhone)||(Device.OS == TargetPlatform.Windows))
            {

                var page = nav.Navigation.NavigationStack.First();

                while (page.Navigation.NavigationStack.Count > 1)
                {
                    page.Navigation.PopAsync();
                }
            }
            else
            { nav.PopToRootAsync(); }
           
          
           // Xamarin.Forms.Device.BeginInvokeOnMainThread(() => nav.PopToRootAsync());
        }
        public void Back_Clicked(object sender, EventArgs args)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => nav.PopAsync());
        }

        public App()
        {
             nav = new NavigationPage(new Contents());
              nav.BarTextColor = Color.White;
            nav.BackgroundColor = Color.White;
            nav.BarBackgroundColor = Color.FromHex("1760ae");

            ToolbarItem tbbSync = new ToolbarItem() { Icon = "homee.png" };
            tbbSync.Text = "Home";
            tbbSync.Clicked += Home_Clicked;
            tbbSync.Order = Device.OnPlatform(ToolbarItemOrder.Primary, ToolbarItemOrder.Primary, ToolbarItemOrder.Primary);
            nav.ToolbarItems.Add(tbbSync);

            ToolbarItem tbbSettings = new ToolbarItem() { Icon = "back.png" };
            tbbSettings.Text = "Back";
            tbbSettings.Clicked += Back_Clicked;
            tbbSettings.Order = Device.OnPlatform(ToolbarItemOrder.Primary, ToolbarItemOrder.Primary, ToolbarItemOrder.Primary);
            nav.ToolbarItems.Add(tbbSettings);

            

            MainPage = nav;
        }

        protected override void OnStart()
        {

       
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
