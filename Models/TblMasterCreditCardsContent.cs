using System;
using System.Collections.Generic;

namespace OrientHGAPI.Models;

public partial class TblMasterCreditCardsContent
{
    public int CreditCardContentId { get; set; }

    public int? CreditCardId { get; set; }

    public int? LangId { get; set; }

    public string CreditCardName { get; set; }

    public virtual TblMasterCreditCard CreditCard { get; set; }
}
