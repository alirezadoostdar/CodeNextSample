using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwInvoiceListNotPaymentAndNoPaymentComplete
{
    public string? CustomerName { get; set; }

    public int? FkAccountSysCode { get; set; }

    public string Comment { get; set; } = null!;

    public int InvoiceSerialNo { get; set; }

    public string? RecivedDate { get; set; }

    public string? DelivaredDate { get; set; }

    public string? PaymentDate { get; set; }

    public string? InvoiceDate { get; set; }

    public DateTime? InvoiceMiladiDate { get; set; }

    public int? FkDocsysCode { get; set; }

    public string? Uname { get; set; }

    public int InvoiceNo { get; set; }

    public bool? Amani { get; set; }

    public string? AccountName { get; set; }

    public string? ArchiveName { get; set; }

    public DateTime SysDate { get; set; }

    public string? Type { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalAmountWithMaliat { get; set; }

    public decimal? InvoiceAmountMaliat { get; set; }

    public decimal? InvoiceAmountAvarez { get; set; }

    public decimal? InvoiceAmountAvarezMaliat { get; set; }

    public float? VisitorAmount1 { get; set; }

    public float? VisitorAmount2 { get; set; }

    public float? Visitor2per { get; set; }

    public DateTime? RecievedMiladiDate { get; set; }

    public DateTime? DeliveredMiladiDate { get; set; }

    public DateTime? PaymentMiladiDate { get; set; }

    public double? InvoiceWieght { get; set; }

    public string? Visitor1 { get; set; }

    public string? Visitor2 { get; set; }

    public string? Driver { get; set; }

    public string? Distributor { get; set; }

    public string? Settlement { get; set; }

    public float? Visitor1per { get; set; }

    public decimal AmountPayment { get; set; }

    public int? VisitorSyscode { get; set; }

    public int? VisitorSysCode2 { get; set; }

    public byte FkYearId { get; set; }

    public int? FkProjectId { get; set; }
}
