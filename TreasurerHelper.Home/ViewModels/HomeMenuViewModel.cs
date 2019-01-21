using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasurerHelper.Infrastructure;

namespace TreasurerHelper.Home.ViewModels
{
    public class HomeMenuViewModel : BindableBase
    {
        public List<MenuItem> HomeMenuItems { get; set; }

        public HomeMenuViewModel(IMenuService menuService)
        {
            HomeMenuItems = menuService.GetHomeMenuItems();
        }
    }
}
