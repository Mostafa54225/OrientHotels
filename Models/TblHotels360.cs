using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblHotels360
{
    public int Item360id { get; set; }

    public int? HotelId { get; set; }

    public string Item360Url { get; set; }

    public string Itemdescription { get; set; }

    public string Posturl { get; set; }

    public bool? ItemStatus { get; set; }
}
