using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class GroupPolicy
{
    public int Gid { get; set; }

    public int Pid { get; set; }

    public virtual Group GidNavigation { get; set; } = null!;
}
