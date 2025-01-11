using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("WarehouseCountingDetail")]
public partial class WarehouseCountingDetail
{
    [Key]
    public int Id { get; set; }

    public int RowNo { get; set; }

    [Column("Fk_WarehouseCountingId")]
    public int FkWarehouseCountingId { get; set; }

    public int GoodSysCode { get; set; }

    public double RealQty { get; set; }

    public double RemainQty { get; set; }

    public double Quantity { get; set; }

    public double RemainInvQty { get; set; }

    public double InvQuantity { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    public double UnitRate { get; set; }

    public int? Warehouse { get; set; }

    [StringLength(100)]
    public string? SerialNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DateExpire { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    [Column(TypeName = "money")]
    public decimal Fee { get; set; }

    [StringLength(300)]
    public string? Comment { get; set; }

    [ForeignKey("Color")]
    [InverseProperty("WarehouseCountingDetails")]
    public virtual GoodColorTbl? ColorNavigation { get; set; }

    [ForeignKey("FkWarehouseCountingId")]
    [InverseProperty("WarehouseCountingDetails")]
    public virtual WarehouseCounting FkWarehouseCounting { get; set; } = null!;

    [ForeignKey("GoodSysCode")]
    [InverseProperty("WarehouseCountingDetails")]
    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    [ForeignKey("Size")]
    [InverseProperty("WarehouseCountingDetails")]
    public virtual GoodSizeTbl? SizeNavigation { get; set; }

    [ForeignKey("Warehouse")]
    [InverseProperty("WarehouseCountingDetails")]
    public virtual WareHouseTbl? WarehouseNavigation { get; set; }
}
