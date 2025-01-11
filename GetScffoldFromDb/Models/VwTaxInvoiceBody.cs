using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwTaxInvoiceBody
{
    public int GoodSysCode { get; set; }

    public int FkInvoiceSysCode { get; set; }

    public string? TitleSstt { get; set; }

    public int? TaxUnitIdMu { get; set; }

    public long? TaxIdSstid { get; set; }

    public string? TaxUnit { get; set; }

    public decimal Fee { get; set; }

    public double? QuantityAm { get; set; }

    public double MaliatAvarezPerVra { get; set; }

    public double? DiscountAmountDis { get; set; }

    public double? AmountBeforeDisPrdis { get; set; }

    public double? AmountAfterDisAdis { get; set; }

    public double? MaliatAvarezAmountVam { get; set; }

    public double? TotalAmountTsstam { get; set; }
}
