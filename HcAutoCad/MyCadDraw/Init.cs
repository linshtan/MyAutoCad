using Autodesk.AutoCAD.Runtime;
using System.Windows.Forms;
using Autodesk.AutoCAD.Interop;
using Autodesk.Windows;

[assembly: ExtensionApplication(typeof(MyCadDraw.Init))]
namespace MyCadDraw
{
    /// <summary>
    /// 类入口
    /// 初始化的代码请放在这里
    /// </summary>
    public class Init : IExtensionApplication
    {
        public AcadApplication MyApplication
        {
            get
            {
                return (AcadApplication)Autodesk.AutoCAD.ApplicationServices.Application.AcadApplication;
            }
        }

        /// <summary>
        /// 开始初始化
        /// </summary>
        public void Initialize()
        {

            AcadApplication CadApp = MyApplication;

            RibbonPanelSource ribbonPanelSource = App.Ribbon.MyRibbon.AddPanel("mypanel");

            App.Ribbon.MyRibbon.AddButton(ribbonPanelSource, "mysour");


            /////创建菜单
            ////为AutoCAD添加一个新的菜单，并设置标题为"门窗设计菜单"
            //AcadPopupMenu newMenu = CadApp.MenuGroups.Item(0).Menus.Add("门窗设计菜单");

            ////声明一个AutoCAD弹出菜单项，用于获取添加的菜单项对象
            //AcadPopupMenuItem MKMenuItem;

            ////在新建的菜单中添加一个名为"横断面"的子菜单
            //AcadPopupMenu MKMenuItems = newMenu.AddSubMenu(newMenu.Count + 1, "门窗大样图绘制 ");

            ////MKMenuItem = MKMenuItems.AddMenuItem(MKMenuItems.Count + 1, "绘制立面", (char)(3) + (char)(3) + (char)(95) + "drwlm" + (char)(32));

            //MKMenuItem = MKMenuItems.AddMenuItem(MKMenuItems.Count + 1, "绘制立面", "drwlm ");
            //MKMenuItem.HelpString = "命令：drwlm，绘制门窗立面图，此立面图只包括墙线与门窗框";

            //MKMenuItem = MKMenuItems.AddMenuItem(MKMenuItems.Count + 1, "绘制扇料", "drws ");
            //MKMenuItem.HelpString = "命令：drws，绘制门窗的扇料，此扇料为45度";

            //MKMenuItem = MKMenuItems.AddMenuItem(MKMenuItems.Count + 1, "固定玻璃", "drwf ");
            //MKMenuItem.HelpString = "命令：drwf，绘制门窗的固定玻璃压线";

            //MKMenuItem = MKMenuItems.AddMenuItem(MKMenuItems.Count + 1, "绘制推拉扇", "drwt ");
            //MKMenuItem.HelpString = "命令：drwt，绘制推拉窗的扇料，可以是双扇，三扇与四扇";

            //MKMenuItem = MKMenuItems.AddMenuItem(MKMenuItems.Count + 1, "绘制地弹门扇", "drwm ");
            //MKMenuItem.HelpString = "命令：drwm，绘制地弹门的门扇料";

            //MKMenuItem = MKMenuItems.AddMenuItem(MKMenuItems.Count + 1, "绘制墙体线", "drww ");
            //MKMenuItem.HelpString = "命令：drww，绘制墙体的虚线，墙体虚线与窗框默认为25间隙";

            //MKMenuItem = MKMenuItems.AddMenuItem(MKMenuItems.Count + 1, "玻璃铝格条", "drwg ");
            //MKMenuItem.HelpString = "命令：drwg，绘制玻璃上的铝格条";




            //newMenu.InsertInMenuBar(CadApp.Application.MenuBar.Count + 1);

            CadApp.EndCommand += CadApp_EndCommand;

        }

        private void CadApp_EndCommand(string CommandName)
        {
            //    Select Case CommandName;
            //    '画立面函数
            //    Case "DRWLM"
            //        lmd()
            //        Exit Sub
            //        '画平开窗扇
            //    Case "DRWS"
            //        sdrw()
            //        Exit Sub
            //        '画固定玻璃
            //    Case "DRWF"
            //        fdrw()
            //        Exit Sub
            //        '推拉窗或门
            //    Case "DRWT"
            //        tdrw()
            //        Exit Sub
            //        '地弹门扇
            //    Case "DRWM"
            //        mdrw()
            //        Exit Sub
            //        '墙体
            //    Case "DRWW"
            //        wdrw()
            //        Exit Sub
            //        '玻璃铝格条
            //    Case "DRWG"
            //        gdrw()
            //        Exit Sub
            //End Select

            //switch (CommandName)
            //{
            //    case "DRWS": Sdrw(); break;
            //}

        }

