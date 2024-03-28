using System;

namespace Logic
{
    public abstract class Car
    {
        public int Number { get; set; }
        private byte _type;
        public byte Type { 
            get
            {
                return _type;
            }
            set
            {
                if (value > 0 && value <= 5)
                {
                    _type = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string Aerodynamics { get; set; }
        public string Engine { get; set; }
        public string Tyres { get; set; }

        public abstract string CarInfo();
    }
}
