using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwTaxInvoiceBody
{
    public int GoodSysCode { get; set; }

    [Column("FK_InvoiceSysCode")]
    public int FkInvoiceSysCode { get; set; }

    [Column("Title_Sstt")]
    [StringLength(1000)]
    public string? TitleSstt { get; set; }

    [Column("TaxUnitId_Mu")]
    public int? TaxUnitIdMu { get; set; }

    [Column("TaxId_Sstid")]
    public long? TaxIdSstid { get; set; }

    [StringLength(50)]
    public string? TaxUnit { get; set; }

    [Column(TypeName = "money")]
    public decimal Fee { get; set; }

    [Column("Quantity_Am")]
    public double? QuantityAm { get; set; }

    [Column("MaliatAvarezPer_Vra")]
    public double MaliatAvarezPerVra { get; set; }

    [Column("DiscountAmount_Dis")]
    public double? DiscountAmountDis { get; set; }

    [Column("AmountBeforeDis_Prdis")]
    public double? AmountBeforeDisPrdis { get; set; }

    [Column("AmountAfterDis_Adis")]
    public double? AmountAfterDisAdis { get; set; }

    [Column("MaliatAvarezAmount_Vam")]
    public double? MaliatAvarezAmountVam { get; set; }

    [Column("TotalAmount_Tsstam")]
    public double? TotalAmountTsstam { get; set; }
}
