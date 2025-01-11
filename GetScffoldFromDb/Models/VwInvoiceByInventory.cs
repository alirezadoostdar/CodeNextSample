using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwInvoiceByInventory
{
    public int InvoiceSerialNo { get; set; }

    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    [StringLength(300)]
    public string Comment { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? RecivedDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DelivaredDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PaymentDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    [Column("FK_DocsysCode")]
    public int? FkDocsysCode { get; set; }

    public int? InventorySerial { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InventoryDate { get; set; }
}
