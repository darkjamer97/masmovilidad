using System.Collections.Generic;

namespace MásMovilidad.Models.Bus
{
    public class BusStops
    {
        public string stop { get; set; }
        public string name { get; set; }
        public string postalAddress { get; set; }
        public BusGeometry geometry { get; set; }
        public string pvm { get; set; }
        public List<BusDateLine> dataLine { get; set; }
    }
}