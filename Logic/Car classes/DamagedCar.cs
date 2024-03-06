using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Logic
{
    public class DamagedCar : Car
    {
        public string Reason { get; set; }
        public string DamagedComponents { get; set; }
        public string CanBeFixed { get; set; }
        public short RepairTime { get; set; }

        public DamagedCar(int number, byte type, string aerodynamics, string engine, string tyres, double brakes, string reason, string damagedComponents, string canBeFixed, short repairTime) 
        {
            base.Number = number;
            base.Type = type;
            base.Aerodynamics = aerodynamics;
            base.Engine = engine;
            base.Tyres = tyres;
            Reason = reason;
            DamagedComponents = damagedComponents;
            CanBeFixed = canBeFixed;
            RepairTime = repairTime;
        }
    }
}
