using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using System.Runtime.Remoting.Contexts;
using Xamarin.Forms;
using pharm_dbb.iOS.DeviceSpecificCode;
using pharm_dbb;

[assembly: Dependency(typeof(App_iOS))]

namespace pharm_dbb.iOS.DeviceSpecificCode
{
    public class App_iOS : IApp
    {
        public string GetBuildNumber()
        {
            return NSBundle.MainBundle.InfoDictionary[new NSString("CFBundleVersion")].ToString();
        }
    }
}
