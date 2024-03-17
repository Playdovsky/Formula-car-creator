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
using System.Windows.Shapes;
using Logic;

namespace Main
{

    public partial class GarageWindow : Window
    {
        private List<Car> cars;
        private byte option = 0;

        public GarageWindow()
        {
            InitializeComponent();
            LoadCars();
        }

        private void DataGridCars_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Car selectedCar = (Car)DataGridCars.SelectedItem;
            MessageBox.Show(selectedCar.CarInfo());
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Do you really want to delete selected car? This process cannot be undone.", "Confirmation", MessageBoxButton.YesNo);

            if(dialogResult == MessageBoxResult.Yes)
            {
                Car selectedCar = (Car)DataGridCars.SelectedItem;
                cars.Remove(selectedCar);
                LoadCars();
            }
            else
            {
                return;
            }
        }

        private void ButtonConvertDamaged_Click(object sender, RoutedEventArgs e)
        {
            option = 1;
            Conversion();
        }

        private void ButtonConvertShow_Click(object sender, RoutedEventArgs e)
        {
            option = 2;
            Conversion();
        }

        private void Conversion()
        {
            try
            {
                Car selectedCar = (Car)DataGridCars.SelectedItem;

                if (selectedCar is null)
                {
                    throw new ArgumentNullException(nameof(selectedCar));
                }

                int number = selectedCar.Number;
                byte type = selectedCar.Type;
                string aerodynamics = selectedCar.Aerodynamics;
                string engine = selectedCar.Engine;
                string tyres = selectedCar.Tyres;

                cars.Remove(selectedCar);

                switch (option)
                {
                    case 1:
                        DamageConversionWindow damagedConversion = new DamageConversionWindow(number, type, aerodynamics, engine, tyres);
                        damagedConversion.Show();
                        break;
                    case 2:
                        ShowConversionWindow showConversion = new ShowConversionWindow(number, type, aerodynamics, engine, tyres);
                        showConversion.Show();
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

        private void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadCars();
        }

        public void LoadCars()
        {
            cars = Car.cars;
            DataGridCars.ItemsSource = null;
            DataGridCars.ItemsSource = cars;
        }

    }
}
