using System;

using Android.App;
using Android.OS;
using Android.Webkit;

namespace ZoomByTouch
{
    // Defines this activity with a label, icon and as the main activity
    [Activity(Label = "2Finger Zoom", MainLauncher = true, Icon="@drawable/ZoomByTouch")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            WebView view = FindViewById<WebView>(Resource.Id.webView);

            if (view != null)
            {
                String imageUrl = "file:///android_asset/hotelAlexandra.JPG";

                view.Settings.SetSupportZoom(true);
                view.Settings.BuiltInZoomControls = true;
                view.Settings.UseWideViewPort = true;
                view.Settings.LoadWithOverviewMode = true;
                view.LoadUrl(imageUrl);
            }
        }
    }
}