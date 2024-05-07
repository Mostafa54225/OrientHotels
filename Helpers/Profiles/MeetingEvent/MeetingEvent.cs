using AutoMapper;
using OrientHGAPI.DTOs.Responses.MeetingEvents;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.MeetingEvent
{
    public class MeetingEvent: Profile
    {
        public MeetingEvent()
        {
            CreateMap<VwMeetingsEvent, GetMeetingEvent>()
                .ForMember(dest => dest.HotelName, opt => opt.MapFrom(src => src.HotelNameSys));
            CreateMap<VwMeetingsEvent, GetMeetingEventsDetails>()
                .ForMember(dest => dest.HotelName, opt => opt.MapFrom(src => src.HotelNameSys));
            CreateMap<VwMeetingsEventsGallery, GetMeetingEventsGallery>();
            CreateMap<VwHotel, GetMeetingEventWithPageDetails>();
        }
    }
}
