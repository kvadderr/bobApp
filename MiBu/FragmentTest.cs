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
using Android.Service.QuickSettings;

namespace MiBu
{
    public class FragmentTest: Fragment
    {

        TextView title, subtitle, goToPost, selectSubTest1, selectSubTest2;
        ImageView iconSubtitle;
        public string Sub  { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_test, container, false);
            title = (TextView)view.FindViewById(Resource.Id.title);
            subtitle = (TextView)view.FindViewById(Resource.Id.subtitle);
            goToPost = (TextView)view.FindViewById(Resource.Id.goToPost);
            selectSubTest1 = (TextView)view.FindViewById(Resource.Id.selectSubTest1);
            selectSubTest2 = (TextView)view.FindViewById(Resource.Id.selectSubTest2);
            iconSubtitle = (ImageView)view.FindViewById(Resource.Id.iconSubtitle);

            selectSubTest1.Click += SelectSubTest1_Click;
            selectSubTest2.Click += SelectSubTest2_Click;
            goToPost.Click += GoToPost_Click;

            title.Click += Title_Click;
            title.Text = Sub;



            return view;
        }

        private void GoToPost_Click(object sender, EventArgs e)
        {
            FragmentPost fragmentPost = new FragmentPost();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, fragmentPost);
            transaction.Commit();
        }

        private void SelectSubTest2_Click(object sender, EventArgs e)
        {
            subtitle.Visibility = ViewStates.Visible;
            iconSubtitle.Visibility = ViewStates.Visible;

            subtitle.Text = selectSubTest2.Text;
        }

        private void SelectSubTest1_Click(object sender, EventArgs e)
        {
            subtitle.Visibility = ViewStates.Visible;
            iconSubtitle.Visibility = ViewStates.Visible;

            subtitle.Text = selectSubTest1.Text;

        }

        private void Title_Click(object sender, EventArgs e)
        {
            FragmentShareMenu fragmentShareMenu = new FragmentShareMenu();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.shareFrame, fragmentShareMenu);
            transaction.Commit();
        }
    }
}