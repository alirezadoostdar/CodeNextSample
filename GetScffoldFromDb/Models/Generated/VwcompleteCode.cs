using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwcompleteCode
{
    public int AccountSysCode { get; set; }

    public string Title { get; set; } = null!;

    public decimal CreditLimit { get; set; }

    public byte SecurLevel { get; set; }

    public int Code0 { get; set; }

    public string Title0 { get; set; } = null!;

    public byte Kind { get; set; }
}
