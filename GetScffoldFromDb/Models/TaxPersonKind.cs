using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxPersonKind")]
public partial class TaxPersonKind
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string PersonKindTitle { get; set; } = null!;

    [InverseProperty("FkTaxPersonKind")]
    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
