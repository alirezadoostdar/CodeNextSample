using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwInvoiceSumPayment
{
    [Column(TypeName = "money")]
    public decimal? Fee { get; set; }

    [Column("FK_InvoiceSerial")]
    public int? FkInvoiceSerial { get; set; }
}
