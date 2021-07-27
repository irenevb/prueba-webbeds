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
        public static string URL = "https://webbedsdevtest.azurewebsites.net/api/findBargain?";

        public async Task<List<Offer>> getAvailability(int nights, int id, string code)
        {
            URL += "destinationId="+id+"&nights="+nights+"&code="+code;
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
