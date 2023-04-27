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
    public class FragmentCheckTask: Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_check_task, container, false);
            Button saveBtn = (Button)view.FindViewById(Resource.Id.saveBtn);
            Button backBtn = (Button)view.FindViewById(Resource.Id.backBtn);
            saveBtn.Click += saveBtnClick;
            backBtn.Click += backBtnClick;
            return view;
            return view;
        }

        private void saveBtnClick(object sender, EventArgs e)
        {
            ModalConfirmation confirmationModal = new ModalConfirmation();
            confirmationModal.imageVisible = false;
            confirmationModal.Show(ChildFragmentManager, "confirmationModal");
        }

        private void backBtnClick(object sender, EventArgs e)
        {
            FragmentCreateTask createTask = new FragmentCreateTask();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, createTask);
            transaction.Commit();
        }
    }
}