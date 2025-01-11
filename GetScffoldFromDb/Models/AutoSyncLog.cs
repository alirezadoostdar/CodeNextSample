using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("AutoSyncLog")]
public partial class AutoSyncLog
{
    [Key]
    public int Id { get; set; }

    public int EntityId { get; set; }

    [StringLength(50)]
    public string EntityName { get; set; } = null!;

    [StringLength(10)]
    public string ActionTitle { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [StringLength(50)]
    public string SiteName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LogDate { get; set; }
}
