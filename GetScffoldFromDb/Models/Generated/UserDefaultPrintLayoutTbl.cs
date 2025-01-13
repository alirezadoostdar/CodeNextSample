using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class UserDefaultPrintLayoutTbl
{
    public int LayoutId { get; set; }

    public int UserId { get; set; }

    public int RefId { get; set; }
}
