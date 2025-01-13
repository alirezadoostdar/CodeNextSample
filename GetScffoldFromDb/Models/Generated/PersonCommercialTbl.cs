using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class PersonCommercialTbl
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Color { get; set; }

    public string? HexaColor { get; set; }

    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
