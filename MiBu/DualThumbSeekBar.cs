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
    public class DualThumbSeekBar: SeekBar
    {
        int ThumbOffsetDelta = 1;
        public DualThumbSeekBar(Context context) : base(context)
        {
            Initialize();
        }

        public DualThumbSeekBar(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Initialize();
        }

        public DualThumbSeekBar(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            Initialize();
        }

        private void Initialize()
        {
            // Настройка компонента, если требуется
            // Например, установка макета или стилей
        }

            public override bool OnTouchEvent(MotionEvent e)
            {
                int pointerIndex;
                MotionEventActions action = e.Action;
                float x;
                float progress;

                switch (action & MotionEventActions.Mask)
                {
                    case MotionEventActions.Down:
                        pointerIndex = e.FindPointerIndex(e.ActionIndex);
                        x = e.GetX(pointerIndex);
                        progress = Max * x / Width;
                        if (Math.Abs(progress - Progress) < Math.Abs(SecondaryProgress - Progress))
                        {
                            // Передвигаем первый ползунок
                            ThumbOffset = ThumbOffset - ThumbOffsetDelta;
                        }
                        else
                        {
                            // Передвигаем второй ползунок
                            ThumbOffset = ThumbOffset + ThumbOffsetDelta;
                        }
                        break;
                    case MotionEventActions.Move:
                        // Обновляем положение ползунков
                        pointerIndex = e.FindPointerIndex(e.ActionIndex);
                        x = e.GetX(pointerIndex);
                        progress = Max * x / Width;
                        if (Math.Abs(progress - Progress) < Math.Abs(SecondaryProgress - Progress))
                        {
                            // Передвигаем первый ползунок
                            ThumbOffset = ThumbOffset - ThumbOffsetDelta;
                        }
                        else
                        {
                            // Передвигаем второй ползунок
                            ThumbOffset = ThumbOffset + ThumbOffsetDelta;
                        }
                        break;
                    case MotionEventActions.Up:
                        // Обработка отпускания касания
                        // Можно добавить дополнительную логику
                        break;

                    default: break;
                }

                return true;
            }
    }
}