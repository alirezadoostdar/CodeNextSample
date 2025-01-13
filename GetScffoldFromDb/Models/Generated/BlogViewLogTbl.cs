using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class BlogViewLogTbl
{
    public int FkUid { get; set; }

    public int FkBlogId { get; set; }

    public DateTime ViewDate { get; set; }
}
