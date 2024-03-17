using System.Collections.Generic;

namespace Logic
{
    public class Car
    {
        public int Number { get; set; }
        public byte Type { get; set; }
        public string Aerodynamics { get; set; }
        public string Engine { get; set; }
        public string Tyres { get; set; }

        public static List<Car> cars = new List<Car>()
        {
            new Car() { Number = 21887, Type = 1, Aerodynamics = "Wings, spoiler, diffuser, lightweight compounds, DRS", Engine = "Mercedes-Benz V6 hybrid turbocharger, 850+160hp", Tyres = "Soft (red)"},
            new Car() { Number = 92170, Type = 5, Aerodynamics = "Wings, spoiler", Engine = "Honda V6 hybrid turbocharger, 700+50hp", Tyres = "Medium (yellow)"},
            new Car() { Number = 47185, Type = 3, Aerodynamics = "Wings, spoiler, diffuser", Engine = "Renault V6 hybrid turbocharger, 800+100hp", Tyres = "Intermediate (green)"},
            new Car() { Number = 54321, Type = 4, Aerodynamics = "Wings, spoiler, diffuser", Engine = "Red Bull V6 hybrid turbocharger, 880+110hp", Tyres = "Soft (red)"},
            new Car() { Number = 98765, Type = 1, Aerodynamics = "Wings, spoiler, diffuser, lightweight compounds, DRS", Engine = "Alpine V6 hybrid turbocharger, 750+80hp", Tyres = "Medium (yellow)"},
            new Car() { Number = 13579, Type = 3, Aerodynamics = "Wings, spoiler, diffuser, DRS", Engine = "AlphaTauri V6 hybrid turbocharger, 810+100hp", Tyres = "Intermediate (green)"},
            new Car() { Number = 24680, Type = 2, Aerodynamics = "Wings, spoiler, diffuser, DRS", Engine = "Williams V6 hybrid turbocharger, 790+85hp", Tyres = "Hard (white)"},
            new Car() { Number = 86420, Type = 4, Aerodynamics = "Wings, spoiler, diffuser", Engine = "Haas V6 hybrid turbocharger, 780+95hp", Tyres = "Soft (red)"},
            new Car() { Number = 97531, Type = 5, Aerodynamics = "Wings, spoiler", Engine = "Aston Martin V6 hybrid turbocharger, 820+110hp", Tyres = "Medium (yellow)"},
            new Car() { Number = 35791, Type = 1, Aerodynamics = "Wings, spoiler, diffuser, lightweight compounds, DRS", Engine = "Alfa Romeo V6 hybrid turbocharger, 760+70hp", Tyres = "Soft (red)"},
            new Car() { Number = 15973, Type = 3, Aerodynamics = "Wings, spoiler, diffuser, lightweight compounds", Engine = "Alpine V6 hybrid turbocharger, 800+90hp", Tyres = "Intermediate (green)"}
        };

        public virtual string CarInfo()
        {
            string info = $"F1 car - basic version\nmade for further modifications, testing, improvements and research" +
                $"\n_________________________________________________________________________" +
                $"\n\nNumber: {Number}" +
                $"\nType: F{Type}" +
                $"\n\nAerodynamics: {Aerodynamics}" +
                $"\nEngine: {Engine}" +
                $"\nTyres: {Tyres}";

            return info;
        }
    }
}
