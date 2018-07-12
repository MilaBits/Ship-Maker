using Ship_Maker.Models.Enums;

namespace Ship_Maker.Models {
    public class Seat {
        public Role Role { get; set; }
        public Role SecondaryRole { get; set; }
        public SeatType Type { get; set; }
    }
}