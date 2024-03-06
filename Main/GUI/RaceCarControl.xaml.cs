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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Main
{
    /// <summary>
    /// Logika interakcji dla klasy RaceCarControl.xaml
    /// </summary>
    public partial class RaceCarControl : UserControl
    {
        public RaceCarControl()
        {
            InitializeComponent();
        }

        private void ButtonBuild_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int number = int.Parse(TextBoxNumber.Text);
                byte type = byte.Parse(TextBoxType.Text);
                
                string aerodynamics = ComboBoxAerodynamics.SelectionBoxItem.ToString();
                string engine = ComboBoxEngine.SelectionBoxItem.ToString();
                string tyres = ComboBoxTyres.SelectionBoxItem.ToString();

                if (aerodynamics.Length <= 0 || engine.Length <= 0 || tyres.Length <= 0)
                {
                    throw new FormatException();
                }

                double brakes = double.Parse(TextBoxBrakes.Text);
                short maxSpeed = short.Parse(TextBoxMaxSpeed.Text);
                double acceleration = double.Parse(TextBoxAcceleration.Text);

                if (brakes > 100 || maxSpeed > 500 || acceleration > 10)
                {
                    throw new Exception();
                }
                
                bool fia = CheckBoxFIA.IsChecked.Value;

                RaceCar raceCar = new RaceCar(number, type, aerodynamics, engine, tyres, brakes, maxSpeed, acceleration, fia);
                Car.cars.Add(raceCar);

                MessageBox.Show($"You have created new formula {type} car!");
            }
            catch (FormatException)
            {
                MessageBox.Show($"You either entered information in the wrong format or did not provide any information at all at certain fields. Please check sheet fields once again and make sure everything is in correct format\n");
            }
            catch (Exception)
            {
                MessageBox.Show($"Information you provided is too untrue to be used in a new formula car.");
            }
        }
    }
}
