using OrientHGAPI.DTOs.Responses.Restaurants;

namespace OrientHGAPI.DTOs.Responses.Hotels
{
    public class GetRestaurantInHotelPage
    {
        public string SectionDiningTitle { get; set; }
        public string SectionDiningText { get; set; }
        public List<GetRestaurantListHomePage> RestaurantList { get; set; } = [];


    }
}
