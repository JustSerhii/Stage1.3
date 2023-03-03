using System;
using System.Collections.Generic;

namespace WebApp;

public partial class Album
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public virtual ICollection<AlbumReview> AlbumReviews { get; } = new List<AlbumReview>();

    public virtual ICollection<AlbumSong> AlbumSongs { get; } = new List<AlbumSong>();
}
