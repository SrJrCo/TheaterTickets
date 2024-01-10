using System;
namespace fa23FinalProjectGroup14.Models
{
	public class Movie
	{
		public Int32 MovieID { get; set; }

		public String Title { get; set; }

		public String Description { get; set; }

		public String Tagline { get; set; }

		public Int32 ReleaseYear { get; set; }

		public String MPAARating { get; set; }

		public String Actors { get; set; }

		public Int32 Runtime { get; set; }

		public Genre Genre { get; set; }

		public List<Review> Reviews { get; set; }
		public List<Schedule> Schedules { get; set; }
		public Movie()
		{
			if (Reviews == null)
			{
				Reviews = new List<Review>();
			}
			if (Schedules == null)
			{
				Schedules = new List<Schedule>();
			}
		}
	}
}

