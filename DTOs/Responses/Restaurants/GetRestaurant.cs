namespace OrientHGAPI.DTOs.Responses.Restaurants
{
    public class GetRestaurant
    {
        public string RestaurantPhoto { get; set; }
        public string RestaurantPhotoHome { get; set; }
        public string RestaurantUrl { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantSummery { get; set; }
        public string RestaurantOpenFor { get; set; }
        public string HotelUrl { get; set; }
        public string RestaurantsTypeName { get; set; }
        public string RestaurantsTypeIntro { get; set; }
        public string DressCode { get; set; }
        public string Openinghours { get; set; }
        public string RestaurantCuisine { get; set; }
        public bool? IsMoreDetails { get; set; }
    }
}
