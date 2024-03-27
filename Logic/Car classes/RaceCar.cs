using System;
using System.Collections.Generic;

namespace Logic
{
    public class RaceCar : Car
    {
        private short _maxSpeed;
        public short MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value < 500)
                {
                    _maxSpeed = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private double _brakesBalance;
        public double BrakesBalance {
            get 
            {
                return _brakesBalance;
            } 
            set
            {
                if (value > 10 && value < 90)
                {
                    _brakesBalance = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            } 
        }

        private double _acceleration;
        public double Acceleration {
            get
            {
                return _acceleration;
            }
            set
            {
                if (value > 1.8 && value < 7)
                {
                    _acceleration = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public bool ApprovedByFIA { get; set; }

        public RaceCar(int number, byte type, string aerodynamics, string engine, string tyres, double brakes, short maxSpeed, double acceleration, bool approvedByFIA)
        {
            base.Number = number;
            base.Type = type;
            base.Aerodynamics = aerodynamics;
            base.Engine = engine;
            base.Tyres = tyres;
            MaxSpeed = maxSpeed;
            BrakesBalance = brakes;
            Acceleration = acceleration;
            ApprovedByFIA = approvedByFIA;
        }

        public RaceCar() { }

        public static List<Car> cars = new List<Car>()
        {
            new RaceCar() { Number = 21887, Type = 1, Aerodynamics = "Wings, spoiler, diffuser, lightweight compounds, DRS", Engine = "Mercedes-Benz V6 hybrid turbocharger, 850+160hp", Tyres = "Soft (red)", Acceleration = 2, ApprovedByFIA = true, BrakesBalance = 52.5, MaxSpeed = 350},
            new RaceCar() { Number = 92170, Type = 5, Aerodynamics = "Wings, spoiler", Engine = "Honda V6 hybrid turbocharger, 700+50hp", Tyres = "Medium (yellow)", Acceleration = 3, ApprovedByFIA = true, BrakesBalance = 60, MaxSpeed = 290},
            new RaceCar() { Number = 47185, Type = 3, Aerodynamics = "Wings, spoiler, diffuser", Engine = "Renault V6 hybrid turbocharger, 800+100hp", Tyres = "Intermediate (green)", Acceleration = 2.5, ApprovedByFIA = true, BrakesBalance = 50, MaxSpeed = 315},
            new RaceCar() { Number = 54321, Type = 2, Aerodynamics = "Wings, spoiler, diffuser", Engine = "Red Bull V6 hybrid turbocharger, 880+110hp", Tyres = "Soft (red)", Acceleration = 2.2, ApprovedByFIA = false, BrakesBalance = 53.7, MaxSpeed = 349},
            new RaceCar() { Number = 98765, Type = 1, Aerodynamics = "Wings, spoiler, diffuser, lightweight compounds, DRS", Engine = "Alpine V6 hybrid turbocharger, 750+80hp", Tyres = "Medium (yellow)", Acceleration = 2.7, ApprovedByFIA = true, BrakesBalance = 56.1, MaxSpeed = 300},
            new RaceCar() { Number = 13579, Type = 3, Aerodynamics = "Wings, spoiler, diffuser, DRS", Engine = "AlphaTauri V6 hybrid turbocharger, 810+100hp", Tyres = "Intermediate (green)", Acceleration = 2.2, ApprovedByFIA = false, BrakesBalance = 49.2, MaxSpeed = 310},
            new RaceCar() { Number = 24680, Type = 2, Aerodynamics = "Wings, spoiler, diffuser, DRS", Engine = "Williams V6 hybrid turbocharger, 790+85hp", Tyres = "Hard (white)", Acceleration = 2.6, ApprovedByFIA = true, BrakesBalance = 51, MaxSpeed = 297},
            new RaceCar() { Number = 86420, Type = 4, Aerodynamics = "Wings, spoiler, diffuser", Engine = "Haas V6 hybrid turbocharger, 780+95hp", Tyres = "Soft (red)", Acceleration = 2.6, ApprovedByFIA = true, BrakesBalance = 54.8, MaxSpeed = 300},
            new RaceCar() { Number = 97531, Type = 5, Aerodynamics = "Wings, spoiler", Engine = "Aston Martin V6 hybrid turbocharger, 820+110hp", Tyres = "Medium (yellow)", Acceleration = 2.4, ApprovedByFIA = false, BrakesBalance = 63.5, MaxSpeed = 325},
            new RaceCar() { Number = 35791, Type = 1, Aerodynamics = "Wings, spoiler, diffuser, lightweight compounds, DRS", Engine = "Alfa Romeo V6 hybrid turbocharger, 760+70hp", Tyres = "Soft (red)", Acceleration = 2.7, ApprovedByFIA = true, BrakesBalance = 55.5, MaxSpeed = 308},
            new RaceCar() { Number = 15973, Type = 3, Aerodynamics = "Wings, spoiler, diffuser, lightweight compounds", Engine = "Alpine V6 hybrid turbocharger, 800+90hp", Tyres = "Intermediate (green)", Acceleration = 2.5, ApprovedByFIA = false, BrakesBalance = 50.9, MaxSpeed = 317}
        };

        public override string CarInfo()
        {
            string info = $"Formula car - race version\nmade specifically for racing in formula competition" +
                $"\n_________________________________________________________________________" +
                $"\n\nNumber: {Number}" +
                $"\nType: F{Type}" +
                $"\nApproved by FIA: {ApprovedByFIA}" +
                $"\n\nMax speed: {MaxSpeed}km/h" +
                $"\nAcceleration (0-100km): {Acceleration}s" +
                $"\nBrakes balance: {BrakesBalance}%" +
                $"\n\nAerodynamics: {Aerodynamics}" +
                $"\nEngine: {Engine}" +
                $"\nTyres: {Tyres}";

            return info;
        }
    }
}
