using AutoMapper;
using OrientHGAPI.DTOs.Responses.ContactUs;
using OrientHGAPI.DTOs.Responses.Facilities;
using OrientHGAPI.DTOs.Responses.Group;
using OrientHGAPI.DTOs.Responses.Gyms;
using OrientHGAPI.DTOs.Responses.Home;
using OrientHGAPI.DTOs.Responses.Hotels;
using OrientHGAPI.DTOs.Responses.News;
using OrientHGAPI.DTOs.Responses.Rooms;
using OrientHGAPI.Errors;
using OrientHGAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrientHGAPI.DTOs.Responses.Restaurants;
using Microsoft.AspNetCore.Razor.Hosting;

namespace OrientHGAPI.Controllers
{
    public class HotelsController : BaseApiController
    {
        private readonly OrientHgwsdbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public HotelsController(OrientHgwsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("{languageCode}")]
        public async Task<ActionResult<List<GetHotelList>>> GetHotels(string languageCode = "en")
        {

            var hotels = await _context.VwHotels.Where(x=>x.HotelStatus == true && x.LanguageAbbreviation == languageCode).ToListAsync();

            var hotelDtos = _mapper.Map<List<GetHotelList>>(hotels);
            if (hotelDtos != null)
            {
                foreach (var hotel in hotelDtos)
                {
                    hotel.HotelPhoto = _configuration["ImagesLink"] + hotel.HotelPhoto;
                    hotel.HotelLogoColored = _configuration["ImagesLink"] + hotel.HotelLogoColored;
                    hotel.HotelLogo = _configuration["ImagesLink"] + hotel.HotelLogo;
                }
            }

            return Ok(hotelDtos);
        }

