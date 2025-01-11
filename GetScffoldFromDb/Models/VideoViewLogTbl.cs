using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VideoViewLogTbl
{
    public int FkUid { get; set; }

    public int FkVideoId { get; set; }

    public DateTime ViewDate { get; set; }
}
