using Logic;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Main
{
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
                bool fia = CheckBoxFIA.IsChecked.Value;

                RaceCar raceCar = new RaceCar(number, type, aerodynamics, engine, tyres, brakes, maxSpeed, acceleration, fia);
                RaceCar.cars.Add(raceCar);

                MessageBox.Show($"You have created new formula {type} car!");
            }
            catch (FormatException)
            {
                MessageBox.Show("You either entered information in the wrong format or did not provide any information at all at certain fields. Please check sheet fields once again and make sure everything is in correct format\n");
            }
            catch (Exception)
            {
                MessageBox.Show("Information you provided is too untrue to be used in a new formula car.");
            }
        }
    }
}
