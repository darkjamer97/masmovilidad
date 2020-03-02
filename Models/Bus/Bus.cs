using System.Collections.Generic;

namespace MásMovilidad.Models.Bus
{
    public class Bus
    {
        public string code { get; set; }
        public string description { get; set; }
        public string datetime { get; set; }
        public List<BusData> data { get; set; }
    }
}