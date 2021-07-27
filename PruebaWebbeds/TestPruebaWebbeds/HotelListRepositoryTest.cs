using PruebaWebbeds.Infrastructure;
using PruebaWebbeds.Models;
using System;
using Xunit;

namespace TestPruebaWebbeds
{
    public class HotelListRepositoryTest
    {
        [Fact]
        public void validate_availability()
        {
            // hace una prueba unitaria que comprueba que se recoge toda la disponibilidad
            var repo = new HotelListRepository();
            var offers = repo.getAvailability(2,1419, "aWH1EX7ladA8C / oWJX5nVLoEa4XKz2a64yaWVvzioNYcEo8Le8caJw ==");
            Assert.NotNull(offers);
        }
    }
}
