using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("StpForInventoryPrint")]
public partial class StpForInventoryPrint
{
    [StringLength(100)]
    public string? StpName { get; set; }

    public int? Type { get; set; }

    public int Syscode { get; set; }

    [StringLength(100)]
    public string? TableName { get; set; }
}
