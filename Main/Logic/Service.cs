using Logic;
using Main.GUI;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Main
{
    public static class Service
    {
        public static void Conversion(byte option, Car selectedCar, List<Car> cars)
        {
            try
            {
                if (selectedCar is null)
                {
                    throw new ArgumentNullException(nameof(selectedCar));
                }

                int number = selectedCar.Number;
                byte type = selectedCar.Type;
                string aerodynamics = selectedCar.Aerodynamics;
                string engine = selectedCar.Engine;
                string tyres = selectedCar.Tyres;

                switch (option)
                {
                    case 1:
                        DamageConversionWindow damagedConversion = new DamageConversionWindow(cars, selectedCar, number, type, aerodynamics, engine, tyres);
                        damagedConversion.Show();
                        break;
                    case 2:
                        ShowConversionWindow showConversion = new ShowConversionWindow(cars, selectedCar, number, type, aerodynamics, engine, tyres);
                        showConversion.Show();
                        break;
                    case 3:
                        RaceConversionWindow raceConversion = new RaceConversionWindow(cars, selectedCar, number, type, aerodynamics, engine, tyres);
                        raceConversion.Show();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(option));
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please select the car you want to convert.");
            }
        }

        public static void Removal(Car selectedCar, List<Car> cars)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Do you really want to delete selected car? This process cannot be undone.", "Confirmation", MessageBoxButton.YesNo);

            if (dialogResult == MessageBoxResult.Yes)
            {
                cars.Remove(selectedCar);
            }
            else
            {
                return;
            }
        }
    }
}
