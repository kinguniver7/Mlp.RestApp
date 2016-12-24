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
using Mlp.RestApp.DataService;
using SQLite;
using DomainProduct = Mlp.RestApp.Domain.Product;

namespace Mlp.RestApp.Droid.Model
{
    public class Product : DomainProduct
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public new int Id { get; set; }
    }
}