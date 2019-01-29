using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prism.Interactivity.InteractionRequest;

namespace TreasurerHelper.Infrastructure.Controls
{
    /// <summary>
    /// CustomPopupView.xaml の相互作用ロジック
    /// </summary>
    public partial class CustomPopupView : UserControl, IInteractionRequestAware
    {
        public CustomPopupView()
        {
            InitializeComponent();
            //Loaded += CustomPopupView_Loaded;
        }

        //private void CustomPopupView_Loaded(object sender, RoutedEventArgs e)
        //{
        //    var parentWindow = this.Parent as Window;
        //    if (parentWindow != null)
        //    {
        //        parentWindow.WindowStyle = WindowStyle.None;
        //        parentWindow.ShowInTaskbar = false;
        //        parentWindow.SizeToContent = SizeToContent.WidthAndHeight;
        //        parentWindow.Background = Brushes.Transparent;
        //        parentWindow.AllowsTransparency = true;
        //        parentWindow.ResizeMode = ResizeMode.NoResize;
        //    }
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FinishInteraction?.Invoke();
        }

        public Action FinishInteraction { get; set; }
        public INotification Notification { get; set; }
    }
}
