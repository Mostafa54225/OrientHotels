﻿using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class VwMasterHotelFacilitiesItem
{
    public int HotelFacilitiesId { get; set; }

    public string HotelFacilitiesNameSys { get; set; }

    public string HotelFacilitiesIcon { get; set; }

    public int? HotelFacilitiesPoisition { get; set; }

    public bool? HotelFacilitiesStatus { get; set; }

    public int HotelFacilitiesContentId { get; set; }

    public int? LangId { get; set; }

    public string HotelFacilitiesName { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public string BookingLang { get; set; }

    public string BookingCurrency { get; set; }

    public string HotelFacilitiesItemNameSys { get; set; }

    public int HotelFacilitiesItemId { get; set; }

    public int? HotelFacilitiesItemPosition { get; set; }

    public bool? HotelFacilitiesItemStatus { get; set; }

    public int HotelFacilitiesItemContentId { get; set; }

    public string HotelFacilitiesItemName { get; set; }

    public string HotelFacilitiesItemExtraText { get; set; }
}
