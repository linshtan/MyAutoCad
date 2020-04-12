using Autodesk.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using MyCadDraw.global;

namespace MyCadDraw.App.Ribbon
{
    /// <summary>
    /// 选项卡按钮
    /// </summary>
    internal class MyRibbonButton
    {

        #region 属性定义

        /// <summary>
        /// 正常显示图片
        /// </summary>
        public string ImgFileName { get; set; } = "";

        /// <summary>
        /// 鼠标进入时显示图片
        /// </summary>
        public string ImgHoverFileName { get; set; } = "";

        /// <summary>
        /// 获取或设置选项卡按钮
        /// </summary>
        public RibbonButton RibButton { get; set; } = new RibbonButton();

        /// <summary>
        /// 是否显示图片
        /// </summary>
        public bool ShowImage { get => RibButton.ShowImage; set => RibButton.ShowImage = value; }

        /// <summary>
        /// 是否显示按钮文本
        /// </summary>
        public bool ShowText { get => RibButton.ShowText; set => RibButton.ShowText = value; }


        /// <summary>
        /// 是否显示提示文本
        /// </summary>
        public bool ShowToolTipOnDisabled { get => RibButton.ShowToolTipOnDisabled; set => RibButton.ShowToolTipOnDisabled = value; }


        /// <summary>
        /// 选项卡按钮是否当前
        /// </summary>
        public bool IsActive { get => RibButton.IsActive; set => RibButton.IsActive = value; }


        /// <summary>
        /// 选项卡按钮是否可用
        /// </summary>
        public bool IsEnabled { get => RibButton.IsEnabled; set => RibButton.IsEnabled = value; }


        /// <summary>
        /// 选项目卡按钮是否可见
        /// </summary>
        public bool IsVisible { get => RibButton.IsVisible; set => RibButton.IsVisible = value; }


        /// <summary>
        /// 获取或设置按钮名称
        /// </summary>
        public string Name { get => RibButton.Name; set => RibButton.Name = value; }

        /// <summary>
        /// 获取或设置按钮标题
        /// </summary>
        public string Text { get => RibButton.Text; set => RibButton.Text = value; }

        /// <summary>
        /// 获取或设置按钮的排列方式
        /// </summary>
        public Orientation Orientation { get => RibButton.Orientation; set => RibButton.Orientation = value; }

        /// <summary>
        /// 获取或设置按钮是标准还是大图标
        /// </summary>
        public RibbonItemSize Size { get => RibButton.Size; set => RibButton.Size = value; }

        /// <summary>
        ///  设置按钮命令字符串，输入命令时不用加空格，已经自带空格了
        /// </summary>
        public string CommandParameter { set => RibButton.CommandParameter = value + " "; }

        /// <summary>
        /// 设置按钮相关的命令
        /// </summary>
        public RibbonCommandHandler CommandHandler { set => RibButton.CommandHandler = value; }

        /// <summary>
        /// 获取按钮ID
        /// </summary>
        public string Id { get => RibButton.Id; }

        /// <summary>
        /// 获取或设置按钮帮助文档
        /// </summary>
        public ToolTip RibbonToolTip
        {
            get
            {
                ToolTip revalue = new ToolTip
                {
                    RibToolTip = (RibbonToolTip)RibButton.ToolTip
                };
                return revalue;
            }
            set
            {
                RibButton.ToolTip = value;
            }
        }

        #endregion

        #region 事件定义

        /// <summary>
        /// 按钮加载事件委托
        /// </summary>
        /// <param name="sender"></param>
        public delegate void InitializedEventHandler(MyRibbonButton sender);

        /// <summary>
        /// 按钮加载时发生
        /// </summary>
        public event InitializedEventHandler Initialized;

        /// <summary>
        /// 按钮加载时发生
        /// </summary>
        /// <param name="sender">选项卡按钮</param>
        /// <param name="e"></param>
        private void RibButton_Initialized(object sender, EventArgs e)
        {
            Initialized(this);
        }

        /// <summary>
        /// 鼠标在按钮上面事件委托
        /// </summary>
        /// <param name="sender">选项卡按钮</param>
        public delegate void HostEventHandler(MyRibbonButton sender);

        /// <summary>
        /// 鼠标在按钮上面时发生
        /// </summary>
        public event HostEventHandler Host;


        /// <summary>
        /// 鼠标在按钮上面时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibButton_HostEvent(object sender, Autodesk.Internal.Windows.HostEventArgs e)
        {
            Host(this);
        }

        ///// <summary>
        ///// 按钮属性更改事件委托
        ///// </summary>
        ///// <param name="sender">选项卡按钮</param>
        ///// <param name="ChangedName">更改的属性名称</param>
        //public delegate void PropertyChangedEventHandler(MyRibbonButton sender, string ChangedName);

        ///// <summary>
        ///// 属性更改时发生
        ///// </summary>
        //public event PropertyChangedEventHandler PropertyChanged;

