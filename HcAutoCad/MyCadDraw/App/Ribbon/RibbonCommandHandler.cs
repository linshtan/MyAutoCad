using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.Windows;
using System;

namespace MyCadDraw.App.Ribbon
{
    internal class RibbonCommandHandler : System.Windows.Input.ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            CanExecuteChanged(parameter, null);
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is RibbonButton btn)
            {
                if (btn.CommandParameter != null)
                {
                    Document doc = Application.DocumentManager.MdiActiveDocument;
                    doc.SendStringToExecute(btn.CommandParameter.ToString(), true, false, false);
                }
            };
        }
    }
}
