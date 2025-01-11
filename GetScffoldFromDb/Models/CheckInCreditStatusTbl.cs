using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class CheckInCreditStatusTbl
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Comment { get; set; }

    public int? Color { get; set; }

    public virtual ICollection<CheckInTbl> CheckInTbls { get; set; } = new List<CheckInTbl>();
}
