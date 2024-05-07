namespace OrientHGAPI.DTOs.Responses.Rooms
{
    public class GetRoomsList
    {
        public MainResponse PageDetails { get; set; }
        public List<GetRoomsHotelPage> RoomsList { get; set; }
    }
}
