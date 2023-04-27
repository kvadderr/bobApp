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
    public class ModalConfirmation : DialogFragment
    {
        public bool imageVisible { get; set; }
        public bool dataVisible { get; set; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.modal_confirmation, container, false);
            Button yesBtn = (Button)view.FindViewById(Resource.Id.yesBtn);
            Button noBtn = (Button)view.FindViewById(Resource.Id.noBtn);
            yesBtn.Click += yesBtnClick;
            noBtn.Click += noBtnClick;
            return view;
        }

        private void yesBtnClick(object sender, EventArgs e)
        {
            ModalSuccess successModal = new ModalSuccess();
            successModal.imageVisible = imageVisible;
            successModal.dataVisible = dataVisible;
            successModal.Show(ChildFragmentManager, "successModal");

        }

        private void noBtnClick(object sender, EventArgs e)
        {
            Dismiss();
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            DisplayMetrics displayMetrics = new DisplayMetrics();
            Activity.WindowManager.DefaultDisplay.GetMetrics(displayMetrics);
            int dpWidth = Convert.ToInt16(displayMetrics.WidthPixels / displayMetrics.Density);
            int screenWidth = displayMetrics.WidthPixels;
            int dialogWidth = dpWidth;

            Dialog.Window.SetBackgroundDrawableResource(Android.Resource.Color.Transparent);
            Dialog.Window.SetLayout(screenWidth - 100, ViewGroup.LayoutParams.WrapContent);
            Dialog.Window.SetGravity(GravityFlags.Center);
        }
    }
}