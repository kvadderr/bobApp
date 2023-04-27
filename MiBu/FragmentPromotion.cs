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
    public class FragmentPromotion : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_promotion, container, false);
            Button savebtn = (Button)view.FindViewById(Resource.Id.saveBtn);
            savebtn.Click += Savebtn_Click;
            return view;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            ModalConfirmation confirmationModal = new ModalConfirmation();
            confirmationModal.dataVisible = true;
            confirmationModal.Show(ChildFragmentManager, "confirmationModal");
        }
    }
}