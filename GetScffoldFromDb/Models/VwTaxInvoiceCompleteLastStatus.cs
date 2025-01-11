using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwTaxInvoiceCompleteLastStatus
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

    public string? PatternTitle { get; set; }

    public string? SettlementTitle { get; set; }

    public string? TypeTitle { get; set; }

    public string? StatusTitle { get; set; }

    public string? TitleFilaName { get; set; }

    public string? SellerMeliCode { get; set; }

    public string? SellerEconomicCode { get; set; }

    public string? MemoryId { get; set; }

    public string? SellerZipCode { get; set; }

    public string TaxUname { get; set; } = null!;
}
