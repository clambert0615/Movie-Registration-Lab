using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public int ID { get; set; }
       // [Required(ErrorMessage = "Movie title is required.")]
        //[StringLength(50, ErrorMessage = "Title can not be over 50 characters")]
        public string MovieTitle { get; set; }
        public string Genre { get; set; }

        public DateTime Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

    
    public Movie() { }

        public Movie(int id, string movietitle, string genre, DateTime year, string actors, string directors)
        {
            ID = id;
            MovieTitle = movietitle;
            Genre = genre;
            Year = year;
            Actors = actors;
            Directors = directors;
        }
    }    
}
