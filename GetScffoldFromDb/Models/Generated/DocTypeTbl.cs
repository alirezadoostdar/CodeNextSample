using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class DocTypeTbl
{
    public byte Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<DocTbl> DocTbls { get; set; } = new List<DocTbl>();
}
