using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("VideoViewLogTBL")]
public partial class VideoViewLogTbl
{
    [Column("FK_UID")]
    public int FkUid { get; set; }

    [Column("FK_VideoID")]
    public int FkVideoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ViewDate { get; set; }
}
