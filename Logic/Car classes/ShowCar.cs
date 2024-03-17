using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class ShowCar : Car
    {
        public bool ForSale { get; set; }
        public string Advertiser { get; set; }

        public ShowCar(int number, byte type, string aerodynamics, string engine, string tyres, bool forSale, string advertiser)
        {
            base.Number = number;
            base.Type = type;
            base.Aerodynamics = aerodynamics;
            base.Engine = engine;
            base.Tyres = tyres;
            ForSale = forSale;
            Advertiser = advertiser;
        }

        public override string CarInfo()
        {
            string info = $"F1 car - show car version\nshow car is made for motorsport shows as an attraction or made for sale on civilian market." +
                $"\n_________________________________________________________________________" +
                $"\n\nNumber: {Number}" +
                $"\nType: F{Type}" +
                $"\n\nWho will be advertiser: {Advertiser}" +
                $"\nIs this car for sale: {ForSale}" +
                $"\n\nAerodynamics: {Aerodynamics}" +
                $"\nEngine: {Engine}" +
                $"\nTyres: {Tyres}";

            return info;
        }
    }
}
