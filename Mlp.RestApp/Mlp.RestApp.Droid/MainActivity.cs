using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Mlp.RestApp.Droid.Adapters;
using Mlp.RestApp.Droid.DataService;
using Mlp.RestApp.Droid.Model;
using System.Linq;
using System.Collections.Generic;

namespace Mlp.RestApp.Droid
{
	[Activity (Label = "Mlp.RestApp.Droid", MainLauncher = true, 
        Icon = "@drawable/icon", 
        ScreenOrientation = Android.Content.PM.ScreenOrientation.SensorLandscape,
        Theme="@style/CustomActionBarTheme")]
	public class MainActivity : Activity
	{
        GridView _gridCategories;
        List<Category> _categories;


        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
            //Set our custom view
            BindStyle();
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            //this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            FragmentTransaction tran = this.FragmentManager.BeginTransaction();
            var check = new CheckFragment();
            tran.Replace(Resource.Id.mainFrameLyRight, check);             // replace fragment with existing
            tran.Commit();

            using (var rep = new RepositorySQLite<Category>())
            {
                _categories = rep.GetAll().ToList();
                if (_categories.Count < 1)
                {
                    rep.Save(new Category { Name = "Первые блюда" });
                    rep.Save(new Category { Name = "Холодные закуски" });
                    rep.Save(new Category { Name = "Бар" });
                    rep.Save(new Category { Name = "Десерты" });
                    rep.Save(new Category { Name = "Вторые блюда" });
                    rep.Save(new Category { Name = "Салаты" });
                }              
            }
            var categoryAdapter = new CategoryAdapter(this, _categories);
            _gridCategories = FindViewById<GridView>(Resource.Id.gridView1);
            _gridCategories.Adapter = categoryAdapter;




            //// Get our button from the layout resource,
            //// and attach an event to it
            //Button button = FindViewById<Button> (Resource.Id.myButton);

            //button.Click += delegate {
            //	button.Text = string.Format ("{0} clicks!", count++);
            //};
        }

        private void BindStyle()
        {
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            ActionBar.SetDisplayShowHomeEnabled(false);
            ActionBar.SetDisplayShowTitleEnabled(false);
            ActionBar.SetCustomView(Resource.Layout.action_bar);
            ActionBar.SetDisplayShowCustomEnabled(true);
        }
	}
}


