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
using static Android.Graphics.ColorSpace;
using Xamarin.Essentials;

namespace MiBu
{
    public class FragmentProfile: Fragment
    {
        LinearLayout invisibleLL;
        TextView visibleBtn;
        bool isClicked = false;
        
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_profile, container, false);

            RelativeLayout selectAchievements = (RelativeLayout)view.FindViewById(Resource.Id.selectAchievements);
            RelativeLayout selectCreateTask = (RelativeLayout)view.FindViewById(Resource.Id.selectCreateTask);
            RelativeLayout selectShare = (RelativeLayout)view.FindViewById(Resource.Id.selectShare);

            Button backBtn = (Button)view.FindViewById(Resource.Id.backBtn);
            invisibleLL = (LinearLayout)view.FindViewById(Resource.Id.invisibleLL);
            visibleBtn = (TextView)view.FindViewById(Resource.Id.visibleBtn);
            visibleBtn.Click += visibleBtnClick;
            backBtn.Click += backBtnClick;
            selectAchievements.Click += selectAchievementsClick;
            selectCreateTask.Click += selectCreateTaskClick;
            selectShare.Click += selectShareClick;

            return view;
        }

        private void selectShareClick(object sender, EventArgs e)
        {
            FragmentShare share = new FragmentShare();
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, share);
            transaction.Commit();
        }

        private void backBtnClick(object sender, EventArgs e)
        {
            FragmentHomeMenu home = new FragmentHomeMenu();
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, home);
            transaction.Commit();
        }

        private void visibleBtnClick(object sender, EventArgs e)
        {
            if (isClicked == false)
            {
                isClicked = true;
                invisibleLL.Visibility = ViewStates.Visible;
                visibleBtn.SetText(Resource.String.hide);
            }
            else
            {
                isClicked = false;
                invisibleLL.Visibility = ViewStates.Gone;
                visibleBtn.SetText(Resource.String.see_all);
            }
        }

        private void selectCreateTaskClick(object sender, EventArgs e)
        {
            FragmentCreateTask createTask = new FragmentCreateTask();
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, createTask);
            transaction.Commit();
        }

        private void selectAchievementsClick(object sender, EventArgs e)
        {
            FragmentAchievement achievements = new FragmentAchievement();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, achievements);
            transaction.Commit();
        }

    }
}