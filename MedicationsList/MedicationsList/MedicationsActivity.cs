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
    [Activity(Label = "Medications", MainLauncher = false, Icon = "@drawable/icon")]
    public class MedicationsActivity : Activity
    {
        private List<Medication> list = new List<Medication>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
          SetContentView(Resource.Layout.List);

            var listView = this.FindViewById<ExpandableListView>(Resource.Id.expandableListView1);

            list.Add(new Medication("Adalat", "2 tablet", "3 times daily", "mounth", "Orally"));
            list.Add(new Medication("Adalat", "2 tablet", "3 times daily", "mounth", "Orally"));
            list.Add(new Medication("Ascorbic Acid 500 mg", "2 tablet", "3 times daily", "mounth", "Orally"));
            list.Add(new Medication("Plavix", "2 tablet", "3 times daily", "mounth", "Orally"));
            list.Add(new Medication("No Spa", "2 tablet", "3 times daily", "mounth", "Orally"));
            list.Add(new Medication("Camomile", "2 tablet", "3 times daily", "mounth", "Orally"));
            var adapter = new ExpandableDataAdapter(this, list);
            listView.SetAdapter(adapter);
        }
    }
}