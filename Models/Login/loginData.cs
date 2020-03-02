namespace MásMovilidad.Models.Login
{
    public class loginData
    {
        public string email { get; set; }
        public string userName { get; set; }
        public string idUser { get; set; }
        public string accessToken { get; set; }
        public int tokenSecExpiration { get; set; }
    }
}