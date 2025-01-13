using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class DistributionTbl
{
    public int DistributionSerial { get; set; }

    public int? FkDriverSysCode { get; set; }

    public int? FkDistributorSysCode { get; set; }

    public string Comment { get; set; } = null!;

    public string Field1 { get; set; } = null!;

    public string Field2 { get; set; } = null!;

    public string Field3 { get; set; } = null!;

    public string DistributionDate { get; set; } = null!;

    public DateOnly DistributionMiladiDate { get; set; }

    public int UserNo { get; set; }

    public DateOnly SysMiladiDate { get; set; }

    public string SysShamsiDate { get; set; } = null!;

    public int DistributionNo { get; set; }

    public int? FkCarId { get; set; }

    public virtual ICollection<DistributionDetailTbl> DistributionDetailTbls { get; set; } = new List<DistributionDetailTbl>();

    public virtual CarTbl? FkCar { get; set; }

    public virtual CodeMngdwntbl? FkDistributorSysCodeNavigation { get; set; }

    public virtual CodeMngdwntbl? FkDriverSysCodeNavigation { get; set; }

    public virtual User UserNoNavigation { get; set; } = null!;
}
