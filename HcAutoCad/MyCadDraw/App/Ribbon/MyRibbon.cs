using Autodesk.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCadDraw.App.Ribbon
{
    public class MyRibbon
    {
        ///private readonly RibbonControl RibCon = new RibbonControl();

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

        public MyRibbon()
        {
            ///RibCon = GetCadRibbon;

        }

        public static RibbonPanelSource AddPanel(string Title)
        {
            MyRibbonTab myRibbonTab = new MyRibbonTab();
            return myRibbonTab.AddPanel(Title);
        }

        public static void AddButton(RibbonPanelSource ribbonPanelSource, string Title)
        {
            MyRibbonPanelSource myRibbonPanelSource = new MyRibbonPanelSource
            {
                RibPanel = ribbonPanelSource
            };
            MyRibbonButton addButton = new MyRibbonButton
            {
                Text = Title
            };
            myRibbonPanelSource.AddButton(addButton);
        }





    }
}
