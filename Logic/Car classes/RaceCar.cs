using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class RaceCar : Car
    {
        public short MaxSpeed { get; set; }
        public short Acceleration { get; set; }
        public bool ApprovedByFIA { get; set; }

        public RaceCar(int number, byte type, string aerodynamics, string engine, string tyres, double brakes, short maxSpeed, short acceleration, bool approvedByFIA)
        {
            base.Number = number;
            base.Type = type;
            base.Aerodynamics = aerodynamics;
            base.Engine = engine;
            base.Tyres = tyres;
            base.Brakes = brakes;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            ApprovedByFIA = approvedByFIA;
        }
    }
}
