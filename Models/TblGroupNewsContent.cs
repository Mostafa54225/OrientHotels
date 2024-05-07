using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblGroupNewsContent
{
    public int NewsContentId { get; set; }

    public int? NewsId { get; set; }

    public int? LangId { get; set; }

    public bool? NewsStatusLang { get; set; }

    public string NewsTitle { get; set; }

    public string NewsShortDescription { get; set; }

    public string NewsDetails { get; set; }

    public string NewsDateTime { get; set; }

    public string NewsType { get; set; }

    public virtual TblGroupNews News { get; set; }
}
