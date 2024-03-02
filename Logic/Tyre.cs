using System;
using System.Net.Http;

namespace Logic
{
    public class Tyre
    {
        public string Name { get; set; }
        public string Tread { get; set; }
        public string DrivingConditions { get; set; }

        public virtual string TyreInfo()
        {
            return $"Tyres are the main factor during the race, there are many of them and every has it's own purpose.";
        }
    }
}
