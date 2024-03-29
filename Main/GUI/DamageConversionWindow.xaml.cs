using Logic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Annotations;

namespace Main
{
    public partial class DamageConversionWindow : Window
    {
        private int Number { get; set; }
        private byte Type { get; set; }
        private string Aerodynamics { get; set; }
        private string Engine { get; set; }
        private string Tyres { get; set; }
        private List<Car> Cars { get; set; }
        private Car SelectedCar { get; set; }

        public DamageConversionWindow(List<Car> cars, Car selectedCar, int number, byte type, string aerodynamics, string engine, string tyres)
        {
            InitializeComponent();

            Number = number;
            Type = type;
            Aerodynamics = aerodynamics;
            Engine = engine;
            Tyres = tyres;
            Cars = cars;
            SelectedCar = selectedCar;
        }

        private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TextBoxReasonConversion.Text) || string.IsNullOrWhiteSpace(TextBoxDamagedComponents.Text))
                {
                    throw new ArgumentNullException();
                }

                string reason = TextBoxReasonConversion.Text;
                string damagedComponents = TextBoxDamagedComponents.Text;
                bool canBeFixed = CheckBoxCanBeFixed.IsChecked.Value;
                int? repairTime = null;

                if (canBeFixed)
                {
                    if (int.TryParse(TextBoxRepairTime.Text, out int repairTimeInt) && repairTimeInt > 0)
                    {
                        repairTime = repairTimeInt;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input in repair time field.");
                        return;
                    }
                }

                ConversionDamaged(reason, damagedComponents, canBeFixed, repairTime);
                Cars.Remove(SelectedCar);
            }
            catch (ArgumentNullException anex)
            {
                MessageBox.Show($"{anex.Message}\nPlease input reason and damaged components");
            }
        }

        public void ConversionDamaged(string reason, string damagedComponents, bool canBeFixed, int? repairTime)
        {
            DamagedCar damagedCar = new DamagedCar(Number, Type, Aerodynamics, Engine, Tyres, reason, damagedComponents, canBeFixed, repairTime);
            RaceCar.cars.Add(damagedCar);
            MessageBox.Show("Conversion successful, car is now marked as damaged.");
            Close();
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
