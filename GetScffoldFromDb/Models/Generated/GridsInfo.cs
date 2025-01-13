using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class GridsInfo
{
    public int Id { get; set; }

    public string Stpname { get; set; } = null!;

    public string RefrenceName { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public bool DefaultRef { get; set; }

    public int? OrderNo { get; set; }

    public string? RemainField { get; set; }

    public string? Field1name { get; set; }

    public string? Field2name { get; set; }

    public bool CanPolicy { get; set; }

    public string? DetailRef { get; set; }

    public string? RelationColumn { get; set; }

    public bool? PrintingSystem { get; set; }

    public bool? PrintOutPut { get; set; }

    public bool? MultiTable { get; set; }

    public string? PrintStPname { get; set; }

    public string? TableName { get; set; }

    public string? PolicyComment { get; set; }

    public int? PolicyLevel { get; set; }

    public bool? Disable { get; set; }

    public string? UpdateStp { get; set; }

    public string? DeleteStp { get; set; }

    public string? InsertStp { get; set; }

    public string? Syscodefield { get; set; }

    public bool? AutoUpdate { get; set; }

    public virtual ICollection<GridLayout> GridLayouts { get; set; } = new List<GridLayout>();

    public virtual ICollection<PrintLayout> PrintLayouts { get; set; } = new List<PrintLayout>();
}
