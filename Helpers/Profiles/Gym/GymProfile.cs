using AutoMapper;
using OrientHGAPI.DTOs.Responses.Gyms;
using OrientHGAPI.DTOs.Responses.Hotels;
using OrientHGAPI.Models;

namespace OrientHGAPI.Helpers.Profiles.Gym
{
    public class GymProfile: Profile
    {
        public GymProfile()
        {
            CreateMap<VwGym, GetGym>();
            CreateMap<VwGym, GetGymList>();
            CreateMap<VwGymService, GetGymService>();
            CreateMap<TblGymGallery, GetGymGallery>();
        }
    }
}
