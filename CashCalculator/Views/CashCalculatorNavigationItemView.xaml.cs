using System.Windows.Controls;
using Prism.Ioc;
using Prism.Regions;

namespace CashCalculator.Views
{
    /// <summary>
    /// Interaction logic for CashCalculatorNavigationItemView
    /// </summary>
    public partial class CashCalculatorNavigationItemView : UserControl
    {
        IContainerExtension _container;
        IRegionManager _regionManager;

        public CashCalculatorNavigationItemView(IContainerExtension container, IRegionManager regionManager)
        {
            InitializeComponent();
            _container = container;
            _regionManager = regionManager;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var view = _container.Resolve<CashCalculator>();
            IRegion region = _regionManager.Regions["ContentRegion"];
            region.Add(view);
            region.Activate(view);
        }
    }
}
