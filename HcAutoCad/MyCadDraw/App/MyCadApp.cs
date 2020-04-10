using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.ApplicationServices;

namespace MyCadDraw.App
{
    /// <summary>
    /// CAD程序对象
    /// </summary>
    internal class MyCadApp
    {
        /// <summary>
        /// 获取CAD程序对象
        /// </summary>
        public static AcadApplication GetCadApp
        {
            get
            {
                return (AcadApplication)Application.AcadApplication;
            }
        }

    }
}
