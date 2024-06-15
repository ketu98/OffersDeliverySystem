
using OffersDeliverySystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace OffersDeliverySystem.Services
{
    public class OfferService
    {
        private List<Offer> offers = new List<Offer>();

        public IEnumerable<Offer> GetOffers()
        {
            return offers;
        }

        public void CreateOffer(Offer offer)
        {
            offers.Add(offer);
        }

        public void DeleteOffer(int offerId)
        {
            var offer = offers.FirstOrDefault(o => o.Id == offerId);
            if (offer != null)
            {
                offers.Remove(offer);
            }
        }
    }
}
