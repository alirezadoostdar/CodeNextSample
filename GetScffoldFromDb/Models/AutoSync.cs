using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class AutoSync
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string EntityName { get; set; } = null!;

    public string ActionTitle { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string SiteName { get; set; } = null!;
}
