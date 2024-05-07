﻿using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblExtraPagesContent
{
    public int PageContentId { get; set; }

    public int? PageId { get; set; }

    public int? LangId { get; set; }

    public string PageTitle { get; set; }

    public string PageDetails { get; set; }

    public string PageMetatagTitle { get; set; }

    public string PageMetatagDescription { get; set; }

    public virtual TblExtraPage Page { get; set; }
}
