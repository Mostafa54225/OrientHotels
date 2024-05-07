﻿using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblGroupHomeIntroActivitiesContent
{
    public int GroupHomeIntroActivitiesContentId { get; set; }

    public int? GroupHomeIntroActivitiesId { get; set; }

    public int? LangId { get; set; }

    public bool? GroupHomeIntoActivitiesStatusLang { get; set; }

    public string GroupHomeIntroActivitiesText { get; set; }

    public string GroupHomeIntroActivitiesQuantity { get; set; }

    public virtual TblGroupHomeIntroActivity GroupHomeIntroActivities { get; set; }
}
