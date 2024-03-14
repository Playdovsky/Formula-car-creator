using Main.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Main
{
    /// <summary>
    /// Logika interakcji dla klasy ConversionWindow.xaml
    /// </summary>
    public partial class ConversionWindow : Window
    {
        public ConversionWindow(int number, byte type, string aerodynamics, string engine, string tyres)
        {
            InitializeComponent();
            DamagedControl damagedControl = new DamagedControl(number, type, aerodynamics, engine, tyres);
            ControlDamaged.Content = damagedControl;
        }
    }
}
