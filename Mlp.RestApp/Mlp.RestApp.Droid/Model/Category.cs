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
using DomainCategory = Mlp.RestApp.Domain.Category;

namespace Mlp.RestApp.Droid.Model
{
    public partial class Category : DomainCategory
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public new int Id { get; set; }
    }
}