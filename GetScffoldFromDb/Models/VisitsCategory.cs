using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VisitsCategory
{
    public byte CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public byte VisitType { get; set; }

    public virtual VisitsType VisitTypeNavigation { get; set; } = null!;

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
