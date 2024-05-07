using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblMasterRoomAmenitiesCategory
{
    public int RoomAmenitiesCategoryId { get; set; }

    public string RoomAmenitiesCategoryNameSys { get; set; }

    public virtual ICollection<TblMasterRoomAmenitiesCategoriesContent> TblMasterRoomAmenitiesCategoriesContents { get; set; } = new List<TblMasterRoomAmenitiesCategoriesContent>();
}
