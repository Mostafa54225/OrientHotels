using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblGroupLayoutContent
{
    public int GroupLayoutContentId { get; set; }

    public int? GroupLayoutId { get; set; }

    public int? LangId { get; set; }

    public bool? GroupLayoutStatusLang { get; set; }

    public string GroupAddress { get; set; }

    public string GroupPhone { get; set; }

    public string GroupSummery { get; set; }

    public string GroupCopyrights { get; set; }

    public virtual TblGroupLayout GroupLayout { get; set; }
}
