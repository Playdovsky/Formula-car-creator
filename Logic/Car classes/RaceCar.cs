using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class RaceCar : Car
    {
        public short MaxSpeed { get; set; }
        public double BrakesBalance { get; set; }
        public double Acceleration { get; set; }
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
    }
}
