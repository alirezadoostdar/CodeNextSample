using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class Group
{
    [StringLength(1000)]
    public string Gname { get; set; } = null!;

    [Key]
    [Column("GID")]
    public int Gid { get; set; }

    [InverseProperty("GidNavigation")]
    public virtual ICollection<GroupPolicy> GroupPolicies { get; set; } = new List<GroupPolicy>();

    [InverseProperty("GidNavigation")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
