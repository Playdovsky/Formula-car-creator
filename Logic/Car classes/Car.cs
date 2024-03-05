using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public abstract class Car
    {
        protected int Number { get; set; }
        protected byte Type { get; set; }
        protected string Aerodynamics { get; set; }
        protected string Engine { get; set; }
        protected string Tyres { get; set; }
        protected string Brakes { get; set; }
    }
}
