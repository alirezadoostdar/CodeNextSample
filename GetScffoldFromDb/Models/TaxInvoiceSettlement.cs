using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxInvoiceSettlement")]
public partial class TaxInvoiceSettlement
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string SettlementTitle { get; set; } = null!;

    [InverseProperty("FkTaxInvoiceSettlement")]
    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