        /// <summary>
        /// 画平开窗或门扇
        /// </summary>
        //void Sdrw()
        //{

        //    double[] pointl = new double[2];

        //    double[] pointr = new double[2];

        //    int lrtb = 1;

        //    int mm = 0;

        //    double mmh = 900;

        //    AcadApplication CadApp = MyApplication;

        //    ///得到左上角及右下角的点
        //    ///
        //    try
        //    {
        //        pointl = CadApp.ActiveDocument.Utility.GetPoint(Prompt: "请输入左上角的点");
        //        pointr = CadApp.ActiveDocument.Utility.GetPoint(Prompt: "请输入右下角的点");
        //    }
        //    catch (System.Exception)
        //    {

        //        return;
        //    }

        //    CadApp.ActiveDocument.Utility.InitializeUserInput(6, "err");



        //    ///是否有中横
        //    ///

        //    try
        //    {
        //        do
        //        {
        //            mm = CadApp.ActiveDocument.Utility.GetInteger("是否有门中横(0) (0:否 1:是:");

        //        } while (mm < 0 | mm > 1);
        //    }
        //    catch (System.Exception)
        //    {

        //        return;
        //    }

        //    ///设置中横高度
        //    ///
        //    if (mm == 1)
        //    {
        //        try
        //        {
        //            do
        //            {
        //                mmh = CadApp.ActiveDocument.Utility.GetInteger("门中横离地面中点的高度(900)");
        //            } while (mmh < 0);
        //        }
        //        catch (System.Exception)
        //        {

        //            mmh = 900;
        //        }
        //    }

        //    try
        //    {
        //        do
        //        {
        //            lrtb = CadApp.ActiveDocument.Utility.GetInteger("开启方向 (1) (1:左 2:右 3:上 4:下:");
        //        } while (lrtb < 1 | lrtb > 4);
        //    }
        //    catch (System.Exception)
        //    {

        //        lrtb = 1;
        //    }


        //    //'画中间部分
        //    //Dim plinepoint(7) As Double
        //    //plinepoint(0) = pointl(0) + 40 : plinepoint(1) = pointl(1) - 40
        //    //plinepoint(2) = pointr(0) - 40 : plinepoint(3) = pointl(1) - 40
        //    //plinepoint(4) = pointr(0) - 40 : plinepoint(5) = pointr(1) + 40
        //    //plinepoint(6) = pointl(0) + 40 : plinepoint(7) = pointr(1) + 40

        //    double[] plinepoint = new double[7];
        //    plinepoint[0] = pointl[0] + 40;
        //    plinepoint[1] = pointl[1] - 40;
        //    plinepoint[2] = pointr[0] - 40;
        //    plinepoint[3] = pointl[1] - 40;
        //    plinepoint[4] = pointr[0] - 40;
        //    plinepoint[5] = pointr[1] + 40;
        //    plinepoint[6] = pointl[0] + 40;
        //    plinepoint[7] = pointr[1] + 40;


        //    Autodesk.AutoCAD.Interop.Common.AcadLWPolyline plineObj = CadApp.ActiveDocument.ModelSpace.AddLightWeightPolyline(plinepoint);
        //    plineObj.Closed = true;
        //    Autodesk.AutoCAD.Interop.Common.AcadAcCmColor linecolor = plineObj.TrueColor;
        //    linecolor.ColorIndex = Autodesk.AutoCAD.Interop.Common.AcColor.acYellow;
        //    plineObj.TrueColor = linecolor;

        //    double[] ls = new double[2];
        //    double[] le = new double[2];
        //    ls[0] = pointl[0]; ls[1] = pointl[1]; ls[2] = pointl[2];
        //    le[0] = pointl[0] + 40; le[1] = pointl[1] - 40; le[2] = pointl[2];

        //    Autodesk.AutoCAD.Interop.Common.AcadLine lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(ls, le);
        //    lineObj.TrueColor = linecolor;

        //    //ls(0) = pointr(0) : ls(1) = pointl(1) : ls(2) = pointl(2)
        //    //le(0) = pointr(0) - 40 : le(1) = pointl(1) - 40 : le(2) = pointl(2)

