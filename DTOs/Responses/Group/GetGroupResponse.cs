using OrientHGAPI.DTOs.Responses.Hotels;
using OrientHGAPI.DTOs.Responses.News;
using OrientHGAPI.DTOs.Responses.Rooms;

namespace OrientHGAPI.DTOs.Responses.Group
{
    public class GetGroupResponse
    {
        public string MetatagTitle { get; set; }
        public string MetatagDescription { get; set; }
        public List<GetGroupSlider> GroupSliders { get; set; } = [];
        public GetGroupHomeIntro GroupHomeIntro { get; set; }
        public GetGroupHotelListResponse Hotels { get; set; }
        public GetGroupHomeVideo GroupHomeVideo { get; set; }
        public GetGroupNewsList GroupNews { get; set; }

    }
}
