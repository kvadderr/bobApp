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
    public class BottomSelectProfile_2 : Fragment
    {

        private ListView _listView;
        private ProfileBottomSelectAdapter _profileBottomSelectAdapter;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.botttom_select_profile_2, container, false);

            List<ProfileItem> items = GetMenuItems();
            _profileBottomSelectAdapter = new ProfileBottomSelectAdapter(view.Context, items);
            _profileBottomSelectAdapter.ListItemClick += _profileBottomSelectAdapter_ListItemClick;
            _listView = (BottomSheetListView) view.FindViewById(Resource.Id.listView);
            _listView.Adapter = _profileBottomSelectAdapter;

            return view;
        }

        private List<ProfileItem> GetMenuItems()
        {
            List<ProfileItem> items = new List<ProfileItem>
            {
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Андрей Суздальцев", Job = "Управляющий"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Анна Горякова", Job = "Управляющий"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Светлана Зотикова", Job = "Бухгалтер"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Марина Анищенко", Job = "Управляющий"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Иван Сидоров", Job = "Менеджер"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Светлана Зотикова", Job = "Бариста"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Валерия Румянцева", Job = "Официант"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Жанна Одинцова", Job = "Стажер"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Андрей Суздальцев", Job = "Официант"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Анна Горякова", Job = "Официант"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Светлана Зотикова", Job = "Официант"},
                new ProfileItem { Avatar = Resource.Drawable.avatar_1, FIO = "Марина Анищенко", Job = "Официант"},
            };

            return items;
        }

        private void _profileBottomSelectAdapter_ListItemClick(int position)
        {
            throw new NotImplementedException();
        }
    }
}