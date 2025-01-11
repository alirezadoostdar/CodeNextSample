using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InvoiceServerType")]
public partial class InvoiceServerType
{
    [Key]
    [Column("ID")]
    public byte Id { get; set; }

    [StringLength(50)]
    public string TypeTitle { get; set; } = null!;

    [InverseProperty("FkServerType")]
    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
