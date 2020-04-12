using Autodesk.Windows;
using MyCadDraw.global;
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

        #region 属性定义

        /// <summary>
        /// 获取或设置选项卡
        /// </summary>
        public RibbonTab RibTab { set; get; }

        /// <summary>
        /// 获取或设置当前选项卡是否置于当前
        /// </summary>
        public bool IsActive { get => RibTab.IsActive; set => RibTab.IsActive = value; }

        /// <summary>
        /// 获取或设置选项卡的名字
        /// </summary>
        public string Name { set => RibTab.Name = value; get => RibTab.Name; }

        /// <summary>
        /// 获取或设置选项卡的标题
        /// </summary>
        public string Title { get => RibTab.Title; set => RibTab.Title = value; }

        /// <summary>
        /// 获取或设置选项卡是否可用
        /// </summary>
        public bool IsEnabled { get => RibTab.IsEnabled; set => RibTab.IsEnabled = value; }

        /// <summary>
        /// 获取或设置选项卡是否显示 
        /// </summary>
        public bool IsVisible { get => RibTab.IsVisible; set => RibTab.IsVisible = value; }

        /// <summary>
        /// 获取或设置选项卡的面板是否可用
        /// </summary>
        public bool IsPanelEnabled { set => RibTab.IsPanelEnabled = value; get => RibTab.IsPanelEnabled; }

        /// <summary>
        /// 获取或设置选项卡的高度
        /// </summary>
        public Autodesk.Internal.Windows.HighlightMode Highlight { set => RibTab.Highlight = value; get => RibTab.Highlight; }

        /// <summary>
        /// 获取选项卡Id
        /// </summary>
        public string Id { get => RibTab.Id; }

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Name">选项卡名称</param>
        public MyRibbonTab(string Name)
        {

            RibTab = new RibbonTab
            {
                IsActive = true,
                Name = Name,
                Title = Name,
                IsEnabled = true,
                IsVisible = true,
                IsPanelEnabled = true,
                Highlight = Autodesk.Internal.Windows.HighlightMode.New,
            };



        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public MyRibbonTab()
        {

            RibTab = new RibbonTab
            {
                IsActive = true,
                Name = RibbonDefault.RibbonTabName,
                Title = RibbonDefault.RibbonTabName,
                IsEnabled = true,
                IsVisible = true,
                IsPanelEnabled = true,
                Highlight = Autodesk.Internal.Windows.HighlightMode.New,
            };



        }

        public RibbonPanelSource AddPanel(string Title)
        {
            RibbonPanel ribbonPanel = new RibbonPanel();
            MyRibbonPanelSource ReValue = new MyRibbonPanelSource
            {
                Title = Title
            };
            ribbonPanel.Source = ReValue.RibPanel;

            RibTab.Panels.Add(ribbonPanel);

            return ReValue.RibPanel;
        }



    }
}
