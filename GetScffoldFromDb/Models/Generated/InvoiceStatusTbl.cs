using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InvoiceStatusTbl
{
    public byte Id { get; set; }

    public string? Title { get; set; }

    public int? Color { get; set; }

    public string? HexaColor { get; set; }

    public string? FormatString { get; set; }

    public bool? SendSms { get; set; }

    public bool? SendNotification { get; set; }

    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
