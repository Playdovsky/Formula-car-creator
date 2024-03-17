using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
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
            Car selectedCar = (Car)DataGridCars.SelectedItem;
            Service.Removal(selectedCar, cars);
            LoadCars();
        }

        private void ButtonConvertDamaged_Click(object sender, RoutedEventArgs e)
        {
            option = 1;
            Car selectedCar = (Car)DataGridCars.SelectedItem;
            Service.Conversion(option, selectedCar, cars);
        }

        private void ButtonConvertShow_Click(object sender, RoutedEventArgs e)
        {
            option = 2;
            Car selectedCar = (Car)DataGridCars.SelectedItem;
            Service.Conversion(option, selectedCar, cars);
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
