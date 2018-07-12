using Newtonsoft.Json;

namespace Ship_Maker.Models.Enums {
    public class Transponder : PoweredEquipment {
        
        [JsonProperty(Order = 10)]
        public int TargetLockBonus { get; private set; }
        [JsonProperty(Order = 11)]
        public int ScanPoints { get; private set; }
    }
}