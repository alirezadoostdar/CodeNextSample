using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class CheckOuttbl
{
    public long SerialNo { get; set; }

    public string Comment { get; set; } = null!;

    public int FkBankAccount { get; set; }

    public string? CheckDate { get; set; }

    public int FkDocSysCode { get; set; }

    public int? Belongto { get; set; }

    public DateTime? CheckMiladiDate { get; set; }

    public virtual CodeMngdwntbl? BelongtoNavigation { get; set; }

    public virtual BanksTbl FkBankAccountNavigation { get; set; } = null!;

    public virtual DocDetailTbl FkDocSysCodeNavigation { get; set; } = null!;
}
