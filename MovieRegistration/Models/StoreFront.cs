using System.Collections.Generic;

namespace MovieRegistration.Models
{
    public class StoreFront
    {
        public int Index { get; set; }
        public int NextIndex { get; set; }
        public int PrevIndex { get; set; }
        public Movie Movie { get; set; }

        public List<Movie> Movies {get; set;}
    }
}
