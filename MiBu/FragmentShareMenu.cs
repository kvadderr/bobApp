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
using MiBu.Models;
using MiBu.Adapters;
using static Android.Provider.ContactsContract;

namespace MiBu
{
    public class FragmentShareMenu : Fragment
    {
        private ListView _menuListView;
        private MenuAdapter _menuAdapter;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_share_menu, container, false);

            List<MenuItem> items = GetMenuItems();
            _menuAdapter = new MenuAdapter(view.Context, items);
            _menuAdapter.ListItemClick += _menuAdapter_ListItemClick;
            _menuListView = (ListView)view.FindViewById(Resource.Id.menuListView);
            _menuListView.Adapter = _menuAdapter;

            return view;
        }

        private void _menuAdapter_ListItemClick(int position)
        {
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();

            if (position == 2)
            {
                FragmentPromotion fragmentPromotion = new FragmentPromotion();
                transaction.Replace(Resource.Id.shareFrame, fragmentPromotion);
                transaction.Commit();
                return;
            }
            FragmentTest fragmentTest = new FragmentTest();
            fragmentTest.Sub = GetMenuItems()[position].Title;
            transaction.Replace(Resource.Id.shareFrame, fragmentTest);
            transaction.Commit();

        }

        //Загружаем данные
        private List<MenuItem> GetMenuItems()
        {
            List<MenuItem> items = new List<MenuItem>
            {
                new MenuItem { Title = "Тестирование", Icon = Resource.Mipmap.test },
                new MenuItem { Title = "Библиотека", Icon = Resource.Mipmap.book},
                new MenuItem { Title = "Повышение", Icon = Resource.Mipmap.rise },
            };

            return items;
        }
    }
}