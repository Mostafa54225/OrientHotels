using OrientHGAPI.DTOs.Responses.Group.GroupFAQ;

namespace OrientHGAPI.DTOs.Responses.Group
{
    public class GetGroupContactUsResponse
    {
        public MainResponse PageDetails { get; set; }
        public List<GetHotelInfoForContactUs> HotelsContact { get; set; }
    }
}
