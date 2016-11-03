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
    public class Visit
    {
        public Visit(string doctorName, string type, string status)
        {
            this.DoctorName = doctorName;
            this.Type = type;
            this.Status = status;
        }

        public string DoctorName { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }
}