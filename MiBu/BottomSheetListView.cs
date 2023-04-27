using Android.App;
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
    public class BottomSheetListView : ListView
    {
        public BottomSheetListView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public override bool OnInterceptTouchEvent(MotionEvent ev)
        {
            return true;
        }

        public override bool OnTouchEvent(MotionEvent ev)
        {
            if (CanScrollVertically(this))
            {
                Parent.RequestDisallowInterceptTouchEvent(true);
            }
            return base.OnTouchEvent(ev);
        }

        public bool CanScrollVertically(AbsListView view)
        {
            bool canScroll = false;

            if (view != null && view.ChildCount > 0)
            {
                bool isOnTop = view.FirstVisiblePosition != 0 || view.GetChildAt(0).Top != 0;
                bool isAllItemsVisible = isOnTop && view.LastVisiblePosition == view.ChildCount;

                if (isOnTop || isAllItemsVisible)
                {
                    canScroll = true;
                }
            }

            return canScroll;
        }
    }
}