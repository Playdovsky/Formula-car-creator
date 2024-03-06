﻿using System;
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
    /// <summary>
    /// Logika interakcji dla klasy CarControl.xaml
    /// </summary>
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

                Car car = new Car { Number = number, Type = type, Aerodynamics = aerodynamics, Engine = engine, Tyres = tyres };
                Car.cars.Add(car);

                MessageBox.Show($"You have created new formula {type} car!");
            }
            catch(FormatException)
            {
                MessageBox.Show($"You either entered information in the wrong format or did not provide any information at all at certain fields. Please check sheet fields once again and make sure everything is in correct format\n");
            }
        }
    }
}
