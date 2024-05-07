using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrientHGAPI.DTOs;
using OrientHGAPI.DTOs.Responses.Offers;
using OrientHGAPI.Errors;
using OrientHGAPI.Models;

namespace OrientHGAPI.Controllers
{
    public class OffersController : BaseApiController
    {
        private readonly OrientHgwsdbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public OffersController(OrientHgwsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetOffersResponsePage>> GetHotelOffers(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var offers = await _context.VwOffers.Where(x => x.LanguageAbbreviation == languageCode && x.HotelUrl == hotelUrl && x.OfferStatus == true && x.IsDeleted == false).ToListAsync();

            var offersDto = _mapper.Map<List<GetOffersList>>(offers);


            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelOffersTitle,
                PageBannerPC = _configuration["ImagesLink"] + hotel.HotelOfferBanner,
                PageBannerMobile = _configuration["ImagesLink"] + hotel.HotelOfferBannerMobile,
                PageBannerTablet = _configuration["ImagesLink"] + hotel.HotelOfferBannerTablet,
                PageText = hotel.HotelOffers,
                PageMetatagTitle = hotel.HotelOffersMetatagTitle,
                PageMetatagDescription = hotel.HotelOffersMetatagDescription
            };

            foreach (var offer in offersDto)
            {
                offer.OfferPhoto = _configuration["ImagesLink"] + offer.OfferPhoto;
                offer.DateEnd = DateTime.Parse(offer.DateEnd.ToString()).ToString("dd MMMM yyyy");
                offer.DateStart = DateTime.Parse(offer.DateStart.ToString()).ToString("dd MMMM yyyy");

            }

            GetOffersResponsePage model = new()
            {
                PageDetails = pagedetails,
                OffersList = offersDto
            };
            return Ok(model);
        }



        [HttpGet("{languageCode}/{hotelUrl}/{offerUrl}")]
        public async Task<ActionResult<GetOfferDetails>> GetHotelOfferDetails(string hotelUrl, string offerUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var offer = await _context.VwOffers.Where(x => x.LanguageAbbreviation == languageCode && x.HotelUrl == hotelUrl && x.OfferUrl == offerUrl && x.OfferStatus == true && x.IsDeleted == false).FirstOrDefaultAsync();

            var offerDto = _mapper.Map<GetOfferDetails>(offer);
            offerDto.OfferPhoto = _configuration["ImagesLink"] + offerDto.OfferPhoto;
            offerDto.OfferBanner = _configuration["ImagesLink"] + offerDto.OfferBanner;
            offerDto.DateStart = DateTime.Parse(offerDto.DateStart.ToString()).ToString("dd MMMM yyyy");
            offerDto.DateEnd = DateTime.Parse(offerDto.DateEnd.ToString()).ToString("dd MMMM yyyy");




            return Ok(offerDto);
        }


       
    }
}
