using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ChangeInvoiceTbl
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

    public int Type { get; set; }

    public bool? Amani { get; set; }

    public int? OnChangeUserId { get; set; }

    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public string? OnChangeSysShamsiDate { get; set; }

    public int? VisitorSysCode2 { get; set; }

    public int? DriversSysCode { get; set; }

    public int? DistributorSysCode { get; set; }

    public int? SettlementSysCode { get; set; }

    public bool? IsDeleteOnServer { get; set; }
}
