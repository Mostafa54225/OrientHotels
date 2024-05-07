using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblService
{
    public int ServicesId { get; set; }

    public string ServiceNameSys { get; set; }

    public string ServicesPhotos { get; set; }

    public bool? ServicesStatus { get; set; }

    public virtual ICollection<TblServicesContent> TblServicesContents { get; set; } = new List<TblServicesContent>();
}
