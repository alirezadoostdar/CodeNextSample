using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwTaxInvoiceAmount
{
    public int FkInvoiceSysCode { get; set; }

    public double? TotalCount { get; set; }

    public double? DiscountAmountTdis { get; set; }

    public double? AmountBeforeDisTprdis { get; set; }

    public double? AmountAfterDisTadis { get; set; }

    public double? MaliatAvarezAmountTvam { get; set; }

    public double? TotalAmountTbill { get; set; }
}
