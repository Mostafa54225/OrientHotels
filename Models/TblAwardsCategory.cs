﻿using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblAwardsCategory
{
    public int AwardYearCategorId { get; set; }

    public string AwardYearCategoryName { get; set; }

    public int? AwardPosition { get; set; }
}
