using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("Sys_ObjVerTbl")]
public partial class SysObjVerTbl
{
    [StringLength(100)]
    [Unicode(false)]
    public string? Obj { get; set; }

    [StringLength(50)]
    public string? Ver { get; set; }

    [StringLength(1000)]
    public string? Des { get; set; }
}
