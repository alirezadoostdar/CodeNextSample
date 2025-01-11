using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwGoodCardex
{
    [StringLength(100)]
    public string? SerialNo { get; set; }

    [StringLength(1000)]
    public string? SizeName { get; set; }

    [StringLength(1000)]
    public string? WareHouseName { get; set; }

    [StringLength(1000)]
    public string? ColorName { get; set; }

    [StringLength(1000)]
    public string Title { get; set; } = null!;

    public double? NetQuantity { get; set; }

    public int GoodSyscode { get; set; }

    public bool? Amani { get; set; }

    [Column("FK_DocsysCode")]
    public int? FkDocsysCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    public int? InvoiceSerialNo { get; set; }

    [StringLength(200)]
    public string? Type { get; set; }

    [Column("Fk_YearId")]
    public byte? FkYearId { get; set; }

    [Column("Fk_ProjectID")]
    public int? FkProjectId { get; set; }
}
