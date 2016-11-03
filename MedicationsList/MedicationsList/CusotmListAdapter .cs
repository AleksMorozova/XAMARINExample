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
    public class CusotmListAdapter : BaseAdapter<Medication>
    {
        Activity context;
        List<Medication> list;

        public CusotmListAdapter(Activity _context, List<Medication> _list)
        : base()
        {
            this.context = _context;
            this.list = _list;
        }

        public override int Count
        {
            get { return list.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Medication this[int index]
        {
            get { return list[index]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.Item, parent, false);

            Medication item = this[position];
            view.FindViewById<TextView>(Resource.Id.titleText).Text = item.Title;
            view.FindViewById<TextView>(Resource.Id.frequencyText).Text = item.Frequency;

            return view;
        }
    }
}