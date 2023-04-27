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
using static Android.Graphics.ColorSpace;

namespace MiBu
{
    public class FragmentRaiting: Fragment
    {
        private ListView _menuListView;
        private MenuAdapter _menuAdapter;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_raiting, container, false);
            LinearLayout openFilter = (LinearLayout)view.FindViewById(Resource.Id.openFilter);
            Button backBtn = (Button)view.FindViewById(Resource.Id.backBtn);

            backBtn.Click += BackBtn_Click;
            openFilter.Click += openFilterClick;
            //TableLayout tableLayout = (TableLayout) view.FindViewById(Resource.Id.tableLayout);
            /*
            List<TableItem> tableItems = new List<TableItem>
            {
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 },
                new TableItem { Avatar = Resource.Drawable.avatar_1, FIO = "Мария Иванова", Position = "Официант", Address = "Koffein, г. Нальчик, ул. Ленина 145", Level = 34, Coin = 2000, Karma = 100, GeneralKarma = 399 }
            };

            foreach (TableItem item in tableItems)
            {
                TableRow row = new TableRow(view.Context);
                TableRow.LayoutParams rowParams = new TableRow.LayoutParams(TableRow.LayoutParams.WrapContent, TableRow.LayoutParams.WrapContent);
                

                rowParams.MarginStart = 100;
                rowParams.MarginEnd = 100;

                row.SetGravity(GravityFlags.Center);
                row.SetPadding(20, 20, 20, 20);
                row.LayoutParameters = rowParams;
                
                TextView fioTV = new TextView(view.Context);
                fioTV.Text = item.FIO;
                fioTV.SetTextAppearance(Resource.Style.baseText);
                row.AddView(fioTV);


                TextView positionTV = new TextView(view.Context);
                positionTV.Text = item.Position;
                positionTV.SetMaxWidth(80);
                positionTV.SetTextAppearance(Resource.Style.baseText);
                row.AddView(positionTV);




                tableLayout.AddView(row);


            }
            */

            return view;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FragmentHomeMenu home = new FragmentHomeMenu();
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, home);
            transaction.Commit();
        }

        private void openFilterClick(object sender, EventArgs e)
        {
            FilterModal filterModal = new FilterModal();
            filterModal.Show(ChildFragmentManager, "filterModal");
        }

    }
}