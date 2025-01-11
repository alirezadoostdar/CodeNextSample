using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class Account
{
    [Key]
    public int AccountId { get; set; }

    public int? ParentAccountRef { get; set; }

    public int Type { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(250)]
    public string Title { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool Lock { get; set; }

    [Column(TypeName = "money")]
    public decimal? Balance { get; set; }

    public int SecurLevel { get; set; }

    [Column("Has_MNGDWN")]
    public bool HasMngdwn { get; set; }

    [Column("Fk_AccoutnSysCode")]
    public int? FkAccoutnSysCode { get; set; }

    [Column("Fk_AccoutnSysCode0")]
    public int? FkAccoutnSysCode0 { get; set; }

    public bool IsTemp { get; set; }

    [InverseProperty("FkAccount")]
    public virtual ICollection<DocDetailTbl> DocDetailTbls { get; set; } = new List<DocDetailTbl>();

    [ForeignKey("FkAccoutnSysCode0")]
    [InverseProperty("Accounts")]
    public virtual CodeMnguptbl? FkAccoutnSysCode0Navigation { get; set; }

    [ForeignKey("FkAccoutnSysCode")]
    [InverseProperty("Accounts")]
    public virtual CodeMngdwntbl? FkAccoutnSysCodeNavigation { get; set; }

    [InverseProperty("ParentAccountRefNavigation")]
    public virtual ICollection<Account> InverseParentAccountRefNavigation { get; set; } = new List<Account>();

    [ForeignKey("ParentAccountRef")]
    [InverseProperty("InverseParentAccountRefNavigation")]
    public virtual Account? ParentAccountRefNavigation { get; set; }

    [ForeignKey("SecurLevel")]
    [InverseProperty("Accounts")]
    public virtual InfoSecurityLevelTbl SecurLevelNavigation { get; set; } = null!;
}
