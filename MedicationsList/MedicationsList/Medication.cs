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
    public class Medication
    {
        public Medication(string title, string quantity, string frequency, string duration, string route)
        {
            this.Title = title;
            this.Quantity = quantity;// "2 tablets";
            this.Frequency = frequency;// "3 times daily";
            this.Duration = duration;
            this.DateListed = DateTime.Now.Date;
            this.Route = route;
            MedicationType = 1;
        }

        public string Title { get; set; }
        public DateTime DateListed { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Quantity { get; set; }
        public string Frequency { get; set; }
        public string Route { get; set; }
        public string Duration { get; set; }
        public int MedicationType { get; set; }
    }
}