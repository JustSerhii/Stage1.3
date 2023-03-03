using System;
using System.Collections.Generic;

namespace WebApp;

public partial class AlbumSong
{
    public int Id { get; set; }

    public int? SongId { get; set; }

    public int? AlbumId { get; set; }

    public virtual Album? Album { get; set; }

    public virtual Song? Song { get; set; }
}
