using System;
using Autodesk.Windows;
using MyCadDraw.global;

namespace MyCadDraw.App.Ribbon
{
    /// <summary>
    /// Ribbon面板
    /// </summary>
    internal class MyRibbonPanelSource
    {

        /// <summary>
        /// 获取或设置面板
        /// </summary>
        public RibbonPanelSource RibPanel { get; set; }

        /// <summary>
        /// 获取或设置面板的名称
        /// </summary>
        public string Name { get => RibPanel.Name; set => RibPanel.Name = value; }

        /// <summary>
        /// 获取或设置面板的标题
        /// </summary>
        public string Title { get => RibPanel.Title; set => RibPanel.Title = value; }

        /// <summary>
        /// 获取面板Id
        /// </summary>
        public string Id { get => RibPanel.Id; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Name">面板名称</param>
        public MyRibbonPanelSource(string Name) => RibPanel = new RibbonPanelSource
        {
            Name = Name,
            Title = Name
        };

        /// <summary>
        /// 构造函数
        /// </summary>
        public MyRibbonPanelSource() => RibPanel = new RibbonPanelSource
        {
            Name = RibbonDefault.RibbonPanelSourceName,
            Title = RibbonDefault.RibbonPanelSourceName
        };

        /// <summary>
        /// 是否包含指定的按钮
        /// </summary>
        /// <param name="FindName">要查找的按钮名字</param>
        /// <returns></returns>
        public bool HasButton(string FindName)
        {
            if (FindName == string.Empty) { return false; }

            foreach (RibbonButton hch in RibPanel.Items)
            {
                if (hch.Name == FindName) { return true; }
            }
            return false;
        }

        /// <summary>
        /// 在指定的面板中是否包含指定名称的按钮
        /// </summary>
        /// <param name="FindPanel">在查找的面板</param>
        /// <param name="FindName">要查找的按钮名字</param>
        /// <returns></returns>
        public static bool HasButton(MyRibbonPanelSource FindPanel, string FindName)
        {
            if (FindName == string.Empty) { return false; }

            foreach (RibbonButton hch in FindPanel.RibPanel.Items)
            {
                if (hch.Name == FindName) { return true; }
            }
            return false;

        }

        /// <summary>
        /// 在面板中增加按钮
        /// </summary>
        /// <param name="AddValue"></param>
        /// <returns></returns>
        public bool AddButton(MyRibbonButton AddValue)
        {
            try
            {
                RibPanel.Items.Add(AddValue.RibButton);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
