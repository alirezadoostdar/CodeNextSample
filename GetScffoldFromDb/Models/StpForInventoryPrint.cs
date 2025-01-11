using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class StpForInventoryPrint
{
    public string? StpName { get; set; }

    public int? Type { get; set; }

    public int Syscode { get; set; }

    public string? TableName { get; set; }
}
