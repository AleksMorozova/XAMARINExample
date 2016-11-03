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

    public class ExpandableDataAdapter : BaseExpandableListAdapter
    {
        Activity context;
        List<Medication> list;

        public ExpandableDataAdapter(Activity _context, List<Medication> _list)
        : base()
        {
            this.context = _context;
            this.list = _list;
        }

        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
            View header = convertView;
            View view = convertView;
            if (groupPosition == 0)
            {
                header = context.LayoutInflater.Inflate(Resource.Layout.Header, parent, false);
                view = header;

                header.FindViewById<TextView>(Resource.Id.textView1).Text = "Prescribed Medications";
                view = null;
            }
            else
            {
                if (isExpanded)
                {
                    header = context.LayoutInflater.Inflate(Resource.Layout.ExpandedMedicationItem, parent, false);
                    view = header;
                    var medication = list.ElementAt(groupPosition);
                    header.FindViewById<TextView>(Resource.Id.titleText).Text = list.ElementAt(groupPosition).Title;
                    header.FindViewById<TextView>(Resource.Id.durationText).Text = medication.Duration;
                    header.FindViewById<TextView>(Resource.Id.quantityText).Text = medication.Quantity;
                    header.FindViewById<TextView>(Resource.Id.dateListedText).Text = medication.DateListed.ToShortDateString();
                    header.FindViewById<TextView>(Resource.Id.routeText).Text = medication.Route;
                    header.FindViewById<TextView>(Resource.Id.frequencyText).Text = medication.Frequency;
                    view = null;
                }
                else
                {
                    header = context.LayoutInflater.Inflate(Resource.Layout.Item, parent, false);
                    view = header;
                    var medication = list.ElementAt(groupPosition);
                    header.FindViewById<TextView>(Resource.Id.titleText).Text = list.ElementAt(groupPosition).Title;
                    //header.FindViewById<TextView>(Resource.Id.frequencyText).Text = list.ElementAt(groupPosition).Frequency;
                    //header.FindViewById<TextView>(Resource.Id.frequencyText).Visibility = (!isExpanded) ? ViewStates.Visible : ViewStates.Invisible;
                    view = null;
                }
            }
            return header;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (groupPosition != 0)
            {
                if (row == null)
                {
                    row = context.LayoutInflater.Inflate(Resource.Layout.MedicationDetail, parent, false);
                }

                var medication = list.ElementAt(groupPosition);

                //row.FindViewById<TextView>(Resource.Id.durationText).Text = medication.Duration;
                //row.FindViewById<TextView>(Resource.Id.quantityText).Text = medication.Quantity;
                //row.FindViewById<TextView>(Resource.Id.dateListedText).Text = medication.DateListed.ToShortDateString();
                //row.FindViewById<TextView>(Resource.Id.routeText).Text = medication.Route;
                //row.FindViewById<TextView>(Resource.Id.frequencyText).Text = medication.Frequency;

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
            List<Medication> results = list.FindAll((Medication obj) => obj.Title[0].Equals(letter));
            Id = results[childPosition].Title;
            Value = results[childPosition].Title;
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