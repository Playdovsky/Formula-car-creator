namespace Logic
{
    public class ShowCar : Car
    {
        public string Advertisers { get; set; }
        public string Location { get; set; }
        public bool ForSale { get; set; }
        public string Price { get; set; }

        public ShowCar(int number, byte type, string aerodynamics, string engine, string tyres, string advertisers, string location, bool forSale, string price)
        {
            base.Number = number;
            base.Type = type;
            base.Aerodynamics = aerodynamics;
            base.Engine = engine;
            base.Tyres = tyres;
            Advertisers = advertisers;
            Location = location;
            ForSale = forSale;
            Price = price;
        }

        public override string CarInfo()
        {
            string info = $"F1 car - show car version\nshow car is made for motorsport shows as an attraction or made for sale on civilian market." +
                $"\n_________________________________________________________________________" +
                $"\n\nNumber: {Number}" +
                $"\nType: F{Type}" +
                $"\n\nWho will be advertiser: {Advertisers}" +
                $"\nWhere is located: {Location}" +
                $"\nIs this car for sale: {ForSale}" +
                $"\nPrice: {Price}" +
                $"\n\nAerodynamics: {Aerodynamics}" +
                $"\nEngine: {Engine}" +
                $"\nTyres: {Tyres}";

            return info;
        }
    }
}
