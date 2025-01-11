using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("UserDefaultPrintLayoutTbl")]
public partial class UserDefaultPrintLayoutTbl
{
    public int LayoutId { get; set; }

    public int UserId { get; set; }

    public int RefId { get; set; }
}
