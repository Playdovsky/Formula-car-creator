namespace Logic
{
    public class DamagedCar : Car
    {
        public string Reason { get; set; }
        public string DamagedComponents { get; set; }
        public bool CanBeFixed { get; set; }
        public int? RepairTime { get; set; }

        public DamagedCar(int number, byte type, string aerodynamics, string engine, string tyres, string reason, string damagedComponents, bool canBeFixed, int? repairTime) 
        {
            base.Number = number;
            base.Type = type;
            base.Aerodynamics = aerodynamics;
            base.Engine = engine;
            base.Tyres = tyres;
            Reason = reason;
            DamagedComponents = damagedComponents;
            CanBeFixed = canBeFixed;
            RepairTime = repairTime;
        }

        public override string CarInfo()
        {
            string repair;

            if (RepairTime is null)
            {
                repair = "Cannot be repaired";
            }
            else
            {
                repair = $"Can be fixed\nRepair time: {RepairTime}h";
            }

            string info = $"Formula car - damaged version\ndamaged car designated for repairs or disassemble" +
                    $"\n_________________________________________________________________________" +
                    $"\n\nNumber: {Number}" +
                    $"\nType: F{Type}" +
                    $"\n\nWhy has been damaged: {Reason}" +
                    $"\nDamaged components: {DamagedComponents}" +
                    $"\n{repair}" +
                    $"\n\nAerodynamics: {Aerodynamics}" +
                    $"\nEngine: {Engine}" +
                    $"\nTyres: {Tyres}";

            return info;
        }
    }
}
