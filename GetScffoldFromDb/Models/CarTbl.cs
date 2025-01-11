using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CarTBL")]
public partial class CarTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(200)]
    public string Title { get; set; } = null!;

    public int? YearOfConstruction { get; set; }

    [StringLength(50)]
    public string? CarTag { get; set; }

    public float? LoadLapacity { get; set; }

    [StringLength(50)]
    public string? Color { get; set; }

    [StringLength(200)]
    public string? MotorNo { get; set; }

    [StringLength(200)]
    public string? ChassisNo { get; set; }

    [StringLength(50)]
    public string? EngineCapacity { get; set; }

    [StringLength(200)]
    public string? CarOwner { get; set; }

    [StringLength(20)]
    public string? MobileOwner { get; set; }

    [InverseProperty("FkCar")]
    public virtual ICollection<DistributionTbl> DistributionTbls { get; set; } = new List<DistributionTbl>();
}
