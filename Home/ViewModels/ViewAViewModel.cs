using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasurerHelper.Infrastructure;

namespace Home.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public List<MenuItem> MainMenuItems { get; set; } 
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(IMenuService menuService)
        {
            MainMenuItems = menuService.GetMainMenuItems();
            Message = "Home Module";
        }
    }
}
