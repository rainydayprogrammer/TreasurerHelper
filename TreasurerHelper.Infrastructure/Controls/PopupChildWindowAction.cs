using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using System;
using System.Windows;
using System.Windows.Media;

namespace TreasurerHelper.Infrastructure.Controls
{
    // 元ネタ
    // https://stackoverflow.com/questions/35660684/wpfprism-how-to-make-the-popup-window-owner-as-main-window
    public class PopupChildWindowAction : PopupWindowAction
    {
        public static readonly DependencyProperty WindowOwnerProperty = DependencyProperty.Register(
       "WindowOwner", typeof(Window), typeof(PopupChildWindowAction), new PropertyMetadata(default(Window)));

        public Window WindowOwner
        {
            get { return (Window)GetValue(WindowOwnerProperty); }
            set { SetValue(WindowOwnerProperty, value); }
        }

        protected override Window GetWindow(INotification notification)
        {
            Window wrapperWindow;
            if (this.WindowContent != null)
            {
                wrapperWindow = this.CreateWindow();
                if (wrapperWindow == null)
                    throw new NullReferenceException("CreateWindow cannot return null");

                wrapperWindow.Owner = WindowOwner;
                wrapperWindow.DataContext = (object)notification;
                wrapperWindow.Title = notification.Title;
                this.PrepareContentForWindow(notification, wrapperWindow);
            }
            else
                wrapperWindow = this.CreateDefaultWindow(notification);

            wrapperWindow.WindowStyle = System.Windows.WindowStyle.None;
            wrapperWindow.AllowsTransparency = true;
            wrapperWindow.Background = Brushes.Transparent;
            wrapperWindow.ShowInTaskbar = false;
            wrapperWindow.ResizeMode = ResizeMode.NoResize;
            wrapperWindow.SizeToContent = SizeToContent.WidthAndHeight;

            return wrapperWindow;
        }
    }
}
