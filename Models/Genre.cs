using System;
namespace fa23FinalProjectGroup14.Models
{
    public class Genre
    {
        public Int32 GenreID { get; set; }

        public String GenreName { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
