using System.Collections.Generic;

namespace MásMovilidad.Models.Bus
{
    public class BusData
    {
        public List<BusStops> stops { get; set; }
        public List<BusArrive> Arrive { get; set; }
        public List<BusStopInfo> StopInfo { get; set; }
        public string[] ExtraInfo { get; set; }
        public BusIncident Incident { get; set; }
    }
}