using AutoMapper;
using OrientHGAPI.DTOs.Responses.Offers;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.Offers
{
    public class OffersProfile : Profile
    {
        public OffersProfile()
        {
            CreateMap<VwOffer, GetOffersList>();
            CreateMap<VwOffer, GetOfferDetails>();
        }
    }
}
