using OrientHGAPI.DTOs.Responses.Home;

namespace OrientHGAPI.DTOs.Responses.Hotels
{
    public class GetHotelHeader
    {
        public string HotelPhone { get; set; }
        public string HotelEmail { get; set; }
        public string HotelLogo { get; set; }
        public string HotelLogoColored { get; set; }
        public string ButtonGroupUrl { get; set; }
        public List<LanguageResponse> Languages { get; set; } = [];
    }
}
