using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwWarehouseCounting
{
    public int Id { get; set; }

    public double? DeficitAmount { get; set; }

    public double? AdditionalAmount { get; set; }

    public double? TotalAmount { get; set; }

    public double? DeficitQty { get; set; }

    public double? AdditionalQty { get; set; }

    public double? TotalQty { get; set; }

    public int? RowsQty { get; set; }

    public int Code { get; set; }

    [Column("Fk_DocSysCodeIn")]
    public int? FkDocSysCodeIn { get; set; }

    [Column("Fk_DocSysCodeOut")]
    public int? FkDocSysCodeOut { get; set; }

    [StringLength(500)]
    public string? Comment { get; set; }

    public bool IsTemp { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MiladiDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RegShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegMiladiDate { get; set; }

    public int RegUserId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EditShamsiDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EditMiladiDate { get; set; }

    public int? EditUserId { get; set; }

    public int? LastTransferSerial { get; set; }

    public int? LastInvoiceSerial { get; set; }

    public int? LastInventorySerial { get; set; }

    [Column("RegUName")]
    [StringLength(1000)]
    public string? RegUname { get; set; }

    [Column("EditUName")]
    [StringLength(1000)]
    public string? EditUname { get; set; }
}
