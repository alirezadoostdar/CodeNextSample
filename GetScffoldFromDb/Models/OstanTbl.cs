using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class OstanTbl
{
    public int OstanCode { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CityTbl> CityTbls { get; set; } = new List<CityTbl>();

    public virtual ICollection<TelBook> TelBooks { get; set; } = new List<TelBook>();
}
