namespace OrientHGAPI.DTOs.Responses.Rooms
{
    public class GetRoomsGroupPage
    {
        public string GroupHomeRoomTitleTop { get; set; }

        public string GroupHomeRoomTitle { get; set; }

        public List<GetRoomsGroupList> Rooms { get; set; }
    }

    public class GetRoomsGroupList
    {
        public int RoomId { get; set; }
        public string HotelName { get; set; }
        public string RoomName { get; set; }
        public string RoomPhotoHome { get; set; }
        public string RoomUrl { get; set; }

        public string HotelUrl { get; set; }

        public string MaxOccupancy { get; set; }
        public string RoomSize { get; set; }

        public string RoomBed { get; set; }
        public string RoomTypeCategoryName { get; set; }


        public string RoomSummery { get; set; }

        public string RoomView { get; set; }

        public List<GetRoomAmenity> RoomAmenities { get; set; }
    }
}
