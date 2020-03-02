using System.Collections.Generic;

namespace MásMovilidad.Models.Bus
{
    public class BusStopInfo
    {
        public List<BusLine> lines { get; set; }
        public string stopId { get; set; }
        public string stopName { get; set; }
        public BusDateLine geometry { get; set; }
        public string Direction { get; set; }
    }
}