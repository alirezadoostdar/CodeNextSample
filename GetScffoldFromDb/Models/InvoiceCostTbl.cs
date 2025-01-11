using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InvoiceCostTbl")]
public partial class InvoiceCostTbl
{
    [Key]
    public int SysCode { get; set; }

    [StringLength(100)]
    public string Title { get; set; } = null!;

    public int Sign { get; set; }

    public double CostPersent { get; set; }

    [InverseProperty("FkInvoiceCostSysCodeNavigation")]
    public virtual ICollection<InvoiceCostDetailTbl> InvoiceCostDetailTbls { get; set; } = new List<InvoiceCostDetailTbl>();
}
