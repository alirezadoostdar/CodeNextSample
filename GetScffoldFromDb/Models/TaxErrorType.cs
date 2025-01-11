using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxErrorType")]
public partial class TaxErrorType
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string ErrorTitle { get; set; } = null!;

    [InverseProperty("FkTaxErrorType")]
    public virtual ICollection<TaxInvoicesError> TaxInvoicesErrors { get; set; } = new List<TaxInvoicesError>();
}
