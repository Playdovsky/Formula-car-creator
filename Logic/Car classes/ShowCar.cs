using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class ShowCar : Car
    {
        public bool ForSale { get; set; }
        public string Advertiser { get; set; }

        public ShowCar(int number, byte type, string aerodynamics, string engine, string tyres, string brakes, bool forSale, string advertiser)
        {
            base.Number = number;
            base.Type = type;
            base.Aerodynamics = aerodynamics;
            base.Engine = engine;
            base.Tyres = tyres;
            base.Brakes = brakes;
            ForSale = forSale;
            Advertiser = advertiser;
        }
    }
}
