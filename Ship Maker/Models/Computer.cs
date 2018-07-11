namespace Ship_Maker.Models {
    public class Computer : PoweredEquipment {
        public int Bonus { get; private set; }
        public int Multiplier { get; private set; }
        public int Nodes { get; private set; }
        public int PCU { get; private set; }
    }
}