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
using MiBu.Adapters;
using AndroidX.AppCompat.View.Menu;
using MiBu.Models;

namespace MiBu
{
    public class BottomSelectProfile : Fragment
    {

        private ListView _listView;
        private ProfileBottomSelectAdapter _profileBottomSelectAdapter;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.botttom_select_profile, container, false);

            

            return view;
        }

       
    }
}