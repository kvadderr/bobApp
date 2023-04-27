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
    public class ProfileItem
    {
        public int Avatar { get; set; }
        public string FIO { get; set; }
        public string Job { get; set; }
    }
}