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
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class GarageWindow : Window
    {
        private List<Car> cars;
        public GarageWindow()
        {
            InitializeComponent();
            LoadCars();
        }

        private void LoadCars()
        {
            cars = Car.cars;
            DataGridCars.ItemsSource = cars;
        }
    }
}
