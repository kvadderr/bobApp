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
    public class MenuItem
    {
        public string Title { get; set; }
        public int Icon { get; set; }
        public int Path { get; set; }
    }
}