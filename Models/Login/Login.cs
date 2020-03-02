using System.Collections.Generic;

namespace MásMovilidad.Models.Login
{
    public class Login
    {
        public string code { get; set; }
        public string description { get; set; }
        public string datetime { get; set; }
        public List<loginData> data { get; set; }
    }
}