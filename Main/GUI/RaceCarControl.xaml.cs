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
            int number = int.Parse(TextBoxNumber.Text);
            byte type = byte.Parse(TextBoxType.Text);
            string aerodynamics = ComboBoxAerodynamics.SelectionBoxItem.ToString();
            string engine = ComboBoxEngine.SelectionBoxItem.ToString();
            string tyres = ComboBoxTyres.SelectionBoxItem.ToString();
            double brakes = double.Parse(TextBoxBrakes.Text);
            short maxSpeed = short.Parse(TextBoxMaxSpeed.Text);
            double acceleration = double.Parse(TextBoxAcceleration.Text);
            bool fia = CheckBoxFIA.IsChecked.Value;

            RaceCar raceCar = new RaceCar(number, type, aerodynamics, engine, tyres, brakes, maxSpeed, acceleration, fia);
            Car.cars.Add(raceCar);
        }
    }
}
