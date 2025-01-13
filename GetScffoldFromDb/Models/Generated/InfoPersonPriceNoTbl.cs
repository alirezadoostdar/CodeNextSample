using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InfoPersonPriceNoTbl
{
    public int Value { get; set; }

    public string? Caption { get; set; }

    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
