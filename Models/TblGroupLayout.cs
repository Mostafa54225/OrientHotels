using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblGroupLayout
{
    public int GroupLayoutId { get; set; }

    public string GroupAddress { get; set; }

    public string GroupMail { get; set; }

    public string GroupPhone { get; set; }

    public string GroupSummery { get; set; }

    public string GroupLogo { get; set; }

    public string GroupCopyrights { get; set; }

    public string GroupLogoColored { get; set; }

    public virtual ICollection<TblGroupLayoutContent> TblGroupLayoutContents { get; set; } = new List<TblGroupLayoutContent>();
}
