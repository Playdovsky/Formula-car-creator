using Logic;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

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
        private Car Car { get; set; }

        public RaceConversionWindow(List<Car> cars, Car selectedCar, int number, byte type, string aerodynamics, string engine, string tyres)
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

        }

        private void ConversionRace()
        {

        }
    }
}
