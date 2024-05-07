using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class MasterRestaurantsCategory
{
    public int RestaurantCategoryId { get; set; }

    public string RestaurantsCategoryNameSys { get; set; }

    public virtual ICollection<MasterRestaurantsCategoriesContent> MasterRestaurantsCategoriesContents { get; set; } = new List<MasterRestaurantsCategoriesContent>();
}
