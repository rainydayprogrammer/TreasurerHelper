using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasurerHelper.Infrastructure
{
    public interface IMenuService
    {
        List<MenuItem> GetMainMenuItems();

        void AddMainMenuItem(MenuItem menuItem);
    }
}
