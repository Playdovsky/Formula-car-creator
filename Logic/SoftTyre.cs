using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Logic
{
    public class SoftTyre : Tyre
    {
        public int Speed { get; set; }
        public int Grip { get; set; }
        public int Durability { get; set; }

        public SoftTyre()
        {
            Name = "Soft (red)";
            Tread = "Slick";
            DrivingConditions = "Dry";
            Speed = 1;
            Grip = 1;
            Durability = 6;
        }

        public override string TyreInfo()
        {
            string info = $"Name: {Name}\nTread type: {Tread}\nConditions: {DrivingConditions}\nSpeed: {Speed}\nGrip: {Grip}\nDurability: {Durability}\nSoft tyres provide speed and grip that is unmatched when compared to other tyres but as they say great power comes with great responsibility thus soft tyres are also least durable. Use them for short races.";
            return info;
        }
    }
}
