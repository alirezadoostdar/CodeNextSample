using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TaxInvoiceType
{
    public byte Id { get; set; }

    public string TypeTitle { get; set; } = null!;

    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
