using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitAPILab5_3.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RevitAPILab5_3
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Мое окно";
            application.CreateRibbonTab(tabName);
            string utilsFolderPath = @"C:\Program Files\RevitAPITraining\";

            var panel = application.CreateRibbonPanel(tabName, "Инструменты");

            var button1 = new PushButtonData("1", "Смена типа стен",
                Path.Combine(utilsFolderPath, "RevitAPILab5_2.dll"),
                "RevitAPILab5_2.Main");

            Uri uriImage = new Uri(@"C:\RevitAPITraining\RevitAPILab5.3\Images\2.png", UriKind.Absolute);
            BitmapImage largeImage = new BitmapImage(uriImage);
            button1.LargeImage = largeImage;

            panel.AddItem(button1);

            var button2 = new PushButtonData("2", "Количество и объем",
                         Path.Combine(utilsFolderPath, "RevitAPILab5_1.dll"),
                         "RevitAPILab5_1.Main");

            Uri uriImage2 = new Uri(@"C:\RevitAPITraining\RevitAPILab5.3\Images\1.png", UriKind.Absolute);
            BitmapImage largeImage2 = new BitmapImage(uriImage2);
            button2.LargeImage = largeImage2;

            panel.AddItem(button2);

            return Result.Succeeded;
        }


    }
}
