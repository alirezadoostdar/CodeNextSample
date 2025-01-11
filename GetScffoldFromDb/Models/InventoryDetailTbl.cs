using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InventoryDetailTbl")]
public partial class InventoryDetailTbl
{
    [Key]
    public int SysCode { get; set; }

    public int GoodSysCode { get; set; }

    [StringLength(300)]
    public string? Comment { get; set; }

    public double? Quantity { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    [StringLength(100)]
    public string? SerialNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DateExpire { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    [Column("FK_InventorySysCode")]
    public int FkInventorySysCode { get; set; }

    [StringLength(1000)]
    public string? Field1 { get; set; }

    [StringLength(1000)]
    public string? Field2 { get; set; }

    public int? RowNo { get; set; }

    public int? InvoiceDetailSysCode { get; set; }

    [ForeignKey("Color")]
    [InverseProperty("InventoryDetailTbls")]
    public virtual GoodColorTbl? ColorNavigation { get; set; }

    [ForeignKey("FkInventorySysCode")]
    [InverseProperty("InventoryDetailTbls")]
    public virtual InventoryTbl FkInventorySysCodeNavigation { get; set; } = null!;

    [ForeignKey("GoodSysCode")]
    [InverseProperty("InventoryDetailTbls")]
    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    [ForeignKey("Size")]
    [InverseProperty("InventoryDetailTbls")]
    public virtual GoodSizeTbl? SizeNavigation { get; set; }

    [ForeignKey("WareHouse")]
    [InverseProperty("InventoryDetailTbls")]
    public virtual WareHouseTbl? WareHouseNavigation { get; set; }
}
