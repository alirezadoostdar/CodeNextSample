using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("DeletedCodeMNGDWNTbl")]
public partial class DeletedCodeMngdwntbl
{
    [Column("FK_AccountSysCode0")]
    public int FkAccountSysCode0 { get; set; }

    public int AccountSysCode { get; set; }

    public string Title { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal CreditLimit { get; set; }

    public int SecurLevel { get; set; }

    public bool? BedehkarOnly { get; set; }

    public bool DeleteOnServer { get; set; }
}
