namespace MásMovilidad.Models.Bus
{
    public class BusListaIncidentData
    {
        public string title { get; set; }
        public string guid { get; set; }
        public string description { get; set; }
        public string pubDate { get; set; }
        public string rssFrom { get; set; }
        public string rssTo { get; set; }
        public string cause { get; set; }
        public string effect { get; set; }
        public BusListaIncidentDataMoreInfo moreInfo { get; set; }
    }
}