        ///// <summary>
        ///// 属性更改时发生
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void RibButton_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    try
        //    {
        //        PropertyChanged(this, e.PropertyName);
        //    }
        //    catch (Exception)
        //    {

        //        return ;
        //    }
           
        //}

        /// <summary>
        /// 鼠标离开事件委托
        /// </summary>
        /// <param name="sender">选项卡按钮</param>
        public delegate void MouseLeftEventHandler(MyRibbonButton sender);

        /// <summary>
        /// 鼠标离开时发生
        /// </summary>
        public event MouseLeftEventHandler MouseLeft;

        /// <summary>
        /// 鼠标离开按钮时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibButton_MouseLeft(object sender, EventArgs e)
        {
            RibButton.Image = GetImage(ImgFileName);
            MouseLeft(this);
        }

        /// <summary>
        /// 鼠标进入事件委托
        /// </summary>
        /// <param name="send">选项卡按钮</param>
        public delegate void MouseEnteredEventHandler(MyRibbonButton send);

        /// <summary>
        /// 鼠标进入时发生
        /// </summary>
        public event MouseEnteredEventHandler MouseEnter;

        /// <summary>
        /// 鼠标进入铵钮时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibButton_MouseEntered(object sender, EventArgs e)
        {
            RibButton.Image = GetImage(ImgHoverFileName);
            MouseEnter(this);
        }

        /// <summary>
        /// 获取指定路径的图片
        /// </summary>
        /// <param name="FileName">图片路径</param>
        /// <returns></returns>
        private BitmapImage GetImage(string FileName)
        {
            if (FileName == string.Empty) { return null; }

            try
            {
                return new BitmapImage(new Uri(FileName));
            }
            catch (Exception)
            {

                return null; ;
            }
        }

        #endregion

        #region 构造函数

        public MyRibbonButton()
        {
            ///设置默认属性
            ///
            RibButton = new RibbonButton
            {
                Name = RibbonDefault.RibButtonName,
                Text = RibbonDefault.RibButtonName,
                IsActive = true,
                IsEnabled = true,
                IsVisible = true,
                ShowImage = true,
                ShowText = true,
                ShowToolTipOnDisabled = true,
                Size = RibbonItemSize.Standard,
                CommandHandler = new RibbonCommandHandler(),
                Orientation = Orientation.Vertical,
                CommandParameter = RibbonDefault.RibButtonOrder + " ",

            };

            ///定义事件
            ///
            RibButton.MouseEntered += RibButton_MouseEntered;
            RibButton.MouseLeft += RibButton_MouseLeft;
            ///RibButton.PropertyChanged += RibButton_PropertyChanged;
            RibButton.HostEvent += RibButton_HostEvent;
            RibButton.Initialized += RibButton_Initialized;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Name">选项卡按钮名字</param>
        /// <param name="Order">按钮命令</param>
        public MyRibbonButton(string Name, string Order = RibbonDefault.RibButtonOrder)
        {
            ///设置默认属性
            ///
            RibButton = new RibbonButton
            {
                Name = Name,
                Text = Name,
                IsActive = true,
                IsEnabled = true,
                IsVisible = true,
                ShowImage = true,
                ShowText = true,
                ShowToolTipOnDisabled = true,
                Size = RibbonItemSize.Standard,
                CommandHandler = new RibbonCommandHandler(),
                Orientation = Orientation.Vertical,
                CommandParameter = Order + " ",

            };

            ///定义事件
            ///
            RibButton.MouseEntered += RibButton_MouseEntered;
            RibButton.MouseLeft += RibButton_MouseLeft;
            ///RibButton.PropertyChanged += RibButton_PropertyChanged;
            RibButton.HostEvent += RibButton_HostEvent;
            RibButton.Initialized += RibButton_Initialized;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="toolTip">帮助文档</param>
        /// <param name="Name">选项卡按钮名字</param>
        /// <param name="Order">按钮命令</param>
        public MyRibbonButton(ToolTip toolTip, string Name, string Order = global.RibbonDefault.RibButtonOrder)
        {
            ///设置默认属性
            ///
            RibButton = new RibbonButton
            {
                Name = Name,
                Text = Name,
                IsActive = true,
                IsEnabled = true,
                IsVisible = true,
                ShowImage = true,
                ShowText = true,
                ShowToolTipOnDisabled = true,
                Size = RibbonItemSize.Standard,
                CommandHandler = new RibbonCommandHandler(),
                Orientation = Orientation.Vertical,
                CommandParameter = Order + " ",
                ToolTip = toolTip.RibToolTip
            };

            ///定义事件
            ///
            RibButton.MouseEntered += RibButton_MouseEntered;
            RibButton.MouseLeft += RibButton_MouseLeft;
            ///RibButton.PropertyChanged += RibButton_PropertyChanged;
            RibButton.HostEvent += RibButton_HostEvent;
            RibButton.Initialized += RibButton_Initialized;
        }

        #endregion

    }
}
