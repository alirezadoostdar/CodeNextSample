using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class InvoiceCostTbl
{
    public int SysCode { get; set; }

    public string Title { get; set; } = null!;

    public int Sign { get; set; }

    public double CostPersent { get; set; }

    public virtual ICollection<InvoiceCostDetailTbl> InvoiceCostDetailTbls { get; set; } = new List<InvoiceCostDetailTbl>();
}
