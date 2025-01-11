using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("FormLayoutTBL")]
public partial class FormLayoutTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(1000)]
    public string FormName { get; set; } = null!;

    [Column("XMLdata")]
    public byte[] Xmldata { get; set; } = null!;

    [Column("FK_UID")]
    public int FkUid { get; set; }

    public byte LanguageId { get; set; }
}
