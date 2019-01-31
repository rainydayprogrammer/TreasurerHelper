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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FinishInteraction?.Invoke();
        }

        public Action FinishInteraction { get; set; }
        public INotification Notification { get; set; }
    }
}
