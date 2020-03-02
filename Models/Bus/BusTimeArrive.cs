using System.Collections.Generic;

namespace MásMovilidad.Models.Bus
{
    public class BusTimeArrive
    {
        public string code { get; set; }
        public dynamic description { get; set; }
        public string datetime { get; set; }
        public List<BusData> data { get; set; }
    }
}