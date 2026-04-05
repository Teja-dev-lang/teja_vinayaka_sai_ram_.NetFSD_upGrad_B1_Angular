using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Business.DTOs
{
    public class MovieDTO
    {
        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Pls Enter the Movie Title")]

        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public Byte Rating { get; set; }
        public String? Language { get; set; }
    }
}
