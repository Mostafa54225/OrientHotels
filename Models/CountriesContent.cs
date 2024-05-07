using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class CountriesContent
{
    public int CountryContentId { get; set; }

    public int? CountryId { get; set; }

    public int? LangId { get; set; }

    public string CountryName { get; set; }
}
