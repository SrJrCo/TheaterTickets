using System;

namespace fa23FinalProjectGroup14.Models
{
    public enum SearchType { Greater, Less }

    public class MovieSearchViewModel
	{
		public String Title { get; set; }

		public String Tagline { get; set; }

		public Int32 SelectedGenreID { get; set; }
	}
}

