using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class TaxPersonKind
{
    public byte Id { get; set; }

    public string PersonKindTitle { get; set; } = null!;

    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
