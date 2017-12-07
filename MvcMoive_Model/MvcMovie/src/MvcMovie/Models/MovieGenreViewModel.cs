using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;              // List of moives
        public SelectList genres;               // List of genres
        public string movieGenre { get; set; }  // selected genre
    }
}
