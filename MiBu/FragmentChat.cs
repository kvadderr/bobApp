using AndroidX.Fragment.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiBu
{
    public class FragmentChat: Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_chat, container, false);
            ImageButton backBtn = (ImageButton)view.FindViewById(Resource.Id.backBtn);
            backBtn.Click += BackBtn_Click;
            return view;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}