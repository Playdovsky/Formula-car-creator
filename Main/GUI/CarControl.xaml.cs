using System;
using System.Windows;
using System.Windows.Controls;
using Logic;

namespace Main
{
    public partial class CarControl : UserControl
    {
        public CarControl()
        {
            InitializeComponent();
        }

        private void ButtonBuild_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = int.Parse((TextBoxNumber.Text));
                byte type = byte.Parse((TextBoxType.Text));

                string aerodynamics = ComboBoxAerodynamics.SelectionBoxItem.ToString();
                string engine = ComboBoxEngine.SelectionBoxItem.ToString();
                string tyres = ComboBoxTyres.SelectionBoxItem.ToString();
                
                if (aerodynamics.Length <= 0 || engine.Length <= 0 || tyres.Length <= 0)
                {
                    throw new FormatException();
                }

                //Car car = new Car { Number = number, Type = type, Aerodynamics = aerodynamics, Engine = engine, Tyres = tyres };
                //RaceCar.cars.Add(car);

                MessageBox.Show($"You have created new formula {type} car!");
            }
            catch(FormatException)
            {
                MessageBox.Show($"You either entered information in the wrong format or did not provide any information at all at certain fields. Please check sheet fields once again and make sure everything is in correct format\n");
            }
        }
    }
}
