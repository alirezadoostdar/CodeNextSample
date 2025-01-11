using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxInvoiceType")]
public partial class TaxInvoiceType
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string TypeTitle { get; set; } = null!;

    [InverseProperty("FkTaxInvoiceType")]
    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
