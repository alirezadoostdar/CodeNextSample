using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxInvoiceStatus")]
public partial class TaxInvoiceStatus
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string StatusTitle { get; set; } = null!;

    [InverseProperty("FkTaxInvoiceStatusNavigation")]
    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
