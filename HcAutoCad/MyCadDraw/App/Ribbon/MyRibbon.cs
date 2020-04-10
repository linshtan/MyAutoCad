using Autodesk.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCadDraw.App.Ribbon
{
    internal class MyRibbon
    {

        /// <summary>
        /// 获取cad的Ribbon界面
        /// </summary>
        public static RibbonControl GetCadRibbon
        {
            get
            {
                return ComponentManager.Ribbon;
            }
        }

        



    }
}