        [HttpGet("{languageCode}/{hotelurl}")]
        public async Task<ActionResult<GetHotel>> GetHotel(string hotelurl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelurl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));
            var languages = await _context.MasterLanguages.ToListAsync();
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));



            var sliders = await _context.TblSliders.Where(x => x.LangId == language.LangId && x.SliderStatus == true && x.IsDeleted == false && x.HotelId == hotel.HotelId).OrderBy(x => x.SliderPosition).ToListAsync();
            var slidersDto = _mapper.Map<List<GetSliders>>(sliders);


            var homeContent = await _context.VwHomes.Where(x => x.LanguageAbbreviation == languageCode && x.HotelId == hotel.HotelId).FirstOrDefaultAsync();




            var facilities = await _context.VwFacilities.Where(x => x.LanguageAbbreviation == languageCode && x.HotelUrl == hotelurl && x.FacilityStatus == true && x.IsDeleted == false).ToListAsync();
            var hotelRooms = await _context.VwRooms.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.RoomStatus == true).OrderBy(x => x.RoomPosition).ToListAsync();
            var hotelNews = await _context.VwNews.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.NewsStatus == true).OrderByDescending(x => x.NewsId).ToListAsync();

            var restaurants = await _context.VwRestaurants.Where(x => x.LanguageAbbreviation == languageCode && x.HotelUrl == hotelurl && x.RestaurantStatus == true && x.IsDeleted == false).ToListAsync();



            var hotelDto = _mapper.Map<GetHotel>(hotel);


            hotelDto.HotelPhoto = _configuration["ImagesLink"] + hotelDto.HotelPhoto;
            hotelDto.HotelPhoto2 = _configuration["ImagesLink"] + hotelDto.HotelPhoto2;
            if(homeContent != null)
            {
                hotelDto.SectionWelcomeTitle1 = homeContent.SectionWelcomeTitle1;
                hotelDto.SectionWelcomeTitleText = homeContent.SectionWelcomeTitleText;
                hotelDto.SectionRoomTitleBack = homeContent.SectionRoomTitleBack;
                hotelDto.SectionRoomTitle = homeContent.SectionRoomTitle;
                hotelDto.SectionRoomText = homeContent.SectionRoomText;
                hotelDto.SectionNewsTitle = homeContent.SectionNewsTitle;
                hotelDto.SectionNewsText = homeContent.SectionNewsText;
                hotelDto.SectionActivitiesTitle = homeContent.SectionActivitiesTitle;
                hotelDto.SectionActivitiesText = homeContent.SectionActivitiesText;

            }


            hotelDto.Sliders = slidersDto != null ? _mapper.Map<List<GetSliders>>(slidersDto) : null;
            hotelDto.HotelFacilities = facilities != null ? _mapper.Map<List<GetFacility>>(facilities) : null;
            hotelDto.HotelRooms = hotelRooms != null ? _mapper.Map<List<GetRoomsHotelPage>>(hotelRooms) : null;
            hotelDto.HotelNews = hotelNews != null ? _mapper.Map<List<GetNewsList>>(hotelNews) : null;

            GetRestaurantInHotelPage res = new()
            {
                SectionDiningTitle = homeContent.SectionDiningTitle,
                SectionDiningText = homeContent.SectionDiningText,
                RestaurantList = restaurants != null ? _mapper.Map<List<GetRestaurantListHomePage>>(restaurants) : null
            };

            foreach (var item in res.RestaurantList)
            {
                item.RestaurantPhoto = _configuration["ImagesLink"] + item.RestaurantPhoto;
            }

            hotelDto.Restaurants = res;








            //foreach (var news in hotelDto.HotelNews)
            //{
            //    if(news.NewsDateTime != null && news.NewsDateTime != "")
            //        news.NewsDateTime = DateTime.Parse(news.NewsDateTime.ToString()).ToString("dd MMMM yyyy");
            //}

            if (hotelDto.HotelFacilities != null)
            {
                foreach (var hotelfacilities in hotelDto.HotelFacilities)
                {
                    hotelfacilities.FacilityPhotoHome = _configuration["ImagesLink"] + hotelfacilities.FacilityPhotoHome;
                }
            }

            if (hotelDto.Sliders != null)
            {
                foreach (var hotelsliders in hotelDto.Sliders)
                {
                    hotelsliders.SliderPhoto = _configuration["ImagesLink"] + hotelsliders.SliderPhoto;
                }
            }

            if (hotelDto.HotelRooms != null)
            {
                foreach (var hotelrooms in hotelDto.HotelRooms)
                {
                    hotelrooms.RoomPhotoHome = _configuration["ImagesLink"] + hotelrooms.RoomPhotoHome;
                    hotelrooms.RoomPhoto = _configuration["ImagesLink"] + hotelrooms.RoomPhoto;

                    var roomam = await _context.VwRoomsAmenities.Where(x => x.RoomId == hotelrooms.RoomId && x.LanguageAbbreviation == languageCode && x.RoomAmenitiesStatus == true).ToListAsync();
                    hotelrooms.RoomAmenities = roomam != null ? _mapper.Map<List<GetRoomAmenity>>(roomam) : null;
                    if (hotelrooms.RoomAmenities != null)
                    {
                        foreach (var roomaminities in hotelrooms.RoomAmenities)
                        {
                            roomaminities.RoomAmenitiesPhoto = _configuration["IconsLink"] + roomaminities.RoomAmenitiesPhoto;
                        }
                    }
                }
            }
            if (hotelDto.HotelNews != null)
            {
                foreach (var hotelnews in hotelDto.HotelNews)
                {
                    hotelnews.NewsPhoto = _configuration["ImagesLink"] + hotelnews.NewsPhoto;
                }
            }

            return Ok(hotelDto);

        }



        [HttpGet("HotelLayout/{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetHotelLayout>> GetHotelLayout(string hotelUrl, string languageCode = "en")
        {
            var languages = await _context.MasterLanguages.ToListAsync();

            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));
            var hotelSocials = await _context.TblHotelsSocialMedia.Where(x => x.SocialStatus == true && x.HotelId == hotel.HotelId).OrderBy(x => x.SocialPosition).ToListAsync();

            var groupLayout = await _context.VwGroupLayoutContents.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();


            var groupFooterDto = _mapper.Map<GetGroupFooter>(groupLayout);



            GetHotelLayout model = new()
            {
                HotelHeader = _mapper.Map<GetHotelHeader>(hotel),
                HotlFooter = _mapper.Map<GetHotelFooter>(hotel)
            };
            model.HotelHeader.ButtonGroupUrl = _configuration["ButtonGroupUrl"];
            model.HotelHeader.HotelLogo = _configuration["ImagesLink"] + model.HotelHeader.HotelLogo;
            model.HotelHeader.HotelLogoColored = _configuration["ImagesLink"] + model.HotelHeader.HotelLogoColored;
            model.HotlFooter.GroupLogo = _configuration["ImagesLink"] + groupFooterDto.GroupLogo;
            model.HotlFooter.GroupLogoColored = _configuration["ImagesLink"] + groupFooterDto.GroupLogoColored;
            model.HotlFooter.Copyrights = groupFooterDto.Copyrights;

            foreach (var lang in languages)
            {
                model.HotelHeader.Languages.Add(new LanguageResponse
                {
                    LanguageName = lang.LanguageName,
                    LanguageAbbreviation = lang.LanguageAbbreviation
                });
            }

            foreach (var social in hotelSocials)
            {
                model.HotlFooter.HotelSocials.Add(new GetHotelSocials
                {
                    SocialClass = social.SocialClass,
                    SocialColor = social.SocialColor,
                    SocialName = social.SocialName,
                    SocialUrl = social.SocialUrl
                });
            }

            return Ok(model);
        }

    }
}
