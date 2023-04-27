using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MiBu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using static Android.Provider.ContactsContract;
using Context = Android.Content.Context;

namespace MiBu.Adapters
{
    internal class MenuAdapter : BaseAdapter<MenuItem>
    {
        private List<MenuItem> _items;
        private Context _context;
        public delegate void ListItemClickEventHandler(int position);
        public event ListItemClickEventHandler ListItemClick;

        public MenuAdapter(Context context, List<MenuItem> items)
        {
            _context = context;
            _items = items;
        }

        public override MenuItem this[int position] => _items[position];

        public override int Count => _items.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        [Obsolete]
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
            {
                LayoutInflater inflater = (LayoutInflater)_context.GetSystemService(Context.LayoutInflaterService);
                view = inflater.Inflate(Resource.Layout.list_menu_item, null);
            }

            // Настройка элемента списка на основе модели
            MenuItem item = _items[position];
            TextView menuTitle = view.FindViewById<TextView>(Resource.Id.menuTitle);
            ImageView menuIcon = view.FindViewById<ImageView>(Resource.Id.menuIcon);

            menuTitle.Text = item.Title;
            menuIcon.SetImageResource(item.Icon);

            view.Click += (sender, e) =>
            {
                ListItemClick?.Invoke(position);
            };

            return view;
        }

    }
}