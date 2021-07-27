using PruebaWebbeds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaWebbeds.Services
{
    public interface IHotelListService
    {
        Task<List<Offer>> getAvailability(int nights, int id, string code);
    }
}
