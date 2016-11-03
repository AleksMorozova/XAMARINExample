using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Util;
using Android.Graphics;

namespace MedicationsList
{
    [Activity(Label = "James Salib Aba", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Main);
            var button = this.FindViewById<ImageButton>(Resource.Id.imageButton1);
            button.Click += delegate
            {
                StartActivity(typeof(MedicationsActivity));//MedicationsActivity VisitsActivity
            };

            var button_1 = this.FindViewById<ImageButton>(Resource.Id.imageButton2);
            button_1.Click += delegate
            {
                StartActivity(typeof(VisitsActivity));//MedicationsActivity VisitsActivity
            };
        }
    }
}

