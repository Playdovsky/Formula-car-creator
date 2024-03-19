using System.Collections.Generic;

namespace Logic
{
    public abstract class Car
    {
        public int Number { get; set; }
        public byte Type { get; set; }
        public string Aerodynamics { get; set; }
        public string Engine { get; set; }
        public string Tyres { get; set; }

        public abstract string CarInfo();
    }
}
