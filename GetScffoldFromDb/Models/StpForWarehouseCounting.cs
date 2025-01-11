using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class StpForWarehouseCounting
{
    public int Syscode { get; set; }

    public string? StpName { get; set; }

    public string? TableName { get; set; }
}
