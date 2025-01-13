using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class StpForInvoicePrint
{
    public string? StpName { get; set; }

    public int? Type { get; set; }

    public int Syscode { get; set; }

    public string? TableName { get; set; }
}
