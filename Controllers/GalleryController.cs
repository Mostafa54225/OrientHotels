using AutoMapper;
using OrientHGAPI.DTOs;
using OrientHGAPI.Errors;
using OrientHGAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrientHGAPI.DTOs.Responses.Gallery;

namespace OrientHGAPI.Controllers
{
    public class GalleryController : BaseApiController
    {
        private readonly OrientHgwsdbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public GalleryController(OrientHgwsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetGalleryResponse>> GetHotelGallery(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var galleryPhotos = await _context.VwGalleryPhotos.Where(x => x.LanguageAbbreviation == languageCode && x.PhotoStatus == true && x.GalleryStatus == true).OrderBy(x => x.GalleryPosition).ToListAsync();
            var galleryPhotosDto = _mapper.Map<List<GetGalleryPhotos>>(galleryPhotos);


            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelGalleryTitle,
                PageBannerPC = _configuration["ImagesLink"] + hotel.HotelGalleryBanner,
                PageBannerMobile = _configuration["ImagesLink"] + hotel.HotelGalleryBannerMobile,
                PageBannerTablet = _configuration["ImagesLink"] + hotel.HotelGalleryBannerTablet,
                PageText = hotel.HotelGallery,
                PageMetatagTitle = hotel.HotelGalleryMetatagTitle,
                PageMetatagDescription = hotel.HotelGalleryMetatagDescription
            };

            foreach (var gallery in galleryPhotosDto)
            {
                gallery.PhotoFile = _configuration["ImagesLink"] + gallery.PhotoFile;
            }



            GetGalleryResponse model = new()
            {
                PageDetails = pagedetails,
                Galleries = galleryPhotosDto
            };


            return Ok(model);
        }


    }
}
