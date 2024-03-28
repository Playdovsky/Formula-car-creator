using Logic;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Main
{
    public partial class ShowConversionWindow : Window
    {
        private int Number { get; set; }
        private byte Type { get; set; }
        private string Aerodynamics { get; set; }
        private string Engine { get; set; }
        private string Tyres { get; set; }
        private List<Car> Cars { get; set; }
        private Car SelectedCar { get; set; }

        public ShowConversionWindow(List<Car> cars, Car selectedCar, int number, byte type, string aerodynamics, string engine, string tyres)
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
                if (string.IsNullOrWhiteSpace(TextBoxAdvertiser.Text) || string.IsNullOrWhiteSpace(TextBoxLocation.Text))
                {
                    throw new ArgumentNullException();
                }

                string advertisers = TextBoxAdvertiser.Text;
                string location = TextBoxLocation.Text;
                bool forSale = CheckBoxForSale.IsChecked.Value;
                double? price = null;

                if (forSale)
                {
                    if (double.TryParse(TextBoxPrice.Text, out double priceDouble) && priceDouble >= 100000)
                    {
                        price = priceDouble;
                    }
                    else
                    {
                        MessageBox.Show("Either price is too small for formula car or you entered invalid signs into the price field.");
                        return;
                    }
                }

                ConversionShow(advertisers, location, forSale, price);
                Cars.Remove(SelectedCar);
            }
            catch (ArgumentNullException anex)
            {
                MessageBox.Show($"{anex.Message}\nPlease input advertisers and location.");
            }
        }

        public void ConversionShow(string advertisers, string location, bool forSale, double? price)
        {
            ShowCar showCar = new ShowCar(Number, Type, Aerodynamics, Engine, Tyres, advertisers, location, forSale, price);
            RaceCar.cars.Add(showCar);
            MessageBox.Show("Conversion successful, car is now marked for show.");
        }


        private void CheckBoxForSale_Checked(object sender, RoutedEventArgs e)
        {
            LabelPrice.Visibility = Visibility.Visible;
            TextBoxPrice.Visibility = Visibility.Visible;
        }

        private void CheckBoxForSale_Unchecked(object sender, RoutedEventArgs e)
        {
            LabelPrice.Visibility = Visibility.Hidden;
            TextBoxPrice.Visibility = Visibility.Hidden;
        }
    }
}
