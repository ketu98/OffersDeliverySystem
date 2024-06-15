
using Microsoft.AspNetCore.Mvc;
using OffersDeliverySystem.Services;
using OffersDeliverySystem.Models;
using System.Collections.Generic;

namespace OffersDeliverySystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OffersController : ControllerBase
    {
        private readonly OfferService _offerService;

        public OffersController()
        {
            _offerService = new OfferService();
        }

        [HttpGet]
        public IEnumerable<Offer> Get()
        {
            return _offerService.GetOffers();
        }

        [HttpPost]
        public void Post([FromBody] Offer offer)
        {
            _offerService.CreateOffer(offer);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _offerService.DeleteOffer(id);
        }
    }
}
