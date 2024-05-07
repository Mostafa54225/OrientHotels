﻿using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class MasterLanguage
{
    public int LangId { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public string BookingLang { get; set; }

    public string BookingCurrency { get; set; }

    public virtual ICollection<TblGroupSlider> TblGroupSliders { get; set; } = new List<TblGroupSlider>();
}
