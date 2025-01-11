using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DocLinkSndTBL")]
public partial class DocLinkSndTbl
{
    [Key]
    [Column("FK_FstDocDetail")]
    public int FkFstDocDetail { get; set; }

    [Column("FK_SndDocDetail")]
    public int FkSndDocDetail { get; set; }

    [Column("FK_MainDocDetail")]
    public int FkMainDocDetail { get; set; }

    [ForeignKey("FkFstDocDetail")]
    [InverseProperty("DocLinkSndTblFkFstDocDetailNavigation")]
    public virtual DocDetailTbl FkFstDocDetailNavigation { get; set; } = null!;

    [ForeignKey("FkMainDocDetail")]
    [InverseProperty("DocLinkSndTblFkMainDocDetailNavigations")]
    public virtual DocDetailTbl FkMainDocDetailNavigation { get; set; } = null!;

    [ForeignKey("FkSndDocDetail")]
    [InverseProperty("DocLinkSndTblFkSndDocDetailNavigations")]
    public virtual DocDetailTbl FkSndDocDetailNavigation { get; set; } = null!;
}
