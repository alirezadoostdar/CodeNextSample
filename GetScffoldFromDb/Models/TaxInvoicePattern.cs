using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxInvoicePattern")]
public partial class TaxInvoicePattern
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string PatternTitle { get; set; } = null!;

    [InverseProperty("FkTaxInvoicePattern")]
    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
