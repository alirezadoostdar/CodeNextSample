using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("ChangeInventoryTBL")]
public partial class ChangeInventoryTbl
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

    [Column("OnChangeUserID")]
    public int? OnChangeUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OnChangeSysShamsiDate { get; set; }
}
