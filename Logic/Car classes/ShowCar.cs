namespace Logic
{
    public class ShowCar : Car
    {
        public string Advertisers { get; set; }
        public string Location { get; set; }
        public bool ForSale { get; set; }
        public double? Price { get; set; }

        public ShowCar(int number, byte type, string aerodynamics, string engine, string tyres, string advertisers, string location, bool forSale, double? price)
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
            string price;

            if (Price is null)
            {
                price = "Not for sale";
            }
            else
            {
                price = $"Is for sale\nPrice: {Price}$";
            }

            string info = $"Formula car - show car version\nshow car is made for motorsport shows as an attraction or made for sale on civilian market" +
                $"\n_________________________________________________________________________" +
                $"\n\nNumber: {Number}" +
                $"\nType: F{Type}" +
                $"\n\nAdvertisers: {Advertisers}" +
                $"\nWhere is located: {Location}" +
                $"\n{price}" +
                $"\n\nAerodynamics: {Aerodynamics}" +
                $"\nEngine: {Engine}" +
                $"\nTyres: {Tyres}";

            return info;
        }
    }
}
