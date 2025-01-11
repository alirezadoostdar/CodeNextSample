using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwCompleteInventory
{
    public int InventorySerial { get; set; }

    public int InventoryNo { get; set; }

    public int UserNo { get; set; }

    public int Sign { get; set; }

    public int Type { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiSysDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    public string? Comment { get; set; }

    public bool IsTemp { get; set; }

    [Column("Fk_InvoiceSerial")]
    public int? FkInvoiceSerial { get; set; }

    [Column("Fk_TransferSerial")]
    public int? FkTransferSerial { get; set; }

    [Column("Fk_DriversSysCode")]
    public int? FkDriversSysCode { get; set; }

    [Column("Fk_DistributorSysCode")]
    public int? FkDistributorSysCode { get; set; }

    [StringLength(1000)]
    public string? Field1 { get; set; }

    [StringLength(1000)]
    public string? Field2 { get; set; }

    [StringLength(1000)]
    public string? Field3 { get; set; }

    [StringLength(1000)]
    public string? Field4 { get; set; }

    [StringLength(1000)]
    public string? Field5 { get; set; }

    [StringLength(100)]
    public string TypeTitle { get; set; } = null!;

    public int? Driver { get; set; }

    public int? Distributor { get; set; }

    [Column("UName")]
    [StringLength(1000)]
    public string Uname { get; set; } = null!;

    public int SysCode { get; set; }

    public int GoodSysCode { get; set; }

    [StringLength(300)]
    public string? GoodsComment { get; set; }

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
    public string? DetailField1 { get; set; }

    [StringLength(1000)]
    public string? DetailField2 { get; set; }

    public int? RowNo { get; set; }

    public double? NetQuantity { get; set; }

    [StringLength(1000)]
    public string? WareHouseName { get; set; }

    [StringLength(1000)]
    public string? ColorName { get; set; }

    [StringLength(1000)]
    public string? SizeName { get; set; }
}
