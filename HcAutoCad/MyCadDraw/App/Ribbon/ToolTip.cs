using Autodesk.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCadDraw.App.Ribbon
{
    internal class ToolTip
    {
        /// <summary>
        /// 获取或设置按钮帮助文档
        /// </summary>
        public RibbonToolTip RibToolTip { get; set; } = new RibbonToolTip();

        /// <summary>
        /// 获取或设置标题
        /// </summary>
        public string Title { get => RibToolTip.Title; set => RibToolTip.Title = value; }

        /// <summary>
        /// 设置帮助文档内容
        /// </summary>
        public string Content { set => RibToolTip.Content = value; }

        /// <summary>
        /// 获取或设置命令说明
        /// </summary>
        public string Command { get => RibToolTip.Command; set => RibToolTip.Command = value; }

        /// <summary>
        /// 设置帮助文档内容说明
        /// </summary>
        public string ExpandedContent { set => RibToolTip.ExpandedContent = value; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">文档内容</param>
        /// <param name="command">命令说明</param>
        /// <param name="expandedcontent">文档内容说明</param>
        public ToolTip(string title="MyToolTip", string content="这是默认设置", string command="mytooltip", string expandedcontent= "这是默认设置，请按实际填写")
        {
            RibToolTip = new RibbonToolTip
            {
                Title = title,
                Content = content,
                Command = command,
                ExpandedContent = expandedcontent
            };
        }




    }
}
