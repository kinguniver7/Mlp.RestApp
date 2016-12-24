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

namespace Mlp.RestApp.Droid.Adapters
{
    public class CheckAdapter : BaseAdapter<string>
    {
        string[] _items;
        Activity _context;
        public CheckAdapter(Activity context, string[] items)
        {
            _context = context;
            _items = items;
        }
        public override string this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Length; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView; // re-use an existing view, if one is available
            if (view == null) // otherwise create a new one
                view = _context.LayoutInflater.Inflate(Resource.Layout.cell_layout_check, null);
            view.FindViewById<TextView>(Resource.Id.txvNameFood).Text = _items[position];
            return view;
        }
    }
}