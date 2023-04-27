using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.View.Menu;
using AndroidX.Fragment.App;
using Google.Android.Material.BottomSheet;
using MiBu.Adapters;
using MiBu.Models;
using System;
using System.Collections.Generic;

namespace MiBu
{
    public class FragmentMessage: Fragment
    {

        private ListView _messageListView;
        private MessageAdapter _messageAdapter;
        private Button backBtn;
        private BottomSheetBehavior bottomSheetBehavior;
        private RelativeLayout newBtnMsg;


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_messages, container, false);

            
            backBtn = (Button)view.FindViewById(Resource.Id.backBtn);
            newBtnMsg = (RelativeLayout)view.FindViewById(Resource.Id.newMsgBtn);

            FrameLayout bottomSheet = (FrameLayout)view.FindViewById(Resource.Id.bottomSheet);
            bottomSheetBehavior = BottomSheetBehavior.From(bottomSheet);
            BottomSelectProfile_2 bottomSelectProfile = new BottomSelectProfile_2();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(bottomSheet.Id, bottomSelectProfile);
            transaction.Commit();

            // Настраиваем параметры BottomSheetBehavior
            bottomSheetBehavior.Hideable = true; // Возможность скрытия BottomSheet
            bottomSheetBehavior.State = BottomSheetBehavior.StateHidden;
            List <MessageItem> items = GetMessageItems();
            _messageAdapter = new MessageAdapter(view.Context, items);
            _messageAdapter.ListItemClick += _messageAdapter_ListItemClick;
            _messageListView = (ListView)view.FindViewById(Resource.Id.messageList);
            _messageListView.Adapter = _messageAdapter;

            backBtn.Click += BackBtn_Click;
            newBtnMsg.Click += NewBtnMsg_Click;

            return view;
        }

        private void _messageAdapter_ListItemClick(int position)
        {
            FragmentChat chat = new FragmentChat();
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.workspace, chat);
            transaction.Commit();
        }

        private void NewBtnMsg_Click(object sender, EventArgs e)
        {
            bottomSheetBehavior.State = BottomSheetBehavior.StateExpanded;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FragmentHomeMenu home = new FragmentHomeMenu();
            FragmentTransaction transaction = Activity.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frame, home);
            transaction.Commit();
        }

        private List<MessageItem> GetMessageItems()
        {
            List<MessageItem> items = new List<MessageItem>
            {
                new MessageItem { Title = "Мария Васильчук", Avatar = Resource.Drawable.avatar_1, Message="Ключ от шкафчика я оставила у вас...", Time="17:00" , CountUnread = 0, isIdea = true},
                new MessageItem { Title = "Анна ГоряковаSSSS", Avatar = Resource.Drawable.avatar_1, Message="Спасибо! Это приятно слышать", Time="17:00", CountUnread = 0, isIdea = true},
                new MessageItem { Title = "Иван Сидоров", Avatar = Resource.Drawable.avatar_1, Message="Ты сможешь подменить меня 4-го ...", Time="17:00", CountUnread = 0, isIdea = false},
                new MessageItem { Title = "Алина Горина", Avatar = Resource.Drawable.avatar_1, Message="Зарплатный лист нужно подписать...", Time="17:00", CountUnread = 2, isIdea = false},
                new MessageItem { Title = "Вера Смирнова", Avatar = Resource.Drawable.avatar_1, Message="Какие обязанности на моем рабоч...", Time="17:00", CountUnread = 0, isIdea = false }
            };

            return items;
        }
    }
}