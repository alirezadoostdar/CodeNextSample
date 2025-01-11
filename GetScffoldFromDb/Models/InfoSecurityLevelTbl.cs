using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InfoSecurityLevelTbl")]
public partial class InfoSecurityLevelTbl
{
    [Key]
    public int Value { get; set; }

    [StringLength(1000)]
    public string? Caption { get; set; }

    [InverseProperty("SecurLevelNavigation")]
    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    [InverseProperty("SecurLevelNavigation")]
    public virtual ICollection<CodeMngdwntbl> CodeMngdwntbls { get; set; } = new List<CodeMngdwntbl>();
}
