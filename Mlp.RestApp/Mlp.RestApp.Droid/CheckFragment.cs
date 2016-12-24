using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Mlp.RestApp.Droid.Adapters;
using Mlp.RestApp.Droid.DataService;
using Mlp.RestApp.Droid.Model;

namespace Mlp.RestApp.Droid
{
    public class CheckFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            
            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.FragmentCheck, container, false);
            List<Product> products = new List<Product> {
                new Product { Name = "Омар на пару" },
                new Product { Name = "Цезарь" },
                new Product { Name = "Вода" },
                new Product { Name ="Кофе" },
                new Product { Name ="Кола" } };
            var adapter = new CheckAdapter(this.Activity, products);
            // Initialize the ListView
            var listView = view.FindViewById<ListView>(Resource.Id.listView1);
            if (listView != null)
            {
                var headerCheck = inflater.Inflate(Resource.Layout.header_layout_check,null);
                listView.AddHeaderView(headerCheck);
                listView.Adapter = adapter;
                listView.ChoiceMode = ChoiceMode.Single;
            }

            return view;

            //return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}