using AutoMapper;
using OrientHGAPI.DTOs.Responses.News;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.News
{
    public class NewsProfile: Profile
    {
        public NewsProfile()
        {
            CreateMap<VwNews, GetNewsDetails>();
            CreateMap<VwNews, GetNewsList>();
            CreateMap<TblNewsGallery,GetNewsGallery>();
        }
    }
}
