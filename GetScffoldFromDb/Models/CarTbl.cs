using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class CarTbl
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? YearOfConstruction { get; set; }

    public string? CarTag { get; set; }

    public float? LoadLapacity { get; set; }

    public string? Color { get; set; }

    public string? MotorNo { get; set; }

    public string? ChassisNo { get; set; }

    public string? EngineCapacity { get; set; }

    public string? CarOwner { get; set; }

    public string? MobileOwner { get; set; }

    public virtual ICollection<DistributionTbl> DistributionTbls { get; set; } = new List<DistributionTbl>();
}
