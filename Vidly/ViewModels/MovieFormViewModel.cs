﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        [Required]
        public int? Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, Display(Name = "Genre")]
        public int? GenreId { get; set; }

        [Required, Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required, Display(Name = "Number in Stock"), Range(1, 20)]
        public int? NumberInStock { get; set; }
        public IEnumerable<Genre> GenreList { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
        }

        public string Title
        {
            get { return Id != 0 ? "Edit movie" : "New movie"; }
        }

    }
}