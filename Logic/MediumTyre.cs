using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class MediumTyre : Tyre
    {
        public int Speed { get; set; }
        public int Grip { get; set; }
        public int Durability { get; set; }

        public MediumTyre()
        {
            Name = "Medium (yellow)";
            Tread = "Slick";
            DrivingConditions = "Dry";
            Speed = 3;
            Grip = 3;
            Durability = 4;
        }

        public override string TyreInfo()
        {
            string info = $"Name: {Name}\nTread type: {Tread}\nConditions: {DrivingConditions}\nSpeed: {Speed}\nGrip: {Grip}\nDurability: {Durability}\nMedium tyres are perfect balance between Hard and Soft. As the name implies, medium tyres are medium at every aspect. Use them when you don't know what to expect or if when you use balanced strategy.";
            return info;
        }
    }
}
