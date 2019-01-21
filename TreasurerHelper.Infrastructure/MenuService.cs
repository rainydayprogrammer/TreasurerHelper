using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasurerHelper.Infrastructure
{
    public class MenuService : IMenuService
    {

        List<MenuItem> MainMenuItems { get; set; }
        List<MenuItem> HomeMenuItems { get; set; }

        public MenuService()
        {
            MainMenuItems = new List<MenuItem>();
            HomeMenuItems = new List<MenuItem>();
        }


        public List<MenuItem> GetMainMenuItems()
        {
            return MainMenuItems;
        }

        public List<MenuItem> GetHomeMenuItems()
        {
            return HomeMenuItems;
        }

        public void AddMainMenuItem(MenuItem menuItem)
        {
            MainMenuItems.Add(menuItem);
            if (menuItem.DisplayOnHome)
            {
                HomeMenuItems.Add(menuItem);
            }
        }
    }
}
