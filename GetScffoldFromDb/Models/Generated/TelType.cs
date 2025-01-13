using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TelType
{
    public string TelTypes { get; set; } = null!;

    public int Fk { get; set; }
}
