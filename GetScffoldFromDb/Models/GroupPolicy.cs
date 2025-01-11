using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[PrimaryKey("Gid", "Pid")]
public partial class GroupPolicy
{
    [Key]
    [Column("GID")]
    public int Gid { get; set; }

    [Key]
    [Column("PID")]
    public int Pid { get; set; }

    [ForeignKey("Gid")]
    [InverseProperty("GroupPolicies")]
    public virtual Group GidNavigation { get; set; } = null!;
}
