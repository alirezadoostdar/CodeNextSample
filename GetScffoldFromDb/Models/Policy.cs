using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class Policy
{
    public string Pname { get; set; } = null!;

    public int? Plevel { get; set; }

    public int Pid { get; set; }
}
