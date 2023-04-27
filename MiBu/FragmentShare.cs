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
using MiBu.Models;
using MiBu.Adapters;
using static Android.Provider.ContactsContract;

namespace MiBu
{
    public class FragmentShare: Fragment
    {

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_share, container, false);
            Button backBtn = (Button)view.FindViewById(Resource.Id.backBtn);
            FragmentShareMenu fragmentShareMenu = new FragmentShareMenu();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.shareFrame, fragmentShareMenu);
            transaction.Commit();
            backBtn.Click += BackBtn_Click;
            return view;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FragmentProfile fragmentProfile = new FragmentProfile();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, fragmentProfile);
            transaction.Commit();
        }
    }
}