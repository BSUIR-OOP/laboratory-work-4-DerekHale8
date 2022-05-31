using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DILib;

namespace Lab4OOP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Services services = new Services();
            services.AddSingelton<IRandomColorWriter, RandomNumberColor>();
            DIContainer container = services.GetContainer();

            var colorA = container.GetServiceType<IRandomColorWriter>();
            var colorB = container.GetServiceType<IRandomColorWriter>();

            colorA.ColorWrite();
            colorB.ColorWrite();

            Services services2 = new Services();
            services2.AddTransient<IRandomColorWriter, RandomNumberColor>();
            DIContainer container2 = services2.GetContainer();

            var colorC = container2.GetServiceType<IRandomColorWriter>();
            var colorD = container2.GetServiceType<IRandomColorWriter>();

            colorC.ColorWrite();
            colorD.ColorWrite();
        }
    }
}
