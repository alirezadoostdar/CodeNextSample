using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InvoiceReturnResonTbl
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
