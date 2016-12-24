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
    class CategoryAdapter : BaseAdapter<Category>
    {
        IEnumerable<Category> _items;
        Activity _context;

        public CategoryAdapter(Activity context, IEnumerable<Category> items)
        {
            _context = context;
            _items = items;
        }

        public override Category this[int position]
        {
            get
            {
                return _items.FirstOrDefault(c => c.Id == (position + 1));
            }
        }

        public override int Count
        {
            get
            {
                return _items.Count();
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView; // re-use an existing view, if one is available

            if (view == null) // otherwise create a new one
                view = _context.LayoutInflater.Inflate(Resource.Layout.cell_layout_category, null);
            if(this[position]!=null)
                view.FindViewById<TextView>(Resource.Id.txvCategoryName).Text = this[position].Name;
            return view;
        }
    }
}