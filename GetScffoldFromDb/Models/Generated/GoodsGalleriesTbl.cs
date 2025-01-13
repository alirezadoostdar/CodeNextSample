using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class GoodsGalleriesTbl
{
    public int SysCode { get; set; }

    public int FkGoodSysCode { get; set; }

    public string ImageName { get; set; } = null!;
}
