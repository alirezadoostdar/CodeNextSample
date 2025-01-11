using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("BranchTBL")]
public partial class BranchTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FK_TelBookID")]
    public int? FkTelBookId { get; set; }

    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    [StringLength(200)]
    public string? BranchName { get; set; }

    [ForeignKey("FkAccountSysCode")]
    [InverseProperty("BranchTbls")]
    public virtual CodeMngdwntbl? FkAccountSysCodeNavigation { get; set; }

    [ForeignKey("FkTelBookId")]
    [InverseProperty("BranchTbls")]
    public virtual TelBook? FkTelBook { get; set; }
}
