namespace Ship_Maker.Models {
    public class Armor : Equipment {
        
        public int HPMod { get; private set; }
        public int HullAC { get; private set; }
        public int DamageReduction { get; private set; }
    }
}