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
    public class MessageItem
    {
        public int Avatar { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int CountUnread { get; set; }
        public string Time { get; set; }
        public bool isIdea { get; set; }


    }
}