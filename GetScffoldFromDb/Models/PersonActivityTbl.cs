using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("Person_ActivityTBL")]
public partial class PersonActivityTbl
{
    [Column("FK_AccountSysCode")]
    public int FkAccountSysCode { get; set; }

    [Column("FK_PersonActivity")]
    public int FkPersonActivity { get; set; }

    public float ActivityPer { get; set; }

    [Column("ISActive")]
    public bool Isactive { get; set; }

    [ForeignKey("FkAccountSysCode")]
    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    [ForeignKey("FkPersonActivity")]
    public virtual PersonActivityTbl1 FkPersonActivityNavigation { get; set; } = null!;
}
