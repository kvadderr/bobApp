using AndroidX.Fragment.App;
using Android.OS;
using Android.Util;
using Android.Views;
using System;
using Android.Content;
using Android.Widget;

namespace MiBu
{
    public class ModalNewTask : DialogFragment
    {

        public event EventHandler<string> DataReceived;
        private EditText taskData;
        private TextView newTV;

        public bool dataVisible { get; set; }

        private void OnDataReceived(string data)
        {
            DataReceived?.Invoke(this, data);
        }

        public override void OnDismiss(IDialogInterface dialog)
        {
            base.OnDismiss(dialog);
            OnDataReceived(taskData.Text);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.modal_new_task, container, false);
            taskData = (EditText)view.FindViewById(Resource.Id.taskData);
            Button saveBtn = (Button)view.FindViewById(Resource.Id.saveBtn);
            TextView newTV = (TextView)view.FindViewById(Resource.Id.newTV);
            if (dataVisible == true) newTV.Text = "Новое достижение";
            saveBtn.Click += saveBtnClick;
            return view;
        }

        private void saveBtnClick(object sender, EventArgs e)
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