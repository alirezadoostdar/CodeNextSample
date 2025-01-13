using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TaxInvoiceStatus
{
    public byte Id { get; set; }

    public string StatusTitle { get; set; } = null!;

    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
