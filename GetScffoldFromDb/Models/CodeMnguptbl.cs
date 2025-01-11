using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CodeMNGUPTbl")]
public partial class CodeMnguptbl
{
    [Key]
    public int AccountSysCode0 { get; set; }

    public string Title { get; set; } = null!;

    public int Kind { get; set; }

    public bool? Private { get; set; }

    public bool IsTafsilGroup { get; set; }

    [InverseProperty("FkAccoutnSysCode0Navigation")]
    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    [InverseProperty("FkAccountSysCode0Navigation")]
    public virtual ICollection<CodeMngdwntbl> CodeMngdwntbls { get; set; } = new List<CodeMngdwntbl>();

    [ForeignKey("Kind")]
    [InverseProperty("CodeMnguptbls")]
    public virtual InfoAccountKind KindNavigation { get; set; } = null!;
}
