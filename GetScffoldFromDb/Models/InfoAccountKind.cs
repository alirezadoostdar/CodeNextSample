using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InfoAccountKind")]
public partial class InfoAccountKind
{
    [Key]
    public int KindCode { get; set; }

    [StringLength(50)]
    public string KindTxt { get; set; } = null!;

    [InverseProperty("KindNavigation")]
    public virtual ICollection<CodeMnguptbl> CodeMnguptbls { get; set; } = new List<CodeMnguptbl>();
}
