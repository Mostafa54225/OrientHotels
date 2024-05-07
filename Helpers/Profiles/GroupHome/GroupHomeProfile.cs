using AutoMapper;
using OrientHGAPI.DTOs.Responses.Group;
using OrientHGAPI.DTOs.Responses.Group.GroupFAQ;
using OrientHGAPI.DTOs.Responses.Group.GroupNews;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.GroupHome
{
    public class GroupHomeProfile : Profile
    {
        public GroupHomeProfile()
        {
            CreateMap<VwGroupHome, GetGroupHome>();
            CreateMap<VwGroupHomeIntroActivity, GetGroupHomeIntroActivities>();

            CreateMap<TblGroupSlider, GetGroupSlider>();
            CreateMap<VwGroupHome, GetGroupContactUs>();
            CreateMap<VwGroupLayoutContent, GetGroupHeader>();
            CreateMap<VwGroupLayoutContent, GetGroupFooter>()
                .ForMember(dest => dest.Copyrights, opt => opt.MapFrom(src => src.GroupCopyrights));



            CreateMap<TblGroupSocial, GetGroupSocials>();
            CreateMap<VwHotel, GetGroupHotelList>();

            CreateMap<VwGroupFaq, GetGroupFAQList>();

            CreateMap<VwGroupNews, GetGroupNews>();

            CreateMap<VwHotel, GetHotelInfoForContactUs>();
        }
    }
}
