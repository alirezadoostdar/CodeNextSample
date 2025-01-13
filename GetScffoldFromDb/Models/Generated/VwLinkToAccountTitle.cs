using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwLinkToAccountTitle
{
    public int? LinkToAccount { get; set; }

    public string? LinkToTitle { get; set; }

    public int LinkTo { get; set; }

    public int LinkFrom { get; set; }

    public int? FkAccountSysCode0 { get; set; }
}
