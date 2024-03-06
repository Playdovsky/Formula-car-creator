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
using Logic;

namespace Main
{
    public partial class MainWindow : Window
    {
        private bool basicCar;

        public MainWindow()
        {
            InitializeComponent();
            InitializeContent();
        }

        private void InitializeContent()
        {
            CarControl carControl = new CarControl();
            ContentControl.Content = carControl;
            basicCar = true;
        }

        private void ButtonCarList_Click(object sender, RoutedEventArgs e)
        {
            GarageWindow garageWindow = new GarageWindow();
            garageWindow.Show();
        }

        private void ButtonCarType_Click(object sender, RoutedEventArgs e)
        {
            if (basicCar)
            {
                RaceCarControl raceCarControl = new RaceCarControl();
                ContentControl.Content = raceCarControl;
                basicCar = false;
            }
            else
            {
                InitializeContent();
            }
        }
    }
}
