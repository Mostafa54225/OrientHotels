using AutoMapper;
using OrientHGAPI.DTOs.Responses.Gallery;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.Gallery
{
    public class GalleryProfile : Profile
    {
        public GalleryProfile()
        {
            CreateMap<VwGallery, GetGallerySections>();
            CreateMap<VwGalleryPhoto, GetGalleryPhotos>()
                .ForMember(dest => dest.GallerySectionName, opt => opt.MapFrom(src => src.GallerySectionNameSys));
        }
    }
}
