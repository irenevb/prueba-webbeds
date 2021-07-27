using PruebaWebbeds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace PruebaWebbeds.Infrastructure
{
    public class HotelListRepository: IHotelListRepository
    {
        public static string URL = "https://webbedsdevtest.azurewebsites.net/api/findBargain?destinationId=1419&nights=5&code=aWH1EX7ladA8C/oWJX5nVLoEa4XKz2a64yaWVvzioNYcEo8Le8caJw==";

        public async Task<List<Offer>> getAvailability()
        {

            //pide la disponibilidad a la api
            List<Offer> hotelAvailability = new List<Offer>();
            try
            {
                // hacer la llamada a la api
                var response = await new HttpClient().GetStringAsync(URL);
                // coge la respuesta en formato json y crea la lista de ofertas a partir de este
                return JsonConvert.DeserializeObject<List<Offer>>(response);

            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
