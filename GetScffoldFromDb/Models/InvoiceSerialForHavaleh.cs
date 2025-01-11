using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("InvoiceSerialForHavaleh")]
public partial class InvoiceSerialForHavaleh
{
    public int InvoiceSerial { get; set; }
}
