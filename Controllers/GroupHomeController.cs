using AutoMapper;
using OrientHGAPI.DTOs;
using OrientHGAPI.DTOs.Responses.ContactUs;
using OrientHGAPI.DTOs.Responses.Group;
using OrientHGAPI.DTOs.Responses.Group.GroupFAQ;
using OrientHGAPI.DTOs.Responses.Group.GroupNews;
using OrientHGAPI.DTOs.Responses.Home;
using OrientHGAPI.DTOs.Responses.Hotels;
using OrientHGAPI.Errors;
using OrientHGAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrientHGAPI.DTOs.Responses.Rooms;

namespace OrientHGAPI.Controllers
{
    public class GroupHomeController : BaseApiController
    {
        private readonly OrientHgwsdbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public GroupHomeController(OrientHgwsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("{languageCode}")]
        public async Task<ActionResult<GetGroupResponse>> GetGroupHome(string languageCode = "en")
        {
            var languages = await _context.MasterLanguages.ToListAsync();

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var gropPages = await _context.VwGroupPages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            var groupHome = await _context.VwGroupHomes.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            var groupHomeDto = _mapper.Map<GetGroupHome>(groupHome);



            var groupSliders = await _context.TblGroupSliders.Where(x => x.SliderStatus == true && x.IsDeleted == false && x.LangId == language.LangId).ToListAsync();
            var groupSlidersDto = _mapper.Map<List<GetGroupSlider>>(groupSliders);

            var groupHomeIntroActivities = await _context.VwGroupHomeIntroActivities.Where(x => x.LanguageAbbreviation == languageCode && x.GroupHomeActivityStatus == true).OrderBy(x => x.GroupHomeActivityPosition).ToListAsync();
            var groupHomeIntroActivitiesDto = _mapper.Map<List<GetGroupHomeIntroActivities>>(groupHomeIntroActivities);



            var hotels = await _context.VwHotels.Where(x => x.LanguageAbbreviation == languageCode && x.HotelStatus == true).ToListAsync();


            var hotelsDto = _mapper.Map<List<GetGroupHotelList>>(hotels);
            GetGroupHotelListResponse hotelListResponse = new()
            {
                GroupHomeHotelTitle = groupHomeDto.GroupHomeHotelTitle,
                GroupHomeHotelTitleTop = groupHomeDto.GroupHomeHotelTitleTop,
                Hotels = hotelsDto
            };

            foreach (var item in hotelListResponse.Hotels)
            {
                item.HotelLogo = _configuration["ImagesLink"] + item.HotelLogo;
                item.HotelLogoColored = _configuration["ImagesLink"] + item.HotelLogoColored;
                item.HotelPhotoGroup = _configuration["ImagesLink"] + item.HotelPhotoGroup;
            }





            var groupNews = await _context.VwGroupNews.Where(x => x.LanguageAbbreviation == languageCode && x.NewsStatus == true).OrderByDescending(x => x.NewsId).ToListAsync();
            var groupNewsDto = _mapper.Map<List<GetGroupNews>>(groupNews);

            if (groupNewsDto != null)
            {
                foreach (var news in groupNewsDto)
                {
                    news.NewsPhoto = _configuration["ImagesLink"] + news.NewsPhoto;
                    //news.NewsDateTime = DateTime.Parse(news.NewsDateTime.ToString()).ToString("dd MMMM yyyy");

                }
            }

            if (groupSlidersDto != null)
            {
                foreach (var slider in groupSlidersDto)
                {
                    slider.SliderPhoto = _configuration["ImagesLink"] + slider.SliderPhoto;
                }
            }



            GetGroupHomeIntro homeIntro = new()
            {
                GroupHomeIntroTitleTop = groupHomeDto.GroupHomeIntroTitleTop,
                GroupHomeIntroTitle = groupHomeDto.GroupHomeIntroTitle,
                GroupHomeIntroText = groupHomeDto.GroupHomeIntroText,
                GroupHomePhoto1 = _configuration["ImagesLink"] + groupHomeDto.GroupHomePhoto1,
                GroupHomePhoto2 = _configuration["ImagesLink"] + groupHomeDto.GroupHomePhoto2,
            };

            GetGroupHomeVideo groupHomeVideo = new()
            {
                GroupHomeVideoSectionTitleTop = groupHomeDto.GroupHomeVideoSectionTitleTop,
                GroupHomeVideoSectionTitle = groupHomeDto.GroupHomeVideoSectionTitle,
                GroupHomeVideoSectionBanner = _configuration["ImagesLink"] + groupHomeDto.GroupHomeVideoSectionBanner,
                GroupHomeVideoSectionBannerMobile = _configuration["ImagesLink"] + groupHomeDto.GroupHomeVideoSectionBannerMobile,
                GroupHomeVideoSectionBannerTablet = _configuration["ImagesLink"] + groupHomeDto.GroupHomeVideoSectionBannerTablet,
                GroupHomeVideoUrl = groupHomeDto.GroupHomeVideoUrl
            };




            GetGroupNewsList groupNewsList = new()
            {
                GroupHomeNewsTitle = groupHomeDto.GroupHomeNewsTitle,
                GroupHomeNewsTitleTop = groupHomeDto.GroupHomeNewsTitleTop,
                NewsList = groupNewsDto
            };


            GetGroupResponse model = new()
            {
                MetatagTitle = gropPages.MetatagTitle,
                MetatagDescription = gropPages.MetatagDescription,
                GroupSliders = groupSlidersDto,
                GroupHomeIntro = homeIntro,
                Hotels = hotelListResponse,
                GroupHomeVideo = groupHomeVideo,
                GroupNews = groupNewsList
            };

            return Ok(model);
        }


