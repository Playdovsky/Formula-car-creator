namespace Logic
{
    public class RaceCar : Car
    {
        public short MaxSpeed { get; set; }
        public double BrakesBalance { get; set; }
        public double Acceleration { get; set; }
        public bool ApprovedByFIA { get; set; }

        public RaceCar(int number, byte type, string aerodynamics, string engine, string tyres, double brakes, short maxSpeed, double acceleration, bool approvedByFIA)
        {
            base.Number = number;
            base.Type = type;
            base.Aerodynamics = aerodynamics;
            base.Engine = engine;
            base.Tyres = tyres;
            MaxSpeed = maxSpeed;
            BrakesBalance = brakes;
            Acceleration = acceleration;
            ApprovedByFIA = approvedByFIA;
        }

        public override string CarInfo()
        {
            string info = $"F1 car - race version\nmade specifically for racing in formula competition" +
                $"\n_________________________________________________________________________" +
                $"\n\nNumber: {Number}" +
                $"\nType: F{Type}" +
                $"\nApproved by FIA: {ApprovedByFIA}" +
                $"\n\nMax speed: {MaxSpeed}km/h" +
                $"\nAcceleration (0-100km): {Acceleration}s" +
                $"\nBrakes balance: {BrakesBalance}%" +
                $"\n\nAerodynamics: {Aerodynamics}" +
                $"\nEngine: {Engine}" +
                $"\nTyres: {Tyres}";

            return info;
        }
    }
}
