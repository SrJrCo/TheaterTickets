using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace fa23FinalProjectGroup14.Models
{
	public class Schedule
	{
		public Int32 ScheduleID { get; set; }

		//should be calculated from run time
		public DateTime StartTime { get; set; }

		public DateTime EndTime { get; set; }

		public String Theater { get; set; }

		public bool SpecialEvent { get; set; } = false;

        public String SeatsAvailable { get; set; } = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25";

        //nav props:
        public Movie Movie { get; set; }

		public Price Price { get; set; }

		public List<TransactionDetail> TransactionDetails { get; set; }

		public Schedule()
		{
			if (TransactionDetails == null)
			{
				TransactionDetails = new List<TransactionDetail>();
			}
		}
	}
}

