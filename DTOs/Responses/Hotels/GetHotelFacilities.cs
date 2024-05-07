
using OrientHGAPI.DTOs.Responses.Facilities;

namespace OrientHGAPI.DTOs.Responses.Hotels
{
    public class GetHotelFacilities
    {
        public string SectionActivitiesTitle { get; set; }
        public string SectionActivitiesText { get; set; }

        public List<GetFacility> Facilities { get; set; }
    }
}
