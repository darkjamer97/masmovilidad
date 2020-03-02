using MásMovilidad.Models.Bus;

namespace MásMovilidad.Models.BiciMad
{
    public class BiciMadData
    {
        public int activate { get; set; }
        public string name { get; set; }
        public int reservations_count { get; set; }
        public BusGeometry geometry { get; set; }
        public int light { get; set; }
        public int total_bases { get; set; }
        public string address { get; set; }
        public string number { get; set; }
        public int no_available { get; set; }
        public int free_bases { get; set; }
        public int dock_bikes { get; set; }
        public int id { get; set; }
    }
}