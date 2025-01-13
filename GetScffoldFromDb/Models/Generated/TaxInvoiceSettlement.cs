using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TaxInvoiceSettlement
{
    public byte Id { get; set; }

    public string SettlementTitle { get; set; } = null!;

    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
