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
using Mlp.RestApp.Droid.Model;

namespace Mlp.RestApp.Droid.Adapters
{
    public class CheckAdapter : BaseAdapter<Product>
    {
        List<Product> _items;
        Activity _context;
        public CheckAdapter(Activity context, List<Product> items)
        {
            _context = context;
            _items = items;
        }
        public override Product this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count; }
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
            if (_items[position] == null)
            {
                view.FindViewById<TextView>(Resource.Id.txvNameFood).Text = view.Resources.GetString(Resource.String.product_name);
                view.FindViewById<TextView>(Resource.Id.txvPriceFood).Text = view.Resources.GetString(Resource.String.product_price);
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txvNameFood).Text = _items[position].Name;
                view.FindViewById<TextView>(Resource.Id.txvPriceFood).Text = "100 грн.";//_items[position].Price;
            }
            
            return view;
        }
    }
}