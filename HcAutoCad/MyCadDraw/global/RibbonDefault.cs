using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCadDraw.Properties;

namespace MyCadDraw.global
{

    /// <summary>
    /// Ribbon的默认值
    /// </summary>
    internal class RibbonDefault
    {
        #region Button

        /// <summary>
        /// 按钮的默认命令
        /// </summary>
        public const string RibButtonOrder = "MyButton";


        /// <summary>
        /// 选项卡的按钮默认名称
        /// </summary>
        public static string RibButtonName = Resources.RibButtonName;

        #endregion

        #region ToolTip

        /// <summary>
        /// 选项卡中按钮的帮助显示内容
        /// </summary>
        public static string RibToolTipContent = Resources.RibToolTipContent;

        /// <summary>
        /// 选项卡中按钮的帮助显示内容说明
        /// </summary>
        public static string RibToolTipExpandedContent = Resources.RibToolTipExpandedContent;

        /// <summary>
        /// 选项卡中按钮的帮助显示标题
        /// </summary>
        public static string RibToolTipTitle = Resources.RibToolTipTitle;

        #endregion

        #region PanelSource

        /// <summary>
        /// 选项卡面板名称
        /// </summary>
        public static string RibbonPanelSourceName = Resources.RibbonPanelSourceName;

        #endregion

        #region RibbonTab

        /// <summary>
        /// 选项卡名称
        /// </summary>
        public static string RibbonTabName = Resources.RibbonTabName;

        #endregion


    }

}
