using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DocLinkTBL")]
public partial class DocLinkTbl
{
    [Key]
    [Column("FK_FstDocDetail")]
    public int FkFstDocDetail { get; set; }

    [Column("FK_SndDocDetail")]
    public int FkSndDocDetail { get; set; }

    [ForeignKey("FkFstDocDetail")]
    [InverseProperty("DocLinkTblFkFstDocDetailNavigation")]
    public virtual DocDetailTbl FkFstDocDetailNavigation { get; set; } = null!;

    [ForeignKey("FkSndDocDetail")]
    [InverseProperty("DocLinkTblFkSndDocDetailNavigations")]
    public virtual DocDetailTbl FkSndDocDetailNavigation { get; set; } = null!;
}
