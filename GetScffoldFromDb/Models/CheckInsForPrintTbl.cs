using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("CheckInsForPrintTBL")]
public partial class CheckInsForPrintTbl
{
    public int Radif { get; set; }

    public long SerialNo { get; set; }

    [Column("ACCNo")]
    [StringLength(1000)]
    public string Accno { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? CheckDate { get; set; }

    [StringLength(1000)]
    public string BankName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal Amount { get; set; }
}
