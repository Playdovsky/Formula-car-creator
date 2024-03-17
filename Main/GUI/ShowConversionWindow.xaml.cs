using Logic;
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

namespace Main
{
    public partial class ShowConversionWindow : Window
    {
        private int Number { get; set; }
        private byte Type { get; set; }
        private string Aerodynamics { get; set; }
        private string Engine { get; set; }
        private string Tyres { get; set; }

        public ShowConversionWindow(int number, byte type, string aerodynamics, string engine, string tyres)
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
            string advertiser = TextBoxAdvertiser.Text;
            bool forSale = CheckBoxForSale.IsChecked.Value;
            ConversionShow(advertiser, forSale);
        }

        public void ConversionShow(string advertiser, bool forSale)
        {
            ShowCar showCar = new ShowCar(Number, Type, Aerodynamics, Engine, Tyres, forSale, advertiser);
            Car.cars.Add(showCar);
            MessageBox.Show("Conversion successfull, car is now marked for show.");
        }
    }
}
