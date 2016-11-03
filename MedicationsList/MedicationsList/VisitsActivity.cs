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

namespace MedicationsList
{
    [Activity(Label = "Visits", MainLauncher = false, Icon = "@drawable/icon")]
    public class VisitsActivity : Activity
    {
        private List<Visit> list = new List<Visit>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.VisitsList);//Visits_Test

            ExpandableListView listView = this.FindViewById<ExpandableListView>(Resource.Id.visitsExpandableListView);

            //var date = this.FindViewById<TextView>(Resource.Id.textView1);
          //  date.Text = DateTime.Now.Date.ToShortDateString();

            list.Add(new Visit("Sara Aminah Baz", "Proposed", "Schedule"));
            list.Add(new Visit("Musa Bakri", "Proposed", "Schedule"));
            list.Add(new Visit("Musa Asfour Bakri", "Approved", "Visited"));
            list.Add(new Visit("Sara Bakri", "Evaluated", "Appointed"));
            list.Add(new Visit("Sara Asfour", "Evaluated", "Canceled"));

            var adapter = new VisitsDataAdapter(this, list);
            listView.SetAdapter(adapter);
        }
    }
}