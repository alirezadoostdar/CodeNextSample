using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("BankDetailTbl")]
public partial class BankDetailTbl
{
    [Key]
    [Column("Fk_DocDetailsyscode")]
    public int FkDocDetailsyscode { get; set; }

    [StringLength(1000)]
    public string Number { get; set; } = null!;

    public bool IsPos { get; set; }

    [ForeignKey("FkDocDetailsyscode")]
    [InverseProperty("BankDetailTbl")]
    public virtual DocDetailTbl FkDocDetailsyscodeNavigation { get; set; } = null!;
}
