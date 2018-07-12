using System;
using Ship_Maker.Models.Enums;

namespace Ship_Maker.Models {
    public class Frame {

        public string Name { get; set; }
        public string Outline { get; set; }
        public SizeClass Size { get; set; }
        public int MaxCrew { get; set; }
        public int BPCost { get; set; }
    }
}
