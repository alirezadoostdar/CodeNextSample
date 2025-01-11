using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class PersonKind
{
    public int Id { get; set; }

    public string Kind { get; set; } = null!;

    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
