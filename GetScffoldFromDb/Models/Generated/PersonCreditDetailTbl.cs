using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class PersonCreditDetailTbl
{
    public int SysCode { get; set; }

    public int? FkAccountSysCode { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public decimal? Price { get; set; }

    public DateTime? SysDate { get; set; }

    public string? ShamsiSysDate { get; set; }

    public decimal? SndPrice { get; set; }

    public virtual CodeMngdwntbl? FkAccountSysCodeNavigation { get; set; }

    public virtual User? User { get; set; }
}
