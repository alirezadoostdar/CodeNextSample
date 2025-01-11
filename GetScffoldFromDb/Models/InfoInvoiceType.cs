using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InfoInvoiceType")]
public partial class InfoInvoiceType
{
    [Key]
    public int Value { get; set; }

    [StringLength(200)]
    public string? Caption { get; set; }

    [Column("syscode")]
    public int Syscode { get; set; }

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
