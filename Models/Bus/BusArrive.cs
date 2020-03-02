namespace MásMovilidad.Models.Bus
{
    public class BusArrive
    {
        public string line { get; set; }
        public string stop { get; set; }
        public string isHead { get; set; }
        public string destination { get; set; }
        public int deviation { get; set; }
        public int bus { get; set; }
        public BusGeometry geometry { get; set; }
        public int estimateArrive { get; set; }
        public int DistanceBus { get; set; }
        public string positionTypeBus { get; set; }
    }
}