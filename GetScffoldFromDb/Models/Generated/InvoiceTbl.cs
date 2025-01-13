using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InvoiceTbl
{
    public string CustomerName { get; set; } = null!;

    public int? FkAccountSysCode { get; set; }

    public string Comment { get; set; } = null!;

    public int InvoiceSerialNo { get; set; }

    public string? RecivedDate { get; set; }

    public string? DelivaredDate { get; set; }

    public string? PaymentDate { get; set; }

    public string? InvoiceDate { get; set; }

    public int? FkDocsysCode { get; set; }

    public string? ArchiveName { get; set; }

    public int UserNo { get; set; }

    public int InvoiceNo { get; set; }

    public int? VisitorSyscode { get; set; }

    public float? VisitorPer { get; set; }

    public decimal? VisitorAmount { get; set; }

    public DateTime SysDate { get; set; }

    public int Sign { get; set; }

    /// <summary>
    /// for descibe type of invoice : 1 sale  , 2 buy  , 3 return sale , 4 return buy
    /// </summary>
    public int Type { get; set; }

    public bool? Amani { get; set; }

    public string? SysShamsiDate { get; set; }

    public int? VisitorSysCode2 { get; set; }

    public int? DriversSysCode { get; set; }

    public int? DistributorSysCode { get; set; }

    public int? SettlementSysCode { get; set; }

    public int CurrencyId { get; set; }

    public decimal CurRateDef { get; set; }

    public decimal BaseRate { get; set; }

    public string? FollowDate { get; set; }

    public int? BranchTelId { get; set; }

    public DateTime? InvoiceMiladiDate { get; set; }

    public bool IsUpdate { get; set; }

    public byte[]? Signatur { get; set; }

    public byte? FkServerTypeId { get; set; }

    public int? ServerInvoiceSerial { get; set; }

    public string? Mobile { get; set; }

    public string? Address { get; set; }

    public string? ShopToken { get; set; }

    public string? ZipCode { get; set; }

    public string? DeliverName { get; set; }

    public byte? StatusId { get; set; }

    public string? StatusPromp { get; set; }

    public int? ShopId { get; set; }

    public string? PostFollowCode { get; set; }

    public int? FkReturnResonId { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public decimal? Benefit { get; set; }

    public int? FkProjectId { get; set; }

    public bool IsFirstRemain { get; set; }

    public DateTime? UpdateSysDate { get; set; }

    public int? LastUser { get; set; }

    public byte FkYearId { get; set; }

    public virtual ICollection<DistributionDetailTbl> DistributionDetailTbls { get; set; } = new List<DistributionDetailTbl>();

    public virtual CodeMngdwntbl? FkAccountSysCodeNavigation { get; set; }

    public virtual DocDetailTbl? FkDocsysCodeNavigation { get; set; }

    public virtual ProjectTbl? FkProject { get; set; }

    public virtual InvoiceReturnResonTbl? FkReturnReson { get; set; }

    public virtual InvoiceServerType? FkServerType { get; set; }

    public virtual FinancialYear FkYear { get; set; } = null!;

    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    public virtual ICollection<InvoiceCostDetailTbl> InvoiceCostDetailTbls { get; set; } = new List<InvoiceCostDetailTbl>();

    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTbls { get; set; } = new List<InvoiceDetailTbl>();

    public virtual ICollection<InvoicePaymentTbl> InvoicePaymentTbls { get; set; } = new List<InvoicePaymentTbl>();

    public virtual InvoiceStatusTbl? Status { get; set; }

    public virtual InfoInvoiceType TypeNavigation { get; set; } = null!;

    public virtual User UserNoNavigation { get; set; } = null!;

    public virtual CodeMngdwntbl? VisitorSyscodeNavigation { get; set; }

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
