using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GoodColorTbl")]
public partial class GoodColorTbl
{
    [StringLength(1000)]
    public string ColorName { get; set; } = null!;

    public int GoodSysCode { get; set; }

    [Key]
    public int SysCode { get; set; }

    [ForeignKey("GoodSysCode")]
    [InverseProperty("GoodColorTbls")]
    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    [InverseProperty("ColorNavigation")]
    public virtual ICollection<InventoryDetailTbl> InventoryDetailTbls { get; set; } = new List<InventoryDetailTbl>();

    [InverseProperty("ColorNavigation")]
    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTbls { get; set; } = new List<InvoiceDetailTbl>();

    [InverseProperty("ColorNavigation")]
    public virtual ICollection<WarehouseCountingDetail> WarehouseCountingDetails { get; set; } = new List<WarehouseCountingDetail>();
}
