using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GoodSizeTbl")]
public partial class GoodSizeTbl
{
    [StringLength(1000)]
    public string SizeName { get; set; } = null!;

    public int GoodSysCode { get; set; }

    [Key]
    public int SysCode { get; set; }

    [ForeignKey("GoodSysCode")]
    [InverseProperty("GoodSizeTbls")]
    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    [InverseProperty("SizeNavigation")]
    public virtual ICollection<InventoryDetailTbl> InventoryDetailTbls { get; set; } = new List<InventoryDetailTbl>();

    [InverseProperty("SizeNavigation")]
    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTbls { get; set; } = new List<InvoiceDetailTbl>();

    [InverseProperty("SizeNavigation")]
    public virtual ICollection<WarehouseCountingDetail> WarehouseCountingDetails { get; set; } = new List<WarehouseCountingDetail>();
}
