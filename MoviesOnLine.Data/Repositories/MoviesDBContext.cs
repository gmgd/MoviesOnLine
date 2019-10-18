using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesOnLine.Data.Entities;

namespace MoviesOnLine.Data.Repositories
{
    public class MoviesDBContext: DbContext
    { 
        public DbSet<Movie> Movies { get; set; }


    }
}
