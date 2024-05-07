﻿using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class VwExtraPage
{
    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageFlag { get; set; }

    public string HotelUrl { get; set; }

    public int PageId { get; set; }

    public int? HotelId { get; set; }

    public int? PagePosistion { get; set; }

    public string PageNameSys { get; set; }

    public string PageBanner { get; set; }

    public string PageUrl { get; set; }

    public int PageContentId { get; set; }

    public int? LangId { get; set; }

    public string PageTitle { get; set; }

    public string PageDetails { get; set; }

    public string PageMetatagTitle { get; set; }

    public string PageMetatagDescription { get; set; }

    public bool? PageStatus { get; set; }
}
