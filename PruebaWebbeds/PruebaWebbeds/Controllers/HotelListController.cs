using Microsoft.AspNetCore.Mvc;
using PruebaWebbeds.Models;
using PruebaWebbeds.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PruebaWebbeds.Controllers
{
    [Route("[controller]")]
    public class HotelListController : Controller
    {
        private IHotelListService ihotelList;
        public HotelListController(IHotelListService i)
        {
            ihotelList = i;
        }
        [HttpGet]
        public async Task<List<Offer>> getAvailability(int nights, int id, string code)
        {
            return await ihotelList.getAvailability(nights, id, code);
        }
    }
}