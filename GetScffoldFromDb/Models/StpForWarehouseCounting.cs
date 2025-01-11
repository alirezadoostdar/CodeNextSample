using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("StpForWarehouseCounting")]
public partial class StpForWarehouseCounting
{
    public int Syscode { get; set; }

    [StringLength(100)]
    public string? StpName { get; set; }

    [StringLength(100)]
    public string? TableName { get; set; }
}
