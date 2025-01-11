using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class PricingTbl
{
    public int Id { get; set; }

    public int PricingNo { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime MiladiDate { get; set; }

    public string? SysShamsiDate { get; set; }

    public DateTime? SysMiladiDate { get; set; }

    public int UserNo { get; set; }

    public int? AccountCode { get; set; }

    public string Comment { get; set; } = null!;

    public string Field1 { get; set; } = null!;

    public string Field2 { get; set; } = null!;

    public string Field3 { get; set; } = null!;

    public int TasviehDay { get; set; }

    public virtual CodeMngdwntbl? AccountCodeNavigation { get; set; }

    public virtual ICollection<PricingDetailTbl> PricingDetailTbls { get; set; } = new List<PricingDetailTbl>();

    public virtual User UserNoNavigation { get; set; } = null!;
}
