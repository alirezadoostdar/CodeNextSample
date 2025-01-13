using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class AutoSyncLog
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string EntityName { get; set; } = null!;

    public string ActionTitle { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string SiteName { get; set; } = null!;

    public DateTime LogDate { get; set; }
}
