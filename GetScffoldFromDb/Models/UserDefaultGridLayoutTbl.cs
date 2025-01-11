using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("UserDefaultGridLayoutTbl")]
public partial class UserDefaultGridLayoutTbl
{
    public int LayoutId { get; set; }

    public int UserId { get; set; }

    public int RefId { get; set; }
}
