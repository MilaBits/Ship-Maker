using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ship_Maker.Models {
    public class PowerCore : PoweredEquipment {
        
        [JsonProperty(Order = 10)]
        public int SEA { get; private set; }
        [JsonProperty(Order = 11)]
        public int StrainThreshold { get; private set; }
        [JsonProperty(Order = 12)]
        public int StrainReduction { get; private set; }
    }
}
