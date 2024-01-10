using System;
using System.ComponentModel.DataAnnotations;

namespace fa23FinalProjectGroup14.Models
{
	//TAX is 0.0875
	public class Transaction
	{
        public const Decimal SALES_TAX_RATE = 0.0875m;

        public Int32 TransactionID { get; set; }

		public Int32 TransactionNumber { get; set; }

		public DateTime PurchaseDate { get; set; }

		public Decimal Total { get; set; } = 0;

		public Decimal SubTotal { get; set; } = 0;

        [Display(Name = "Sales Tax:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal SalesTax { get; set; } = 0;

		public Int32 NumTickets { get; set; }

		public Int32 PopcornPoints { get; set; }

		public void CalcTotals()
		{
            SalesTax = SubTotal * SALES_TAX_RATE;
            Total = SalesTax + SubTotal;
        }

		public status Status { get; set; }

		// add the navigation properties
		public AppUser User { get; set; }

		public List<TransactionDetail> TransactionDetails { get; set; }

		public Transaction()
		{
			if (TransactionDetails == null)
			{
				TransactionDetails = new List<TransactionDetail>();
			}
		}

	}
}

