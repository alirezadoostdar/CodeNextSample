using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class TaxInvoice
{
    [Key]
    public int Id { get; set; }

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
    public byte FkTaxInvoicePatternId { get; set; }

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

    [Column(TypeName = "money")]
    public decimal CashAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal PersonAmount { get; set; }

    [ForeignKey("FkTaxInvoiceIssueId")]
    [InverseProperty("TaxInvoices")]
    public virtual TaxInvoiceIssue FkTaxInvoiceIssue { get; set; } = null!;

    [ForeignKey("FkTaxInvoicePatternId")]
    [InverseProperty("TaxInvoices")]
    public virtual TaxInvoicePattern FkTaxInvoicePattern { get; set; } = null!;

    [ForeignKey("FkTaxInvoiceSettlementId")]
    [InverseProperty("TaxInvoices")]
    public virtual TaxInvoiceSettlement FkTaxInvoiceSettlement { get; set; } = null!;

    [ForeignKey("FkTaxInvoiceStatus")]
    [InverseProperty("TaxInvoices")]
    public virtual TaxInvoiceStatus FkTaxInvoiceStatusNavigation { get; set; } = null!;

    [ForeignKey("FkTaxInvoiceTypeId")]
    [InverseProperty("TaxInvoices")]
    public virtual TaxInvoiceType FkTaxInvoiceType { get; set; } = null!;

    [ForeignKey("FkTaxSettingId")]
    [InverseProperty("TaxInvoices")]
    public virtual TaxSetting FkTaxSetting { get; set; } = null!;

    [ForeignKey("FkUserId")]
    [InverseProperty("TaxInvoices")]
    public virtual User FkUser { get; set; } = null!;

    [InverseProperty("FkTaxInvoice")]
    public virtual ICollection<TaxInvoicesError> TaxInvoicesErrors { get; set; } = new List<TaxInvoicesError>();
}
