using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwInvoiceSumPayment
{
    public decimal? Fee { get; set; }

    public int? FkInvoiceSerial { get; set; }
}
