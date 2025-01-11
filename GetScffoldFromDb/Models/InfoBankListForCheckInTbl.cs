using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("InfoBankListForCheckInTBL")]
public partial class InfoBankListForCheckInTbl
{
    [StringLength(50)]
    public string? BankName { get; set; }
}
