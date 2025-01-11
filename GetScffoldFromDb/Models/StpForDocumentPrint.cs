using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("StpForDocumentPrint")]
public partial class StpForDocumentPrint
{
    [StringLength(100)]
    public string StpName { get; set; } = null!;

    [Key]
    public int Syscode { get; set; }

    [StringLength(100)]
    public string TableName { get; set; } = null!;
}
