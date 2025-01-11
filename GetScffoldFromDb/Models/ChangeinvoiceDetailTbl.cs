using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("ChangeinvoiceDetailTbl")]
public partial class ChangeinvoiceDetailTbl
{
    public int GoodSysCode { get; set; }

    [StringLength(300)]
    public string? Comment { get; set; }

    public double? Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal Fee { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    [Column(TypeName = "money")]
    public decimal? UserPrice { get; set; }

    [StringLength(100)]
    public string? SerialNo { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    [Column("FK_InvoiceSysCode")]
    public int FkInvoiceSysCode { get; set; }

    public double? DiscountPercent { get; set; }

    public int SysCode { get; set; }

    [StringLength(1000)]
    public string? Term { get; set; }

    public int? RowNo { get; set; }

    public int? OnChangeUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OnChangeSysShamsiDate { get; set; }

    public double? DiscountPercent2 { get; set; }

    public double? MaliatArzeshAfzoodeh { get; set; }

    public double? Avarez { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DateExpire { get; set; }
}
