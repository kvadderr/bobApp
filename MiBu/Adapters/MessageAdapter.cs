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
    internal class MessageAdapter : BaseAdapter<MessageItem>
    {
        private List<MessageItem> _items;
        private Context _context;
        public delegate void ListItemClickEventHandler(int position);
        public event ListItemClickEventHandler ListItemClick;

        public MessageAdapter(Context context, List<MessageItem> items)
        {
            _context = context;
            _items = items;
        }

        public override MessageItem this[int position] => _items[position];

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
                view = inflater.Inflate(Resource.Layout.item_message, null);
            }

            // Настройка элемента списка на основе модели
            MessageItem item = _items[position];
            TextView msgTitle = view.FindViewById<TextView>(Resource.Id.titleMSG);
            TextView msgMessage = view.FindViewById<TextView>(Resource.Id.messageMSG);
            TextView additionalTV = view.FindViewById<TextView>(Resource.Id.additionalTV);
            TextView msgTime= view.FindViewById<TextView>(Resource.Id.timeMSG);
            ImageView msgAdditional = view.FindViewById<ImageView>(Resource.Id.additionalMSG);
            ImageView msgAvatar = view.FindViewById<ImageView>(Resource.Id.avatarMSG);


            if (item.isIdea == true) msgAdditional.SetImageResource(Resource.Mipmap.idea);
            if (item.CountUnread > 0) {
                additionalTV.Visibility = ViewStates.Visible;
                additionalTV.Text = item.CountUnread.ToString();
            }

            msgTitle.Text = item.Title;
            msgAvatar.SetImageResource(item.Avatar);
            msgMessage.Text = item.Message;
            msgTime.Text = item.Time;

            view.Click += (sender, e) =>
            {
                ListItemClick?.Invoke(position);
            };

            return view;
        }

    }
}