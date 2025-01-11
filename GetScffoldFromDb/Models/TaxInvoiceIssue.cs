using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxInvoiceIssue")]
public partial class TaxInvoiceIssue
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string IssueTitle { get; set; } = null!;

    [InverseProperty("FkTaxInvoiceIssue")]
    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
