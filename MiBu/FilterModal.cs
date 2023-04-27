using Android.App;
using Android.OS;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using System;

namespace MiBu
{
    public class FilterModal : AndroidX.Fragment.App.DialogFragment
    {
        LinearLayout job_title_ll;
        CheckBox job_title_cb;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.modal_sort_raiting, container, false);
            job_title_ll = (LinearLayout)view.FindViewById(Resource.Id.job_title_ll);
            job_title_cb = (CheckBox)view.FindViewById(Resource.Id.job_title_cb);

            job_title_cb.Click += job_title_cb_click;
            return view;
        }

        private void job_title_cb_click(object sender, EventArgs e)
        {
            if (job_title_cb.Checked == true) job_title_ll.Visibility = ViewStates.Visible;
            else job_title_ll.Visibility = ViewStates.Gone;
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