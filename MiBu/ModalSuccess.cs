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
    public class ModalSuccess : DialogFragment
    {
        public bool imageVisible { get; set; }
        public bool dataVisible { get; set; }

        public bool dateVisible { get; set; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.modal_success, container, false);
            ImageView second_iv = (ImageView)view.FindViewById(Resource.Id.second_iv);
            Button successBtn = (Button)view.FindViewById(Resource.Id.successBtn);
            LinearLayout additional_data = (LinearLayout)view.FindViewById(Resource.Id.additional_data);
            TextView dateTV = (TextView)view.FindViewById(Resource.Id.dateTV);
            if (imageVisible == true) second_iv.Visibility = ViewStates.Visible;
            if (dataVisible == true) additional_data.Visibility = ViewStates.Visible;
            if (dateVisible == true) dateTV.Visibility = ViewStates.Visible;
            successBtn.Click += successBtnClick;
            return view;
        }

        private void successBtnClick(object sender, EventArgs e)
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