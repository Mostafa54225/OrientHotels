using OrientHGAPI.DTOs.Responses.Hotels;

namespace OrientHGAPI.DTOs.Responses.Group
{
    public class GetGroupHotelListResponse
    {
        public string GroupHomeHotelTitleTop { get; set; }
        public string GroupHomeHotelTitle { get; set; }
        public List<GetGroupHotelList> Hotels { get; set; } = [];
    }
}
