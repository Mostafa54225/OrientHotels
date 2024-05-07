using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class VwGroupLayoutContent
{
    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public int? LangId { get; set; }

    public int GroupLayoutContentId { get; set; }

    public bool? GroupLayoutStatusLang { get; set; }

    public string GroupPhone { get; set; }

    public string GroupAddress { get; set; }

    public int? GroupLayoutId { get; set; }

    public string GroupSummery { get; set; }

    public string GroupCopyrights { get; set; }

    public string GroupAddressSys { get; set; }

    public string GroupMail { get; set; }

    public string GroupSummerySys { get; set; }

    public string GroupPhoneSys { get; set; }

    public string GroupCopyrightsSys { get; set; }

    public string GroupLogo { get; set; }

    public string GroupLogoColored { get; set; }
}
