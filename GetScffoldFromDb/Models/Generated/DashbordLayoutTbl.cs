using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class DashbordLayoutTbl
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public byte[] Xmldata { get; set; } = null!;

    public bool UseCurrentDatabase { get; set; }
}
