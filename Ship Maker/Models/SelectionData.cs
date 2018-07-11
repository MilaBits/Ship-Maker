using Ship_Maker.Models.Enums;

namespace Ship_Maker.Models {
    public class SelectionData {
        
        public Frame Frame { get; set; }
        
        public PowerCore PowerCore { get; set; }

        public Armor Armor { get; set; }
        public Shield Shield { get; set; }
        
        public Thrusters Thrusters { get; set; }
        
        public Computer Computer { get; set; }
        public Transponder Transponder { get; set; }
        
        public UniqueWeapon UniqueWeapon { get; set; }
        public UniqueSystem UniqueSystem { get; set; }
    }
}