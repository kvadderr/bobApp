using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
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
    internal class ProfileBottomSelectAdapter : BaseAdapter<ProfileItem>
    {
        private List<ProfileItem> _items;
        private Context _context;
        public delegate void ListItemClickEventHandler(int position);
        public event ListItemClickEventHandler ListItemClick;

        public ProfileBottomSelectAdapter(Context context, List<ProfileItem> items)
        {
            _context = context;
            _items = items;
        }

        public override ProfileItem this[int position] => _items[position];

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
                view = inflater.Inflate(Resource.Layout.item_profile_select_bottom, null);
            }

            // Настройка элемента списка на основе модели
            ProfileItem item = _items[position];
            TextView FIO = view.FindViewById<TextView>(Resource.Id.FIO);
            TextView job = view.FindViewById<TextView>(Resource.Id.job);
            ImageView avatar = view.FindViewById<ImageView>(Resource.Id.avatar);
            LinearLayout itemLayout = view.FindViewById<LinearLayout>(Resource.Id.itemLayout);

            if (item.Job == "Управляющий" || item.Job == "Бухгалтер" || item.Job == "Менеджер") itemLayout.SetBackgroundDrawable(ContextCompat.GetDrawable(_context, Resource.Drawable.gray_bg));

            FIO.Text = item.FIO;
            job.Text = item.Job;
            avatar.SetImageResource(item.Avatar);

            view.Click += (sender, e) =>
            {
                ListItemClick?.Invoke(position);
            };

            return view;
        }

    }
}