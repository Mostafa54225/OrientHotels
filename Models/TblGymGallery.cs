using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblGymGallery
{
    public int FacilitiesFileId { get; set; }

    public int? Gymid { get; set; }

    public string PhotoFile { get; set; }

    public int? PhotoPosition { get; set; }

    public bool? PhotoStatus { get; set; }
}
