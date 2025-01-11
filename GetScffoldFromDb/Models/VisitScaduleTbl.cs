using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VisitScaduleTbl
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Comment { get; set; }

    public string? ShamsiDate { get; set; }

    public DateTime? Date { get; set; }

    public int? FkVisitorId { get; set; }

    public int? FkZoneId { get; set; }

    public virtual CodeMngdwntbl? FkVisitor { get; set; }

    public virtual ZoneTbl? FkZone { get; set; }
}
