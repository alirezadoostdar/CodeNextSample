using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class CityTbl
{
    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public int? FkOstan { get; set; }

    public virtual OstanTbl? FkOstanNavigation { get; set; }

    public virtual ICollection<TelBook> TelBooks { get; set; } = new List<TelBook>();
}
