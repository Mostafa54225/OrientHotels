using OrientHGAPI.Models;

namespace OrientHGAPI.DTOs.Responses.Gyms
{
    public class GetGym
    {

        public string FacilityPhoto { get; set; }
        public string FacilityUrl { get; set; }
        public string FacilityBanner { get; set; }
        public string FacilityName { get; set; }
        public string FacilitySummery { get; set; }

        public string MetatagTitle { get; set; }

        public string MetatagDescription { get; set; }

        public string FacilityDetails { get; set; }

        public string OpeningHours { get; set; }

        public string PersonalTrainer { get; set; }

        public string Fees { get; set; }

        public string AgeRequirement { get; set; }

        public List<GetGymGallery> GymGallery { get; set; }
        public List<GetGymService> GymServices { get; set; }
    }
}
