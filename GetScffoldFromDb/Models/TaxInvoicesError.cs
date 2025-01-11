using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxInvoices_Errors")]
public partial class TaxInvoicesError
{
    [Key]
    public int Id { get; set; }

    [Column("Fk_TaxInvoiceId")]
    public int? FkTaxInvoiceId { get; set; }

    [StringLength(22)]
    public string Code { get; set; } = null!;

    [StringLength(1000)]
    public string Message { get; set; } = null!;

    [StringLength(22)]
    public string ErrorType { get; set; } = null!;

    [Column("Fk_TaxErrorTypeId")]
    public byte FkTaxErrorTypeId { get; set; }

    [ForeignKey("FkTaxErrorTypeId")]
    [InverseProperty("TaxInvoicesErrors")]
    public virtual TaxErrorType FkTaxErrorType { get; set; } = null!;

    [ForeignKey("FkTaxInvoiceId")]
    [InverseProperty("TaxInvoicesErrors")]
    public virtual TaxInvoice? FkTaxInvoice { get; set; }
}
