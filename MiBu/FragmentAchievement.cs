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
    public class FragmentAchievement : Fragment
    {

        public bool dataVisible { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_achievements, container, false);
            LinearLayout bestAchievement = (LinearLayout)view.FindViewById(Resource.Id.bestAchievement);
            Button backBtn = (Button)view.FindViewById(Resource.Id.backBtn);
            TextView bestTV = (TextView)view.FindViewById(Resource.Id.bestTV);
            bestAchievement.Click += bestAchievementClick;
            backBtn.Click += backBtnClick;

            if (dataVisible == true) bestTV.Text = "Добавить новое";

            return view;
        }

        private void backBtnClick(object sender, EventArgs e)
        {
            FragmentProfile profile = new FragmentProfile();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, profile);
            transaction.Commit();

        }
        private void bestAchievementClick(object sender, EventArgs e)
        {

            if (dataVisible == true)
            {
                FragmentMyAchievement profile = new FragmentMyAchievement();
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                transaction.Replace(Resource.Id.frame, profile);
                transaction.Commit();
                return;
            }

            ModalSendAchievement sendAchievementModal = new ModalSendAchievement();
            sendAchievementModal.Show(ChildFragmentManager, "sendAchievementModal");
        }
    }
}