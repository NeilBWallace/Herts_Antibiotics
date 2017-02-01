using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using pharm_dbb;
using Android.Content.PM;
using Xamarin.Forms;
using pharm_droid.Android.DeviceSpecificCode;

[assembly: Dependency(typeof(App_Droid))]

namespace pharm_droid.Android.DeviceSpecificCode
{
   
    public class App_Droid : IApp
    {
        public string GetBuildNumber()
        {
            Context context = Forms.Context;
            PackageManager manager = context.PackageManager;
            PackageInfo info = manager.GetPackageInfo(context.PackageName, 0);
            return info.VersionName;
        }
    }
}