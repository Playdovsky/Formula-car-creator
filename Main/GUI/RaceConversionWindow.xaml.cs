using Logic;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Main.GUI
{
    public partial class RaceConversionWindow : Window
    {
        private int Number { get; set; }
        private byte Type { get; set; }
        private string Aerodynamics { get ; set; }
        private string Engine { get; set; }
        private string Tyres { get; set; }
        private List<Car> Cars { get; set; }
        private Car SelectedCar { get; set; }

        public RaceConversionWindow(List<Car> cars, Car selectedCar, int number, byte type, string aerodynamics, string engine, string tyres)
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
                if (string.IsNullOrWhiteSpace(TextBoxAcceleration.Text) || string.IsNullOrWhiteSpace(TextBoxBrakes.Text) || string.IsNullOrWhiteSpace(TextBoxMaxSpeed.Text))
                {
                    throw new ArgumentException();
                }

                short maxSpeed = short.Parse(TextBoxMaxSpeed.Text);
                double brakesBalance = double.Parse(TextBoxBrakes.Text);
                double acceleration = double.Parse(TextBoxAcceleration.Text);
                bool approvedByFIA = CheckBoxFIA.IsChecked.Value;

                if (brakesBalance > 100 || maxSpeed > 500 || acceleration > 10)
                {
                    throw new Exception();
                }
                else
                {
                    ConversionRace(maxSpeed, brakesBalance, acceleration, approvedByFIA);
                    Cars.Remove(SelectedCar);
                }

            }
            catch (ArgumentNullException anex) 
            {
                MessageBox.Show($"{anex.Message}\nPlease input all of data.");
            }
            catch (Exception)
            {
                MessageBox.Show("Information you provided is too untrue to be used in a new formula car.");
            }
        }

        private void ConversionRace(short maxSpeed, double brakesBalance, double acceleration, bool approvedByFIA)
        {
            RaceCar race = new RaceCar(Number, Type, Aerodynamics, Engine, Tyres, brakesBalance, maxSpeed, acceleration, approvedByFIA);
            Cars.Add(race);
            MessageBox.Show("Conversion successfull, car is now marked for race.");
        }
    }
}
