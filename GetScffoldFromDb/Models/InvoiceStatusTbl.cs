using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InvoiceStatusTBL")]
public partial class InvoiceStatusTbl
{
    [Key]
    [Column("ID")]
    public byte Id { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    public int? Color { get; set; }

    [StringLength(15)]
    public string? HexaColor { get; set; }

    [StringLength(500)]
    public string? FormatString { get; set; }

    public bool? SendSms { get; set; }

    public bool? SendNotification { get; set; }

    [InverseProperty("Status")]
    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
