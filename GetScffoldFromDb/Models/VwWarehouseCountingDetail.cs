using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwWarehouseCountingDetail
{
    public int Id { get; set; }

    public int Code { get; set; }

    [Column("Fk_DocSysCodeIn")]
    public int? FkDocSysCodeIn { get; set; }

    [Column("Fk_DocSysCodeOut")]
    public int? FkDocSysCodeOut { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MiladiDate { get; set; }

    public bool IsTemp { get; set; }

    [StringLength(500)]
    public string? Comment { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RegShamsiDate { get; set; } = null!;

    public double Quantity { get; set; }

    public double RemainQty { get; set; }

    public double RealQty { get; set; }

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

    public int GoodSysCode { get; set; }

    public int RowNo { get; set; }

    [StringLength(1000)]
    public string? GoodTitle { get; set; }

    [StringLength(1000)]
    public string? WareHouseName { get; set; }

    [StringLength(1000)]
    public string? SizeName { get; set; }

    [StringLength(1000)]
    public string? ColorName { get; set; }

    public double? TotalFee { get; set; }

    [Column("Fk_ProjectId")]
    public int? FkProjectId { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }
}
