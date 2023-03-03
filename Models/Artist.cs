using System;
using System.Collections.Generic;

namespace WebApp;

public partial class Artist
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public DateTime? DeathDate { get; set; }

    public virtual ICollection<Song> Songs { get; } = new List<Song>();
}
