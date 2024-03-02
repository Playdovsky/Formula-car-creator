using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class HardTyre : Tyre
    {
        public int Speed { get; set; }
        public int Grip { get; set; }
        public int Durability { get; set; }

        public HardTyre()
        {
            Name = "Hard (white)";
            Tread = "Slick";
            DrivingConditions = "Dry";
            Speed = 6;
            Grip = 6;
            Durability = 1;
        }

        public override string TyreInfo()
        {
            string info = $"Name: {Name}\nTread type: {Tread}\nConditions: {DrivingConditions}\nSpeed: {Speed}\nGrip: {Grip}\nDurability: {Durability}\nHard tyres are slowest and have least grip to the surface but they are certainly the most durable. Use them for long races";
            return info;
        }
    }
}
