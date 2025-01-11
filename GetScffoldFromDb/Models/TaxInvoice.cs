using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class TaxInvoice
{
    public int Id { get; set; }

    public int InvoiceSerialNo { get; set; }

    public string TaxId { get; set; } = null!;

    public byte FkTaxInvoiceTypeId { get; set; }

    public string InNo { get; set; } = null!;

    public string? IrTaxId { get; set; }

    public byte FkTaxInvoicePatternId { get; set; }

    public byte FkTaxInvoiceIssueId { get; set; }

    public byte FkTaxInvoiceSettlementId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public DateTime UpdateDateTime { get; set; }

    public string InvoiceUid { get; set; } = null!;

    public string? RefrenceId { get; set; }

    public int FkTaxSettingId { get; set; }

    public byte FkTaxInvoiceStatus { get; set; }

    public int FkUserId { get; set; }

    public decimal CashAmount { get; set; }

    public decimal PersonAmount { get; set; }

    public virtual TaxInvoiceIssue FkTaxInvoiceIssue { get; set; } = null!;

    public virtual TaxInvoicePattern FkTaxInvoicePattern { get; set; } = null!;

    public virtual TaxInvoiceSettlement FkTaxInvoiceSettlement { get; set; } = null!;

    public virtual TaxInvoiceStatus FkTaxInvoiceStatusNavigation { get; set; } = null!;

    public virtual TaxInvoiceType FkTaxInvoiceType { get; set; } = null!;

    public virtual TaxSetting FkTaxSetting { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;

    public virtual ICollection<TaxInvoicesError> TaxInvoicesErrors { get; set; } = new List<TaxInvoicesError>();
}
