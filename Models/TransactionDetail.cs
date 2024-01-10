using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace fa23FinalProjectGroup14.Models
{
	public class TransactionDetail
	{
		public Int32 TransactionDetailID { get; set; }

		public Int32 PurchaseID { get; set; }

        public String Seat { get; set; }

		public Int32 PopcornPointsGainedOrLost { get; set; } = 0;

		public bool SeniorDiscount { get; set; } = false;

		public bool TuesdayDiscount { get; set; } = false;

        public Int32 TicketPrice { get; set; }
        //TODO: might have to have a calcualte function here

        //Nav props:
        public Transaction Transaction { get; set; }

		public Schedule Schedule { get; set; }

    }
}

