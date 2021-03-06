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
using Xamarin.Forms;
using pharm_dbb;
using pharm_dbb.Droid;
using Xamarin.Forms.Platform.Android;
using System.Net;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace pharm_dbb.Droid
{
   
        public class CustomWebViewRenderer : WebViewRenderer
        {
            protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
            {
                base.OnElementChanged(e);

                if (e.NewElement != null)
                {
                    var customWebView = Element as CustomWebView;
                    Control.Settings.AllowUniversalAccessFromFileURLs = true;
                    Control.LoadUrl(string.Format("file:///Assets/pdfjs/web/viewer.html?file={0}", string.Format("file:///Assets/c/{0}", WebUtility.UrlEncode(customWebView.Uri))));
                }
            }
        }
    }