        //    //lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(ls, le)
        //    //lineObj.TrueColor = linecolor

        //    //ls(0) = pointl(0) : ls(1) = pointr(1) : ls(2) = pointl(2)
        //    //le(0) = pointl(0) + 40 : le(1) = pointr(1) + 40 : le(2) = pointl(2)

        //    //lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(ls, le)
        //    //lineObj.TrueColor = linecolor

        //    //ls(0) = pointr(0) : ls(1) = pointr(1) : ls(2) = pointl(2)
        //    //le(0) = pointr(0) - 40 : le(1) = pointr(1) + 40 : le(2) = pointl(2)

        //    //lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(ls, le)
        //    //lineObj.TrueColor = linecolor

        //    //Select Case lrtb
        //    //    Case 1
        //    //        ls(0) = pointr(0) - 40 : ls(1) = pointl(1) - 40 : ls(2) = pointl(2)
        //    //        le(0) = pointl(0) + 40 : le(1) = pointl(1) - ((pointr(1) - pointl(1)) / 2) ^ 2 ^ (1 / 2) : le(2) = pointl(2)

        //    //        lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(ls, le)
        //    //        lineObj.TrueColor = linecolor

        //    //        le(0) = pointr(0) - 40 : le(1) = pointr(1) + 40 : le(2) = pointl(2)

        //    //        lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(lineObj.EndPoint, le)
        //    //        lineObj.TrueColor = linecolor

        //    //    Case 2
        //    //        ls(0) = pointl(0) + 40 : ls(1) = pointl(1) - 40 : ls(2) = pointl(2)
        //    //        le(0) = pointr(0) - 40 : le(1) = pointl(1) - ((pointr(1) - pointl(1)) / 2) ^ 2 ^ (1 / 2) : le(2) = pointl(2)

        //    //        lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(ls, le)
        //    //        lineObj.TrueColor = linecolor

        //    //        le(0) = pointl(0) + 40 : le(1) = pointr(1) + 40 : le(2) = pointl(2)

        //    //        lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(lineObj.EndPoint, le)
        //    //        lineObj.TrueColor = linecolor
        //    //    Case 3
        //    //        ls(0) = pointl(0) + 40 : ls(1) = pointr(1) + 40 : ls(2) = pointl(2)
        //    //        le(0) = pointl(0) + ((pointr(0) - pointl(0)) / 2) ^ 2 ^ (1 / 2) : le(1) = pointl(1) - 40 : le(2) = pointl(2)

        //    //        lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(ls, le)
        //    //        lineObj.TrueColor = linecolor

        //    //        le(0) = pointr(0) - 40 : le(1) = pointr(1) + 40 : le(2) = pointl(2)

        //    //        lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(lineObj.EndPoint, le)
        //    //        lineObj.TrueColor = linecolor
        //    //    Case 4
        //    //        ls(0) = pointl(0) + 40 : ls(1) = pointl(1) - 40 : ls(2) = pointl(2)
        //    //        le(0) = pointl(0) + ((pointr(0) - pointl(0)) / 2) ^ 2 ^ (1 / 2) : le(1) = pointr(1) + 40 : le(2) = pointl(2)

        //    //        lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(ls, le)
        //    //        lineObj.TrueColor = linecolor

        //    //        le(0) = pointr(0) - 40 : le(1) = pointl(1) - 40 : le(2) = pointl(2)

        //    //        lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(lineObj.EndPoint, le)
        //    //        lineObj.TrueColor = linecolor
        //    //End Select
        //    //'画中横
        //    //If mm = 1 Then
        //    //    ls(0) = pointl(0) + 40 : ls(1) = pointr(1) + mmh + 50 : ls(2) = pointl(2)
        //    //    le(0) = pointr(0) - 40 : le(1) = pointr(1) + mmh + 50 : le(2) = pointl(2)
        //    //    lineObj = CadApp.ActiveDocument.ModelSpace.AddLine(ls, le)
        //    //    ls(0) = pointl(0) + 40 : ls(1) = pointr(1) + mmh : ls(2) = pointl(2)
        //    //    le(0) = pointr(0) - 40 : le(1) = pointr(1) + mmh : le(2) = pointl(2)
        //    //    lineObj.Mirror(ls, le)
        //    //End If
        //}

        /// <summary>
        /// 初始化终止
        /// </summary>
        public void Terminate()
        {
            ///MessageBox.Show("end");
        }
    }



}
