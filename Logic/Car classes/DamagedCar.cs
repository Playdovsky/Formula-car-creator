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
        public bool CanBeFixed { get; set; }
        public string RepairTime { get; set; }

        public DamagedCar(int number, byte type, string aerodynamics, string engine, string tyres, string reason, string damagedComponents, bool canBeFixed, string repairTime) 
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

        public override string CarInfo()
        {
            string info = $"F1 car - damaged version\ndamaged car designated for repairs or disassemble" +
                $"\n_________________________________________________________________________" +
                $"\n\nNumber: {Number}" +
                $"\nType: F{Type}" +
                $"\n\nWhy was damaged: {Reason}" +
                $"\nDamaged components: {DamagedComponents}" +
                $"\nCan be fixed: {CanBeFixed}" +
                $"\nRepair time: {RepairTime}" +
                $"\n\nAerodynamics: {Aerodynamics}" +
                $"\nEngine: {Engine}" +
                $"\nTyres: {Tyres}";

            return info;
        }
    }
}
