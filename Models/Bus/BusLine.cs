namespace MásMovilidad.Models.Bus
{
    public class BusLine
    {
        public string line { get; set; }
        public string label { get; set; }
        public string nameA { get; set; }
        public string nameB { get; set; }
        public int metersFromHeader { get; set; }
        public string to { get; set; }
    }
}