using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblHotelsSpokenLanguage
{
    public int HotelSpokenLanguageId { get; set; }

    public int? HotelId { get; set; }

    public int? SpokenLanguagesId { get; set; }
}
