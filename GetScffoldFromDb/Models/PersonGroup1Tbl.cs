using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class PersonGroup1Tbl
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
