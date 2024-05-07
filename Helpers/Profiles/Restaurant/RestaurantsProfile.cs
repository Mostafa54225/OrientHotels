using AutoMapper;
using OrientHGAPI.DTOs;
using OrientHGAPI.DTOs.Responses.Hotels;
using OrientHGAPI.DTOs.Responses.Restaurants;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.Restaurant
{
    public class RestaurantsProfile : Profile
    {
        public RestaurantsProfile()
        {
            CreateMap<VwRestaurant, GetRestaurant>();
            CreateMap<VwRestaurant, GetRestaurantDetails>();
            CreateMap<VwRestaurant, GetRestaurantListHomePage>();
            CreateMap<VwRestaurantsGallery, GetRestaurantGallery>();
        }
    }
}
