using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Car
    {
        public int Number { get; set; }
        public byte Type { get; set; }
        public string Aerodynamics { get; set; }
        public string Engine { get; set; }
        public string Tyres { get; set; }
        public double Brakes { get; set; }

        public static List<Car> cars = new List<Car>()
        {
            new Car() { Number = 21887, Type = 1, Aerodynamics = "Wings, spoiler, lightweight compounds, DRS", Engine = "Mercedes-Benz V6 hybrid turbocharger, 850+160hp", Brakes = 51.5, Tyres = "Soft (red)"},
            new Car() { Number = 92170, Type = 5, Aerodynamics = "Wings, spoiler", Engine = "Honda V6 hybrid turbocharger, 700+50hp", Brakes = 50, Tyres = "Medium (yellow)"},
            new Car() { Number = 47185, Type = 3, Aerodynamics = "Wings, spoiler, DRS", Engine = "Renault V6 hybrid turbocharger, 800+100hp", Brakes = 55, Tyres = "Intermediate (green)"}
        };

        public virtual string CarInfo()
        {
            string info = $"Your F1 car:\nNumber: {Number}\nType: F{Type}\nAerodynamics: {Aerodynamics}\nEngine: {Engine}\nBrakes balance: {Brakes}\nTyres: {Tyres}";
            return info;
        }
    }
}
