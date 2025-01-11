using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwinvoiceDetailCompleteForAndroid
{
    public int GoodSysCode { get; set; }

    public double? Fee { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    [Column("FK_DocsysCode")]
    public int? FkDocsysCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    public int InvoiceSerialNo { get; set; }

    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    public double? Quantity { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    public string? VisitorName { get; set; }

    [StringLength(200)]
    public string? InvoiceType { get; set; }

    [StringLength(300)]
    public string? InvoiceComment { get; set; }

    [StringLength(1000)]
    public string GoodName { get; set; } = null!;

    [StringLength(1000)]
    public string? SizeName { get; set; }

    [StringLength(1000)]
    public string? ColorName { get; set; }

    [StringLength(1000)]
    public string? WareHouseName { get; set; }

    public int? VisitorSyscode { get; set; }

    public int Sign { get; set; }

    public int Type { get; set; }
}
