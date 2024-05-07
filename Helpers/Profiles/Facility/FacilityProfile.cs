using AutoMapper;
using OrientHGAPI.DTOs.Responses.Facilities;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.Facility
{
    public class FacilityProfile : Profile
    {
        public FacilityProfile()
        {
            CreateMap<VwFacility, GetFacility>();
            CreateMap<FacilitiesGallery, GetFacilityGallery>();
            CreateMap<VwFacility, GetFacilityDetails>();
        }
    }
}
