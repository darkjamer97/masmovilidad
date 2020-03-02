using System.Collections.Generic;

namespace MásMovilidad.Models.BiciMad
{
    public class BiciMad
    {
        public string code { get; set; }
        public string description { get; set; }
        public string datetime { get; set; }
        public List<BiciMadData> data { get; set; }
    }
}