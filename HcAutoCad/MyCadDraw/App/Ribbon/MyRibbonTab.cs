using Autodesk.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCadDraw.App.Ribbon
{
    /// <summary>
    /// 选项卡
    /// </summary>
    internal class MyRibbonTab
    {
        public MyRibbonTab()
        {

            RibTab = new RibbonTab
            {
                IsActive = true,
                Name = "",
                Title = "",
                IsEnabled = true,
                IsVisible = true,
                IsPanelEnabled = true,
                Highlight = Autodesk.Internal.Windows.HighlightMode.New
                
            };

        }

        /// <summary>
        /// 获取或设置选项卡
        /// </summary>
        public RibbonTab RibTab { set; get; }

    }
}
