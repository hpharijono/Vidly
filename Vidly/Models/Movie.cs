﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required, Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Required, Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required, Display(Name = "Number in Stock"), Range(1,20)]
        public int NumberInStock { get; set; }

        
    }
}