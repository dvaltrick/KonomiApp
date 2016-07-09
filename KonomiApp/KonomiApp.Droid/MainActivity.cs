using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Acr.BarCodes;

namespace KonomiApp.Droid
{
    [Activity(Label = "KonomiApp", Icon = "@drawable/icon", MainLauncher = true, Theme = "@style/CustomTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            BarCodes.Init(() => (Activity)this);
            LoadApplication(new App());
        }
    }
}

