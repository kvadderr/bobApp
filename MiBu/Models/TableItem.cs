using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiBu.Models
{
    public class TableItem
    {
        public int Avatar { get; set; }
        public string FIO { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public int Level { get; set; }
        public int Coin { get; set; }
        public int Karma { get; set; }
        public int GeneralKarma { get; set; }

    }
}