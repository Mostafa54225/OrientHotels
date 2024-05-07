using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblAwardsContent
{
    public int Awardcontentid { get; set; }

    public int? Awardid { get; set; }

    public int? Langid { get; set; }

    public string Awardtitle { get; set; }

    public string AwardDescription { get; set; }

    public virtual TblAward Award { get; set; }
}
