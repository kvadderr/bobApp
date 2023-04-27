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
    public class FragmentNews : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_news, container, false);
            LinearLayout pressLL = (LinearLayout)view.FindViewById(Resource.Id.pressLL);
            Button backBtn = (Button)view.FindViewById(Resource.Id.backBtn);
            backBtn.Click += BackBtn_Click;
            pressLL.Click += PressLL_Click;
            return view;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FragmentHomeMenu home = new FragmentHomeMenu();
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, home);
            transaction.Commit();
        }

        private void PressLL_Click(object sender, EventArgs e)
        {
            ModalSuccess successModal = new ModalSuccess();
            successModal.dateVisible = true;
            successModal.Show(ChildFragmentManager, "successModal");
        }
    }
}