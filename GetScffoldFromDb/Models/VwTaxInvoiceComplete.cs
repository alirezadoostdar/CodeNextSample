using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwTaxInvoiceComplete
{
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

    [StringLength(50)]
    public string? PatternTitle { get; set; }

    [StringLength(50)]
    public string? SettlementTitle { get; set; }

    [StringLength(50)]
    public string? TypeTitle { get; set; }

    [StringLength(50)]
    public string? StatusTitle { get; set; }

    [Column("Title_FilaName")]
    [StringLength(150)]
    public string? TitleFilaName { get; set; }

    [Column("Seller_MeliCode")]
    [StringLength(20)]
    public string? SellerMeliCode { get; set; }

    [Column("Seller_EconomicCode")]
    [StringLength(20)]
    public string? SellerEconomicCode { get; set; }

    [Column("Memory_Id")]
    [StringLength(20)]
    public string? MemoryId { get; set; }

    [Column("Seller_ZipCode")]
    [StringLength(20)]
    public string? SellerZipCode { get; set; }

    [Column("TaxUName")]
    [StringLength(1000)]
    public string TaxUname { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal CashAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal PersonAmount { get; set; }

    [Column("Fk_UserId")]
    public int FkUserId { get; set; }

    [StringLength(50)]
    public string? IssueTitle { get; set; }
}
