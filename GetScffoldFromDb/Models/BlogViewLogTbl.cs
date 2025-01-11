using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("BlogViewLogTBL")]
public partial class BlogViewLogTbl
{
    [Column("FK_UID")]
    public int FkUid { get; set; }

    [Column("FK_BlogID")]
    public int FkBlogId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ViewDate { get; set; }
}
