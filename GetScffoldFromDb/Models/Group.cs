using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class Group
{
    public string Gname { get; set; } = null!;

    public int Gid { get; set; }

    public virtual ICollection<GroupPolicy> GroupPolicies { get; set; } = new List<GroupPolicy>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
