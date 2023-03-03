using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp;

public partial class Genre
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Field can't be empty")]
    [Display(Name = "Genre")]

    public string GenreName { get; set; } = null!;

    public virtual ICollection<Song> Songs { get; } = new List<Song>();
}
