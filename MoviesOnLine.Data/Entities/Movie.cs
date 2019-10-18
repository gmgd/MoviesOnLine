using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesOnLine.Data.Entities
{
    public class Movie
    {

        public int MovieId { get; set; }
        public string Title { get; set; }
        
        public float Duration { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }
    }
}
