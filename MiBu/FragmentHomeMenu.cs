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
    public class FragmentHomeMenu : Fragment
    {
        private ListView _menuListView;
        private MenuAdapter _menuAdapter;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_home_menu, container, false);

            List<MenuItem> items = GetMenuItems();
            _menuAdapter = new MenuAdapter(view.Context, items);
            _menuAdapter.ListItemClick += _menuAdapter_ListItemClick;
            _menuListView = (ListView) view.FindViewById(Resource.Id.menuListView);
            _menuListView.Adapter = _menuAdapter;

            return view;
        }

        private void _menuAdapter_ListItemClick(int position)
        {
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();

            switch (position)
            {
                case 0:
                    FragmentRaiting fragmentRaiting = new FragmentRaiting();
                    transaction.Replace(Resource.Id.frame, fragmentRaiting);
                    transaction.Commit();
                    break;
                case 1:
                    FragmentProfile fragmentProfile = new FragmentProfile();
                    transaction.Replace(Resource.Id.frame, fragmentProfile);
                    transaction.Commit();
                    break;
                case 2:
                    FragmentDestination fragmentDestination = new FragmentDestination();
                    transaction.Replace(Resource.Id.frame, fragmentDestination);
                    transaction.Commit();
                    break;
                case 3:
                    FragmentNews fragmentNews = new FragmentNews();
                    transaction.Replace(Resource.Id.frame, fragmentNews);
                    transaction.Commit();
                    break;
                case 4:
                    FragmentMessage fragmentMessage = new FragmentMessage();
                    transaction.Replace(Resource.Id.frame, fragmentMessage);
                    transaction.Commit();
                    break;
                
                // Добавьте остальные фрагменты в соответствии с вашим списком данных
                default:
                    break;
            }

        }

        //Загружаем данные
        private List<MenuItem> GetMenuItems()
        {
            List<MenuItem> items = new List<MenuItem>
            {
                new MenuItem { Title = "Рейтинг", Icon = Resource.Mipmap.chart },
                new MenuItem { Title = "Профили", Icon = Resource.Mipmap.profile},
                new MenuItem { Title = "Назначения", Icon = Resource.Mipmap.vector },
                new MenuItem { Title = "Новости", Icon = Resource.Mipmap.notification },
                new MenuItem { Title = "Сообщения", Icon = Resource.Mipmap.sms }
            };

            return items;
        }
    }
}