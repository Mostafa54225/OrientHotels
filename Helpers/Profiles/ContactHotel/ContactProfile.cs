using AutoMapper;
using OrientHGAPI.DTOs.Responses.ContactUs;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.ContactHotel
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<VwHotel, GetContactHotel>();
        }
    }
}
