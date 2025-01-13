using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class ChartLayoutTbl
{
    public int Id { get; set; }

    public string ChartName { get; set; } = null!;

    public byte[] Xmldata { get; set; } = null!;

    public int FkUid { get; set; }

    public string? Lang { get; set; }
}
