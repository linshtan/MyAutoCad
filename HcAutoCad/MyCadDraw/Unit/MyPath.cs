using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCadDraw.Unit
{
    /// <summary>
    /// 获取各种程序的路径相样
    /// </summary>
    internal class MyPath
    {
        /*
         * c#中路径写法(@"c:\")  or  ("c:\\子目录")
         */


        /// <summary>
        /// 获取当前dll的路径
        /// </summary>
        public string AssemblyPath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        /// <summary>
        /// 获取当前执行的exe的文件名
        /// </summary>
        public string AppName => Process.GetCurrentProcess().MainModule.FileName;

        /// <summary>
        /// 获取该进程从中启动的目录
        /// 备注按照定义，如果该进程在本地或网络驱动器的根目录中启动，则此属性的值为驱动器名称后跟一个尾部反斜杠（如“C:\”）
        /// 如果该进程在子目录中启动，则此属性的值为不带尾部反斜杠的驱动器和子目录路径（如“C:\子目录”）
        /// </summary>
        public string RunDirectory => Environment.CurrentDirectory;

        /// <summary>
        /// 获取应用程序的当前工作目录
        /// </summary>
        public string WorkDirectory => Directory.GetCurrentDirectory();

        /// <summary>
        /// 获取基目录，它由程序集冲突解决程序用来探测程序集
        /// </summary>
        public string AppDomainDirectory => AppDomain.CurrentDomain.BaseDirectory;

        //获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称。
        //Application.StartupPath;

        /// <summary>
        /// 获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称
        /// </summary>
        public string AppStartPath=> Application.StartupPath;

        //获取启动了应用程序的可执行文件的路径，包括可执行文件的名称。
        //Application.ExecutablePath;

        //获取或设置包含该应用程序的目录的名称。
        //AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        //获取模块的完整路径。
        //System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName

        //获取和设置当前目录(该进程从中启动的目录)的完全限定目录。
        //System.Environment.CurrentDirectory

        //获取应用程序的当前工作目录。
        //System.IO.Directory.GetCurrentDirectory()

        //获取程序的基目录。
        //System.AppDomain.CurrentDomain.BaseDirectory

        //获取和设置包括该应用程序的目录的名称。
        //System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase

        //获取启动了应用程序的可执行文件的路径。
        //System.Windows.Forms.Application.StartupPath

        //获取启动了应用程序的可执行文件的路径及文件名
        //System.Windows.Forms.Application.ExecutablePath

    }
}
