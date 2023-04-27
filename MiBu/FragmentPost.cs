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
    public class FragmentPost : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_post, container, false);
            Button saveBtn = (Button)view.FindViewById(Resource.Id.saveBtn);
            Button backBtn = (Button)view.FindViewById(Resource.Id.backBtn);
            saveBtn.Click += SaveBtn_Click;
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ModalConfirmation modalConfirmation = new ModalConfirmation();
            modalConfirmation.imageVisible = false;
            modalConfirmation.Show(ChildFragmentManager, "modalConfirmation");
        }
    }
}