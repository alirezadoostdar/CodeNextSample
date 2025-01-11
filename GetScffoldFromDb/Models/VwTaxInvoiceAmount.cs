using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwTaxInvoiceAmount
{
    [Column("FK_InvoiceSysCode")]
    public int FkInvoiceSysCode { get; set; }

    public double? TotalCount { get; set; }

    [Column("DiscountAmount_Tdis")]
    public double? DiscountAmountTdis { get; set; }

    [Column("AmountBeforeDis_Tprdis")]
    public double? AmountBeforeDisTprdis { get; set; }

    [Column("AmountAfterDis_Tadis")]
    public double? AmountAfterDisTadis { get; set; }

    [Column("MaliatAvarezAmount_Tvam")]
    public double? MaliatAvarezAmountTvam { get; set; }

    [Column("TotalAmount_Tbill")]
    public double? TotalAmountTbill { get; set; }
}
