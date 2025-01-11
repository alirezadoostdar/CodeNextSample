using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class PersonCustomerKindTbl
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
