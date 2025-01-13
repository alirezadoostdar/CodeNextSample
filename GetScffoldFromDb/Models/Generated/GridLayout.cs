using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class GridLayout
{
    public int Id { get; set; }

    public string LayoutName { get; set; } = null!;

    public byte[] Xmldata { get; set; } = null!;

    public bool PrimaryLayout { get; set; }

    public int Fkid { get; set; }

    public bool? CanPolicy { get; set; }

    public virtual GridsInfo Fk { get; set; } = null!;
}
