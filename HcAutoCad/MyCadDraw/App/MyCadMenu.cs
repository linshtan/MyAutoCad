using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Interop;

namespace MyCadDraw.App
{
    /// <summary>
    /// CAD程序的菜单
    /// </summary>
    internal class MyCadMenu
    {

        /// <summary>
        /// 查找是否包括指定的主菜单
        /// </summary>
        /// <param name="FindName"></param>
        /// <returns></returns>
        public static bool FindMainMenu(string FindName)
        {

            AcadApplication CadApp = MyCadApp.GetCadApp;

            AcadPopupMenus acadPopupMenus = CadApp.MenuGroups.Item(0).Menus;

            foreach (AcadPopupMenu hch in acadPopupMenus)
            {

                if (hch.Name == FindName) { return true; }
            }

            return false;
        }

    }
}
