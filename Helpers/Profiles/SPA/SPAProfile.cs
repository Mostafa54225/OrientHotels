using AutoMapper;
using OrientHGAPI.DTOs.Responses.SPA;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.SPA
{
    public class SPAProfile : Profile
    {
        public SPAProfile()
        {
            CreateMap<VwSpa, GetSPA>();
            CreateMap<VwSpa, GetSPADetails>();
            CreateMap<VwSpaService, GetSPAService>();
            CreateMap<TblSpaGallery, GetSPAGallery>();
        }
    }
}
