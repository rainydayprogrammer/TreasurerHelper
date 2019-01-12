using System.Windows.Controls;
using Prism.Ioc;
using Prism.Regions;

namespace Home.Views
{
    /// <summary>
    /// Interaction logic for HomeItemView
    /// </summary>
    public partial class HomeItemView : UserControl
    {
        IContainerExtension _container;
        IRegionManager _regionManager;

        public HomeItemView(IContainerExtension container, IRegionManager regionManager)
        {
            InitializeComponent();
            _container = container;
            _regionManager = regionManager;
        }

        private void Home_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var view = _container.Resolve<ViewA>();
            IRegion region = _regionManager.Regions["ContentRegion"];
            region.Add(view);
            region.Activate(view);
        }
    }
}
