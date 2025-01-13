using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class FactorPrintLayoutPrinterTbl
{
    public int LayOutId { get; set; }

    public string? PrinterName { get; set; }

    public bool? Active { get; set; }

    public int? UserId { get; set; }
}
