using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InvoiceServerType
{
    public byte Id { get; set; }

    public string TypeTitle { get; set; } = null!;

    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
