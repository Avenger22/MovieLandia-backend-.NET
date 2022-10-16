﻿using System;
using System.Collections.Generic;

namespace Entities.Models
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public partial class Movie
    {
        public Movie()
        {
            Favorites = new HashSet<Favorite>();
            MovieGenres = new HashSet<MovieGenre>();
        }

        
        public int Id { get; set; }
       
        public string Title { get; set; } = null!;
      
        public string VideoSrc { get; set; } = null!;
      
        public string PhotoSrc { get; set; } = null!;
        
        public string TrailerSrc { get; set; } = null!;
      
        public string Duration { get; set; } = null!;
      
        public float RatingImdb { get; set; }
        
        public int ReleaseYear { get; set; }
       
        public string Description { get; set; } = null!;
     
        public int Views { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
