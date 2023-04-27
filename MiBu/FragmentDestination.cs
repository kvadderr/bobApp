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
using MiBu.Models;

namespace MiBu
{
    public class FragmentDestination : Fragment
    {
        private ListView _menuListView;
        private MenuAdapter _menuAdapter;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_destination, container, false);

            List<MenuItem> items = GetMenuItems();
            _menuAdapter = new MenuAdapter(view.Context, items);
            _menuAdapter.ListItemClick += _menuAdapter_ListItemClick;
            _menuListView = (ListView)view.FindViewById(Resource.Id.menuListView);
            Button backBtn = (Button)view.FindViewById(Resource.Id.backBtn);

            backBtn.Click += BackBtn_Click;
            _menuListView.Adapter = _menuAdapter;

            return view;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FragmentHomeMenu home = new FragmentHomeMenu();
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, home);
            transaction.Commit();
        }

        private void _menuAdapter_ListItemClick(int position)
        {
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();

            switch (position)
            {
                case 0:
                    FragmentCreateTask createTask = new FragmentCreateTask();
                    createTask.dataVisible = true;
                    transaction.Replace(Resource.Id.frame, createTask);
                    transaction.Commit();
                    break;
                case 1:
                    FragmentAchievement fragmentAchievement = new FragmentAchievement();
                    fragmentAchievement.dataVisible= true;
                    transaction.Replace(Resource.Id.frame, fragmentAchievement);
                    transaction.Commit();
                    break;
                case 2:
                    FragmentTest fragmentTest = new FragmentTest();
                    transaction.Replace(Resource.Id.frame, fragmentTest);
                    transaction.Commit();
                    break;
                case 3:
                    FragmentShare fragmentShare = new FragmentShare();
                    transaction.Replace(Resource.Id.frame, fragmentShare);
                    transaction.Commit();
                    break;
                case 4:
                    FragmentPromotion fragmentPromotion = new FragmentPromotion();
                    transaction.Replace(Resource.Id.frame, fragmentPromotion);
                    transaction.Commit();
                    break;
                default:
                    break;
            }

        }

        //Загружаем данные
        private List<MenuItem> GetMenuItems()
        {
            List<MenuItem> items = new List<MenuItem>
            {
                new MenuItem { Title = "Задача", Icon = Resource.Mipmap.new_task },
                new MenuItem { Title = "Достижения", Icon = Resource.Mipmap.cup},
                new MenuItem { Title = "Тестирование", Icon = Resource.Mipmap.test},
                new MenuItem { Title = "Библиотека", Icon = Resource.Mipmap.book},
                new MenuItem { Title = "Повышение", Icon = Resource.Mipmap.rise }
            };

            return items;
        }
    }
}