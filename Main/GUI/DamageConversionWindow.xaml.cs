using Logic;
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
    public partial class DamageConversionWindow : Window
    {
        private int Number { get; set; }
        private byte Type { get; set; }
        private string Aerodynamics { get; set; }
        private string Engine { get; set; }
        private string Tyres { get; set; }

        public DamageConversionWindow(int number, byte type, string aerodynamics, string engine, string tyres)
        {
            InitializeComponent();
            Number = number;
            Type = type;
            Aerodynamics = aerodynamics;
            Engine = engine;
            Tyres = tyres;
        }

        private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            string reason = TextBoxReasonConversion.Text;
            string damagedComponents = TextBoxDamagedComponents.Text;
            bool canBeFixed = CheckBoxCanBeFixed.IsChecked.Value;
            string repairTime = TextBoxRepairTime.Text;

            if (repairTime == "")
            {
                repairTime = "cannot be repaired";
            }

            ConversionDamaged(reason, damagedComponents, canBeFixed, repairTime);
        }

        public void ConversionDamaged(string reason, string damagedComponents, bool canBeFixed, string repairTime)
        {
            DamagedCar damagedCar = new DamagedCar(Number, Type, Aerodynamics, Engine, Tyres, reason, damagedComponents, canBeFixed, repairTime);
            Car.cars.Add(damagedCar);
            MessageBox.Show("Conversion successfull, car is now marked as damaged.");
        }

        private void CheckBoxCanBeFixed_Unchecked(object sender, RoutedEventArgs e)
        {
            LabelRepairTime.Visibility = Visibility.Hidden;
            TextBoxRepairTime.Visibility = Visibility.Hidden;
        }

        private void CheckBoxCanBeFixed_Checked(object sender, RoutedEventArgs e)
        {
            LabelRepairTime.Visibility = Visibility.Visible;
            TextBoxRepairTime.Visibility = Visibility.Visible;
        }
    }
}
