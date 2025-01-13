using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InfoAccountKind
{
    public int KindCode { get; set; }

    public string KindTxt { get; set; } = null!;

    public virtual ICollection<CodeMnguptbl> CodeMnguptbls { get; set; } = new List<CodeMnguptbl>();
}
