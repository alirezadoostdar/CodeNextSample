using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InvoiceTbl")]
public partial class InvoiceTbl
{
    [StringLength(300)]
    public string CustomerName { get; set; } = null!;

    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    [StringLength(300)]
    public string Comment { get; set; } = null!;

    [Key]
    public int InvoiceSerialNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RecivedDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DelivaredDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PaymentDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    [Column("FK_DocsysCode")]
    public int? FkDocsysCode { get; set; }

    [StringLength(100)]
    public string? ArchiveName { get; set; }

    public int UserNo { get; set; }

    public int InvoiceNo { get; set; }

    public int? VisitorSyscode { get; set; }

    public float? VisitorPer { get; set; }

    [Column(TypeName = "money")]
    public decimal? VisitorAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    public int Sign { get; set; }

    /// <summary>
    /// for descibe type of invoice : 1 sale  , 2 buy  , 3 return sale , 4 return buy
    /// </summary>
    public int Type { get; set; }

    public bool? Amani { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SysShamsiDate { get; set; }

    public int? VisitorSysCode2 { get; set; }

    public int? DriversSysCode { get; set; }

    public int? DistributorSysCode { get; set; }

    public int? SettlementSysCode { get; set; }

    [Column("CurrencyID")]
    public int CurrencyId { get; set; }

    [Column(TypeName = "money")]
    public decimal CurRateDef { get; set; }

    [Column(TypeName = "money")]
    public decimal BaseRate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FollowDate { get; set; }

    [Column("BranchTelID")]
    public int? BranchTelId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceMiladiDate { get; set; }

    public bool IsUpdate { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Signatur { get; set; }

    [Column("FK_ServerTypeID")]
    public byte? FkServerTypeId { get; set; }

    public int? ServerInvoiceSerial { get; set; }

    [StringLength(100)]
    public string? Mobile { get; set; }

    [StringLength(300)]
    public string? Address { get; set; }

    [StringLength(300)]
    public string? ShopToken { get; set; }

    [StringLength(100)]
    public string? ZipCode { get; set; }

    [StringLength(100)]
    public string? DeliverName { get; set; }

    [Column("StatusID")]
    public byte? StatusId { get; set; }

    [StringLength(500)]
    public string? StatusPromp { get; set; }

    [Column("ShopID")]
    public int? ShopId { get; set; }

    [StringLength(200)]
    public string? PostFollowCode { get; set; }

    [Column("FK_ReturnResonID")]
    public int? FkReturnResonId { get; set; }

    [StringLength(200)]
    public string? Field1 { get; set; }

    [StringLength(200)]
    public string? Field2 { get; set; }

    [StringLength(200)]
    public string? Field3 { get; set; }

    [StringLength(200)]
    public string? Field4 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Benefit { get; set; }

    [Column("Fk_ProjectID")]
    public int? FkProjectId { get; set; }

    public bool IsFirstRemain { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateSysDate { get; set; }

    public int? LastUser { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }

    [InverseProperty("FkInvoiceSerialNavigation")]
    public virtual ICollection<DistributionDetailTbl> DistributionDetailTbls { get; set; } = new List<DistributionDetailTbl>();

    [ForeignKey("FkAccountSysCode")]
    [InverseProperty("InvoiceTblFkAccountSysCodeNavigations")]
    public virtual CodeMngdwntbl? FkAccountSysCodeNavigation { get; set; }

    [ForeignKey("FkDocsysCode")]
    [InverseProperty("InvoiceTbls")]
    public virtual DocDetailTbl? FkDocsysCodeNavigation { get; set; }

    [ForeignKey("FkProjectId")]
    [InverseProperty("InvoiceTbls")]
    public virtual ProjectTbl? FkProject { get; set; }

    [ForeignKey("FkReturnResonId")]
    [InverseProperty("InvoiceTbls")]
    public virtual InvoiceReturnResonTbl? FkReturnReson { get; set; }

    [ForeignKey("FkServerTypeId")]
    [InverseProperty("InvoiceTbls")]
    public virtual InvoiceServerType? FkServerType { get; set; }

    [ForeignKey("FkYearId")]
    [InverseProperty("InvoiceTbls")]
    public virtual FinancialYear FkYear { get; set; } = null!;

    [InverseProperty("FkInvoiceSerialNavigation")]
    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    [InverseProperty("FkFactorSerialNoNavigation")]
    public virtual ICollection<InvoiceCostDetailTbl> InvoiceCostDetailTbls { get; set; } = new List<InvoiceCostDetailTbl>();

    [InverseProperty("FkInvoiceSysCodeNavigation")]
    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTbls { get; set; } = new List<InvoiceDetailTbl>();

    [InverseProperty("FkInvoiceSerialNavigation")]
    public virtual ICollection<InvoicePaymentTbl> InvoicePaymentTbls { get; set; } = new List<InvoicePaymentTbl>();

    [ForeignKey("StatusId")]
    [InverseProperty("InvoiceTbls")]
    public virtual InvoiceStatusTbl? Status { get; set; }

    [ForeignKey("Type")]
    [InverseProperty("InvoiceTbls")]
    public virtual InfoInvoiceType TypeNavigation { get; set; } = null!;

    [ForeignKey("UserNo")]
    [InverseProperty("InvoiceTbls")]
    public virtual User UserNoNavigation { get; set; } = null!;

    [ForeignKey("VisitorSyscode")]
    [InverseProperty("InvoiceTblVisitorSyscodeNavigations")]
    public virtual CodeMngdwntbl? VisitorSyscodeNavigation { get; set; }

    [InverseProperty("FkInvoiceSerialNoNavigation")]
    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
