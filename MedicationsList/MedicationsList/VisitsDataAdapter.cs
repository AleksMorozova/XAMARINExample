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
using Android.Graphics;

namespace MedicationsList
{
    class VisitsDataAdapter : BaseExpandableListAdapter
    {
        Activity context;
        List<Visit> list;

        public VisitsDataAdapter(Activity _context, List<Visit> _list)
        : base()
        {
            this.context = _context;
            this.list = _list;
        }

        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
            View header = convertView;
            var medication = list.ElementAt(groupPosition);
            Color StatusColor = Color.Rgb(138, 222, 242);
            if (medication.Status == "Visited") { StatusColor = Color.Rgb(128, 220, 143); }
            else if (medication.Status == "Canceled") { StatusColor = Color.Pink; }
            else if (medication.Status == "Appointed") { StatusColor = Color.Rgb(248, 196, 28); }
            else if (medication.Status == "Schedule") { StatusColor = Color.Rgb(138, 222, 242); }
            else { StatusColor = Color.Rgb(138, 222, 242); }

            if (medication.Type == "Approved")
            {
                header = context.LayoutInflater.Inflate(Resource.Layout.VisitItem_Approved, parent, false);
                header.FindViewById<TextView>(Resource.Id.doctorNameText).Text = list.ElementAt(groupPosition).DoctorName;
                header.FindViewById<TextView>(Resource.Id.statusTextView).SetBackgroundColor(StatusColor);
                header.FindViewById<TextView>(Resource.Id.statusTextView).Text = medication.Status.ToUpper();
               var button = header.FindViewById<Button>(Resource.Id.approvedButton);
                button.Click += delegate {
                    context.StartActivity(typeof(EvaluatesActivity));
                };
            }
            else if (medication.Type == "Evaluated")
            {
                header = context.LayoutInflater.Inflate(Resource.Layout.VisitItem_Evaluated, parent, false);
                header.FindViewById<TextView>(Resource.Id.statusTextView).SetBackgroundColor(StatusColor);
                header.FindViewById<TextView>(Resource.Id.statusTextView).Text = medication.Status.ToUpper();
                header.FindViewById<TextView>(Resource.Id.doctorNameText).Text = list.ElementAt(groupPosition).DoctorName;
            }
            else
            {
                header = context.LayoutInflater.Inflate(Resource.Layout.VisitItem_Proposed, parent, false);
                header.FindViewById<TextView>(Resource.Id.doctorNameText).Text = list.ElementAt(groupPosition).DoctorName;

                header.FindViewById<TextView>(Resource.Id.statusTextView).SetBackgroundColor(StatusColor);
                header.FindViewById<TextView>(Resource.Id.statusTextView).Text = medication.Status.ToUpper();
                var button = header.FindViewById<Button>(Resource.Id.rejectButton);
                button.Click += delegate {
                    context.StartActivity(typeof(RejectionActivity));
                };
            }
            return header;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            View row = convertView;

            var medication = list.ElementAt(groupPosition);

            if (medication.Type == "Evaluated")
            {
                if (medication.Status == "Canseled")
                {
                    row = context.LayoutInflater.Inflate(Resource.Layout.RejectionDetail, parent, false);
                    row.FindViewById<TextView>(Resource.Id.commentText).Text = "Note";
                }
                else 
                {
                    row = context.LayoutInflater.Inflate(Resource.Layout.VisitsDetail, parent, false);
                    row.FindViewById<TextView>(Resource.Id.commentText).Text = "Note";
                }       
            }

            else
            {
                row.Visibility = ViewStates.Invisible;
                row = null;
            }

            return row;
        }

        public override int GetChildrenCount(int groupPosition)
        {
            return 1;
        }

        public override int GroupCount
        {
            get
            {
                return list.Count;
            }
        }

        private void GetChildViewHelper(int groupPosition, int childPosition, out string Id, out string Value)
        {
            char letter = (char)(65 + groupPosition);
            List<Visit> results = list.FindAll((Visit obj) => obj.DoctorName[0].Equals(letter));
            Id = results[childPosition].DoctorName;
            Value = results[childPosition].DoctorName;
        }

        #region implemented abstract members of BaseExpandableListAdapter

        public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
        {
            throw new NotImplementedException();
        }

        public override long GetChildId(int groupPosition, int childPosition)
        {
            return childPosition;
        }

        public override Java.Lang.Object GetGroup(int groupPosition)
        {
            throw new NotImplementedException();
        }

        public override long GetGroupId(int groupPosition)
        {
            return groupPosition;
        }

        public override bool IsChildSelectable(int groupPosition, int childPosition)
        {
            return true;
        }

        public override bool HasStableIds
        {
            get
            {
                return true;
            }
        }

        #endregion
    }
}