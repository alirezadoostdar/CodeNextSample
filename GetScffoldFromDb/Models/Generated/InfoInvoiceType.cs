using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InfoInvoiceType
{
    public int Value { get; set; }

    public string? Caption { get; set; }

    public int Syscode { get; set; }

    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
