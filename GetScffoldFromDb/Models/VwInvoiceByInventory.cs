using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwInvoiceByInventory
{
    public int InvoiceSerialNo { get; set; }

    public int? FkAccountSysCode { get; set; }

    public string Comment { get; set; } = null!;

    public string? RecivedDate { get; set; }

    public string? DelivaredDate { get; set; }

    public string? PaymentDate { get; set; }

    public string? InvoiceDate { get; set; }

    public int? FkDocsysCode { get; set; }

    public int? InventorySerial { get; set; }

    public string? InventoryDate { get; set; }
}
