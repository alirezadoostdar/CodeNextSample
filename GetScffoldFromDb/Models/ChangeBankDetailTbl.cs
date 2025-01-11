using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("ChangeBankDetailTbl")]
public partial class ChangeBankDetailTbl
{
    [Column("Fk_DocDetailsyscode")]
    public int FkDocDetailsyscode { get; set; }

    [StringLength(1000)]
    public string Number { get; set; } = null!;

    public int? OnChangeUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string OnChangeSysShamsiDate { get; set; } = null!;
}
