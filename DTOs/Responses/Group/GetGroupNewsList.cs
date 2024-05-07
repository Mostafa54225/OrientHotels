using OrientHGAPI.DTOs.Responses.Group.GroupNews;
using OrientHGAPI.DTOs.Responses.News;

namespace OrientHGAPI.DTOs.Responses.Group
{
    public class GetGroupNewsList
    {
        public string GroupHomeNewsTitleTop { get; set; }
        public string GroupHomeNewsTitle { get; set; }
        public List<GetGroupNews> NewsList { get; set; } = [];
    }
}
