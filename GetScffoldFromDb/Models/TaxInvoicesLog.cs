using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxInvoices_Log")]
public partial class TaxInvoicesLog
{
    [Key]
    public int SysCode { get; set; }

    public int? Id { get; set; }

    public int InvoiceSerialNo { get; set; }

    [StringLength(22)]
    public string TaxId { get; set; } = null!;

    [Column("Fk_TaxInvoiceTypeId")]
    public byte FkTaxInvoiceTypeId { get; set; }

    [StringLength(10)]
    public string InNo { get; set; } = null!;

    [StringLength(22)]
    public string? IrTaxId { get; set; }

    [Column("Fk_TaxInvoicePatternId")]
    public byte? FkTaxInvoicePatternId { get; set; }

    [Column("Fk_TaxInvoiceIssueId")]
    public byte FkTaxInvoiceIssueId { get; set; }

    [Column("Fk_TaxInvoiceSettlementId")]
    public byte FkTaxInvoiceSettlementId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateDateTime { get; set; }

    [StringLength(128)]
    public string InvoiceUid { get; set; } = null!;

    [StringLength(128)]
    public string? RefrenceId { get; set; }

    [Column("Fk_TaxSettingId")]
    public int FkTaxSettingId { get; set; }

    [Column("Fk_TaxInvoiceStatus")]
    public byte FkTaxInvoiceStatus { get; set; }

    [Column("Fk_UserId")]
    public int FkUserId { get; set; }
}
