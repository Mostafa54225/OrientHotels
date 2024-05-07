﻿using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblHotelPartner
{
    public int HotelPartnerId { get; set; }

    public string HotelPartnerPhoto { get; set; }

    public bool? HotelPartnerStatus { get; set; }

    public int? HotelPartnerPosition { get; set; }

    public int? HotelId { get; set; }

    public virtual Hotel Hotel { get; set; }
}
