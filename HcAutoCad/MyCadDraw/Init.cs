using System;
using System.Diagnostics;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.DatabaseServices;
using System.Windows.Forms;

[assembly: ExtensionApplication(typeof(MyCadDraw.Init))]
namespace MyCadDraw
{
    /// <summary>
    /// 类入口
    /// 初始化的代码请放在这里
    /// </summary>
    public class Init : IExtensionApplication
    {
        /// <summary>
        /// 开始初始化
        /// </summary>
        public void Initialize()
        {
            MessageBox.Show("start");
        }

        /// <summary>
        /// 初始化终止
        /// </summary>
        public void Terminate()
        {
            MessageBox.Show("end");
        }
    }



}
