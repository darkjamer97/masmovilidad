using System;
using System.Net.Http;
using System.Threading.Tasks;
using MásMovilidad.Models.Login;
using MásMovilidad.Models.Bus;
using MásMovilidad.Models.BiciMad;
using System.Text.Json;
using System.Collections;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MásMovilidad.Services
{
    public static class Http_EMT_Client
    {
        public static HttpClient AddHeaders()
        {
            var httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://openapi.emtmadrid.es/v1/");
            httpClient.DefaultRequestHeaders.Add("email", "dialcuni@hotmail.com");
            httpClient.DefaultRequestHeaders.Add("password", "Hola_1234");
            httpClient.DefaultRequestHeaders.Add("X-ApiKey", "42f67f1b-eb72-4d82-8cdc-300171db02ac");
            httpClient.DefaultRequestHeaders.Add("X-ClientId", "c34e800d-a730-4602-b504-3d3cf0bd7fb9");

            return httpClient;
        }

        public static async Task<string> GetAccesToken()
        {
            Login login = new Login();

            using (var httpClient = AddHeaders())
            {
                using (var response = await httpClient.GetAsync("mobilitylabs/user/login/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        login = JsonSerializer.Deserialize<Login>(apiResponse);
                    }
                }
            }
            
            return login.data[0].accessToken;
        }

        public static async Task<Bus> GetBusDetail(string stopNumber)
        {
            var bus = new Bus();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("accessToken", GetAccesToken().Result);
                httpClient.BaseAddress = new Uri("https://openapi.emtmadrid.es/v1/transport/busemtmad/");

                using (var response = await httpClient.GetAsync($"stops/{stopNumber}/detail/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        bus = JsonSerializer.Deserialize<Bus>(apiResponse);
                    }
                }
            }
            return bus;
        }

        public static async Task<BusTimeArrive> PostTimeArrive(string stopNumber, string busNumber)
        {
            var bus = new BusTimeArrive();

            var content = new StringContent(@"{
                ""cultureInfo"":""ES"",
                ""Text_StopRequired_YN"":""Y"",
                ""Text_EstimationsRequired_YN"":""Y"",
                ""Text_IncidencesRequired_YN"":""Y"",
                ""DateTime_Referenced_Incidencies_YYYYMMDD"":"""+DateTime.Now.ToString("yyyyMMdd")+"\"}");
            
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("accessToken", GetAccesToken().Result);
                httpClient.BaseAddress = new Uri("https://openapi.emtmadrid.es/v2/transport/busemtmad/");

                using (var response = await httpClient.PostAsync($"stops/{stopNumber}/arrives/{busNumber}", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        bus = JsonSerializer.Deserialize<BusTimeArrive>(apiResponse);                                  
                    }
                }
            }

            return bus;
        }

        public static async Task<BiciMad> GetBiciMadDetail(string idStation)
        {
            var biciMad = new BiciMad();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("accessToken", GetAccesToken().Result);
                httpClient.BaseAddress = new Uri("https://openapi.emtmadrid.es/v1/transport/bicimad/");

                using (var response = await httpClient.GetAsync($"stations/{idStation}/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        biciMad = JsonSerializer.Deserialize<BiciMad>(apiResponse);
                    }
                }
            }
            return biciMad;
        }
    }
}