        [HttpGet("GroupFAQs/{languageCode}")]
        public async Task<ActionResult<GetGroupFAQResponse>> GetGroupFAQs(string languageCode = "en")
        {
            var pageContent = await _context.VwGroupPages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();

            MainResponse pageDetails = new()
            {
                PageTitle = pageContent.GroupFaqTitle,
                PageText = pageContent.GroupFaq,
                PageBannerPC = _configuration["ImagesLink"] + pageContent.GroupFaqBanner,
                PageBannerTablet = _configuration["ImagesLink"] + pageContent.GroupFaqBannerTablet,
                PageBannerMobile = _configuration["ImagesLink"] + pageContent.GroupFaqBannerMobile,
                PageMetatagTitle = pageContent.GroupFaqMetatagTitle,
                PageMetatagDescription = pageContent.GroupFaqMetatagDescription
            };

            var groupFaqs = await _context.VwGroupFaqs.Where(x => x.LanguageAbbreviation == languageCode).ToListAsync();
            var groupFaqsDto = _mapper.Map<List<GetGroupFAQList>>(groupFaqs);
            GetGroupFAQResponse model = new()
            {
                PageDetails = pageDetails,
                GroupFAQs = groupFaqsDto
            };
            return Ok(model);
        }




        [HttpGet("GroupContactUs/{languageCode}")]
        public async Task<ActionResult<GetGroupContactUsResponse>> GetGroupContactUs(string languageCode = "en")
        {
            var pageContent = await _context.VwGroupPages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            MainResponse pageDetails = new()
            {
                PageTitle = pageContent.GroupContactUsTitle,
                PageText = pageContent.GroupContactUs,
                PageBannerPC = _configuration["ImagesLink"] + pageContent.GroupContactUsBanner,
                PageBannerTablet = _configuration["ImagesLink"] + pageContent.GroupContactUsBannerTablet,
                PageBannerMobile = _configuration["ImagesLink"] + pageContent.GroupContactUsBannerMobile,
                PageMetatagTitle = pageContent.GroupContactUsMetatagTitle,
                PageMetatagDescription = pageContent.GroupContactUsMetatagDescription
            };

            var hotel = await _context.VwHotels.Where(x => x.HotelStatus == true && x.LanguageAbbreviation == languageCode).ToListAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var contactsDto = _mapper.Map<List<GetHotelInfoForContactUs>>(hotel);


            GetGroupContactUsResponse model = new()
            {
                PageDetails = pageDetails,
                HotelsContact = contactsDto
            };
            return Ok(model);
        }



        [HttpGet("GroupLayout/{languageCode}")]
        public async Task<ActionResult<GetGroupLayout>> GetGroupLayout(string languageCode = "en")
        {
            var languages = await _context.MasterLanguages.ToListAsync();
            var groupSocials = await _context.TblGroupSocials.Where(x => x.SocialStatus == true).OrderBy(x => x.SocialPosition).ToListAsync();

            var groupLayout = await _context.VwGroupLayoutContents.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            var groupHeaderDto = _mapper.Map<GetGroupHeader>(groupLayout);
            var groupFooterDto = _mapper.Map<GetGroupFooter>(groupLayout);
            groupFooterDto.GroupLogo = _configuration["ImagesLink"] + groupFooterDto.GroupLogo;
            groupHeaderDto.GroupLogo = _configuration["ImagesLink"] + groupHeaderDto.GroupLogo;
            groupFooterDto.GroupLogoColored = _configuration["ImagesLink"] + groupFooterDto.GroupLogoColored;
            groupHeaderDto.GroupLogoColored = _configuration["ImagesLink"] + groupHeaderDto.GroupLogoColored;


            foreach (var lang in languages)
            {
                groupHeaderDto.Languages.Add(new LanguageResponse
                {
                    LanguageName = lang.LanguageName,
                    LanguageAbbreviation = lang.LanguageAbbreviation
                });
            }

            foreach (var social in groupSocials)
            {
                groupFooterDto.GroupSocials.Add(new GetGroupSocials
                {
                    SocialClass = social.SocialClass,
                    SocialColor = social.SocialColor,
                    SocialName = social.SocialName,
                    SocialUrl = social.SocialUrl
                });
            }
            GetGroupLayout model = new()
            {
                GroupHeader = groupHeaderDto,
                GroupFooter = groupFooterDto
            };
            return Ok(model);
        }
    }
}
