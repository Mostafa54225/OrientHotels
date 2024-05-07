using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class RoomRoomAmenity
{
    public int? RoomAmenitiesId { get; set; }

    public int? RoomId { get; set; }

    public int RoomRoomAmenitiesId { get; set; }

    public virtual Room Room { get; set; }
}
