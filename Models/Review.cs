using System;
namespace fa23FinalProjectGroup14.Models
{
	public class Review
	{
		public Int32 ReviewID { get; set; }

		public Decimal Rating { get; set; }

		public String Description { get; set; }

		public String Status { get; set; }

		public Movie Movie { get; set; }

		public AppUser User { get; set; }
	}
}

