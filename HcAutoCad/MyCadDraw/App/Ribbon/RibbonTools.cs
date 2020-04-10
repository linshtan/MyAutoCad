using System.Windows.Controls;
using Autodesk.Windows;

namespace MyCadDraw.App.Ribbon
{
    internal static class RibbonTools
    {

        #region Ribbon查找相关

        /// <summary>
        /// 通过名字，判断Ribbon中是否包含指定的选项卡
        /// </summary>
        /// <param name="FindName">选项卡名称</param>
        /// <returns></returns>
        public static bool IsRibbonFromName(string FindName)
        {
            RibbonControl CadRib = MyRibbon.GetCadRibbon;

            foreach (RibbonTab hch in CadRib.Tabs)
            {
                if (hch.Name == FindName) { return true; }
            }

            return false;
        }

        /// <summary>
        /// 通过Id，判断Ribbon中是否包含指定的选项卡
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static bool IsRibbonFromID(string Id)
        {
            RibbonControl CadRib = MyRibbon.GetCadRibbon;

            foreach (RibbonTab hch in CadRib.Tabs)
            {
                if (hch.Id == Id) { return true; }
            }

            return false;
        }

        /// <summary>
        /// 通过Title，判断Ribbon中是否包含指定的选项卡
        /// </summary>
        /// <param name="Title"></param>
        /// <returns></returns>
        public static bool IsRibbonFromTitle(string Title)
        {
            RibbonControl CadRib = MyRibbon.GetCadRibbon;

            foreach (RibbonTab hch in CadRib.Tabs)
            {
                if (hch.Title == Title) { return true; }
            }

            return false;
        }

        /// <summary>
        /// 通过名字查找相应的选项卡
        /// </summary>
        /// <param name="FindName">选项卡名字</param>
        /// <returns>查找到的选项卡或null</returns>
        public static RibbonTab FindRibbonFromName(string FindName)
        {
            RibbonControl CadRib = MyRibbon.GetCadRibbon;

            foreach (RibbonTab hch in CadRib.Tabs)
            {
                if (hch.Name == FindName) { return hch; }
            }

            return null;
        }

        /// <summary>
        /// 通过Id查找相应的选项卡
        /// </summary>
        /// <param name="Id">选项卡Id</param>
        /// <returns>查找到的选项卡或null</returns>
        public static RibbonTab FindRibbonFromId(string Id)
        {
            RibbonControl CadRib = MyRibbon.GetCadRibbon;

            foreach (RibbonTab hch in CadRib.Tabs)
            {
                if (hch.Id == Id) { return hch; }
            }

            return null;
        }

        /// <summary>
        /// 通过Title查找相应的选项卡
        /// </summary>
        /// <param name="Title">选项卡Title</param>
        /// <returns>查找到的选项卡或null</returns>
        public static RibbonTab FindRibbonFromTitle(string Title)
        {
            RibbonControl CadRib = MyRibbon.GetCadRibbon;

            foreach (RibbonTab hch in CadRib.Tabs)
            {
                if (hch.Title == Title) { return hch; }
            }

            return null;
        }


        #endregion

        /// <summary>
        /// 添加Ribbon选项卡
        /// </summary>
        /// <param name="ribbonCtrl">Ribbon控制器</param>
        /// <param name="title">选项卡标题</param>
        /// <param name="ID">选项卡ID</param>
        /// <param name="isActive">是否置为当前</param>
        /// <returns>RibbonTab</returns>
        public static RibbonTab AddTab(this RibbonControl ribbonCtrl, string title, string ID, bool isActive)
        {
            RibbonTab tab = new RibbonTab
            {
                Title = title,
                Id = ID
            };
            ribbonCtrl.Tabs.Add(tab);
            tab.IsActive = isActive;
            return tab;
        }

        /// <summary>
        /// 添加面板
        /// </summary>
        /// <param name="tab">Ribbon选项卡</param>
        /// <param name="title">面板标题</param>
        /// <returns>RibbonPanelSource</returns>
        public static RibbonPanelSource AddPanel(this RibbonTab tab, string title)
        {
            RibbonPanelSource panelSource = new RibbonPanelSource
            {
                Title = title
            };
            RibbonPanel ribbonPanel = new RibbonPanel
            {
                Source = panelSource
            };
            tab.Panels.Add(ribbonPanel);
            return panelSource;
        }


        /// <summary>
        /// 给面板添加下拉组合按钮
        /// </summary>
        /// <param name="panelSource"></param>
        /// <param name="text"></param>
        /// <param name="size"></param>
        /// <param name="orient"></param>
        /// <returns></returns>
        public static RibbonSplitButton AddSplitButton(this RibbonPanelSource panelSource, string text, RibbonItemSize size, Orientation orient)
        {
            RibbonSplitButton splitBtn = new RibbonSplitButton
            {
                Text = text,
                ShowText = true,
                Size = size,
                ShowImage = true,
                Orientation = orient
            };
            panelSource.Items.Add(splitBtn);
            return splitBtn;
        }

    }
}
