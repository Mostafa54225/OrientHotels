using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblGallerySectionsContent
{
    public int GallerySectionContentId { get; set; }

    public int GallerySectionId { get; set; }

    public int LangId { get; set; }

    public string GallerySectionName { get; set; }

    public virtual TblGallerySection GallerySection { get; set; }
}
