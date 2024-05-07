using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrientHGAPI.DTOs;
using OrientHGAPI.Models;
using OrientHGAPI.OPModels;

namespace OrientHGAPI.Controllers
{
    public class PMSController : BaseApiController
    {
        private readonly OrientHgwsdbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        //private readonly IEmailSender _email;

        public PMSController(OrientHgwsdbContext context, OrientHgopedbContext opContext, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet("{hotelUrl?}")]
        public async Task<ActionResult<PMSResponse>> GetPMSCode(string hotelUrl = null)
        {
            PMSResponse model = new();
            if (hotelUrl == null)
            {
                var pmscode = await _context.TblSiteConfigurations.FirstOrDefaultAsync();
                model.PMSCode = pmscode.ChainCode;
            } else
            {
                var hotel = await _context.VwHotels.Where(x => x.HotelStatus == true && x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
                model.PMSCode = hotel.HotelPmscode;
            }

            return Ok(model);

        }
    }
}
