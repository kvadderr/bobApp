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
    public class ModalSendAchievement : DialogFragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.modal_send_achievement, container, false);
            Button sendAchievement = (Button)view.FindViewById(Resource.Id.sendAchievement);
            sendAchievement.Click += sendAchievementClick;
            return view;
        }

        private void sendAchievementClick(object sender, EventArgs e)
        {
            ModalConfirmation confirmationModal = new ModalConfirmation();
            confirmationModal.imageVisible = true;
            confirmationModal.Show(ChildFragmentManager, "confirmationModal");
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