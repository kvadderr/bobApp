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
using Google.Android.Material.BottomSheet;

namespace MiBu
{
    public class FragmentMyAchievement : Fragment
    {
        private EditText selectCreateTask;
        private EditText selectDescription;
        private EditText selectSendCoin;
        private EditText selectSendKarma, selectProfile;
        private Button saveBtn, backBtn;
        private BottomSheetBehavior bottomSheetBehavior;
        FrameLayout bottomSheet;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_my_achivements, container, false);

            selectCreateTask = (EditText)view.FindViewById(Resource.Id.selectCreateTask);
            selectDescription = (EditText)view.FindViewById(Resource.Id.selectDescription);
            selectSendCoin = (EditText)view.FindViewById(Resource.Id.selectSendCoin);
            selectSendKarma = (EditText)view.FindViewById(Resource.Id.selectSendKarma);
            selectProfile = (EditText)view.FindViewById(Resource.Id.selectProfile);
            bottomSheet = (FrameLayout)view.FindViewById(Resource.Id.bottomSheet);

            bottomSheetBehavior = BottomSheetBehavior.From(bottomSheet);
            BottomSelectProfile bottomSelectProfile = new BottomSelectProfile();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(bottomSheet.Id, bottomSelectProfile);
            transaction.Commit();
            bottomSheetBehavior.State = BottomSheetBehavior.StateHidden;

            saveBtn = (Button)view.FindViewById(Resource.Id.saveBtn);
            backBtn = (Button)view.FindViewById(Resource.Id.backBtn);
            saveBtn = (Button)view.FindViewById(Resource.Id.saveBtn);

            selectProfile.Click += SelectProfile_Click;
            selectCreateTask.Click += selectCreateTaskClick;
            backBtn.Click += backBtnClick;
            selectDescription.Click += SelectDescription_Click;
            selectSendCoin.Click += SelectSendCoin_Click;
            selectSendKarma.Click += SelectSendKarma_Click;

            saveBtn.Click += SaveBtn_Click;
            return view;
        }

        private void SelectProfile_Click(object sender, EventArgs e)
        {
            bottomSheetBehavior.State = BottomSheetBehavior.StateExpanded;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            FragmentCheckTask fragmentCheckTask = new FragmentCheckTask();
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, fragmentCheckTask);
            transaction.Commit();
        }

        private void SelectSendKarma_Click(object sender, EventArgs e)
        {
            ModalSendKarma modalSendKarma = new ModalSendKarma();
            modalSendKarma.DataReceived += ModalSendKarma_DataReceived; ; ; ;
            modalSendKarma.Show(ChildFragmentManager, "modalSendKarma");
        }

        private void ModalSendKarma_DataReceived(object sender, string data)
        {
            selectSendKarma.Text = "+ " + data + " кармы";
            selectSendKarma.SetCompoundDrawablesWithIntrinsicBounds(Resource.Drawable.Karma, 0, 0, 0);
        }

        private void SelectSendCoin_Click(object sender, EventArgs e)
        {
            ModalSendCoin modalSendCoin = new ModalSendCoin();
            modalSendCoin.DataReceived += ModalSendCoin_DataReceived; ; ;
            modalSendCoin.Show(ChildFragmentManager, "modalSendCoin");
        }

        private void ModalSendCoin_DataReceived(object sender, string data)
        {
            selectSendCoin.Text = "+ " + data + " монет";
            selectSendCoin.SetCompoundDrawablesWithIntrinsicBounds(Resource.Drawable.Coin, 0, 0, 0);
        }

        private void SelectDescription_Click(object sender, EventArgs e)
        {
            ModalNewDescription modalNewDescription = new ModalNewDescription();
            modalNewDescription.DataReceived += ModalNewDescription_DataReceived; ;
            modalNewDescription.Show(ChildFragmentManager, "modalNewDescription");
        }

        private void ModalNewDescription_DataReceived(object sender, string data)
        {
            selectDescription.Text = data;
            selectDescription.SetCompoundDrawablesWithIntrinsicBounds(0, 0, 0, 0);
        }

        private void backBtnClick(object sender, EventArgs e)
        {
            FragmentPromotion profile = new FragmentPromotion();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, profile);
            transaction.Commit();
        }

        private void selectCreateTaskClick(object sender, EventArgs e)
        {
            ModalNewTask newTaskModal = new ModalNewTask();
            newTaskModal.dataVisible = true;
            newTaskModal.DataReceived += ModalNewTask_DataReceived;
            newTaskModal.Show(ChildFragmentManager, "newTaskModal");
        }

        private void ModalNewTask_DataReceived(object sender, string data)
        {
            if (data != null || data != "")
            {
                selectCreateTask.Text = data;
                selectCreateTask.SetCompoundDrawablesWithIntrinsicBounds(0, 0, 0, 0);
            }
        }

    }
}