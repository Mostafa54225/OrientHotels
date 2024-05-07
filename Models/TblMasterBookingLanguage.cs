using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblMasterBookingLanguage
{
    public string BookingLangId { get; set; }

    public string BookingLangName { get; set; }

    public int? BookingLangPosition { get; set; }
}
