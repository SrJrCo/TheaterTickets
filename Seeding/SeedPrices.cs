
using fa23FinalProjectGroup14.DAL;
using fa23FinalProjectGroup14.Models;
using fa23FinalProjectGroup14.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace fa23FinalProjectGroup14.Seeding
{

    public static class SeedPrices
    {
        public static void SeedAllPrices(AppDbContext db)
        {
            //Create a list of AddUSer models
            List<Price> AllPrices = new List<Price>();


            AllPrices.Add(new Price()
            {
                TicketType = "Special Event",
                ticketprice = 15
            });

            AllPrices.Add(new Price()
            {
                TicketType = "Matinee",
                ticketprice = 5
            });

            AllPrices.Add(new Price()
            {
                TicketType = "Discount Tuesday",
                ticketprice = 8
            });

            AllPrices.Add(new Price()
            {
                TicketType = "Weekday (Base)",
                ticketprice = 10
            });

            AllPrices.Add(new Price()
            {
                TicketType = "Weekends",
                ticketprice = 12
            });

            Int32 intPriceID = 0;

            //loop through the list to add or update the job posting
            try
            {
                foreach (Price SeedPrice in AllPrices)
                {
                    //update the counters
                    intPriceID = SeedPrice.PriceID;
                    //see if the job posting is already in the database using the UniqueIdentifier
                    Price dbPrice = db.Prices.FirstOrDefault(m => m.PriceID == SeedPrice.PriceID);

                    //if job posting is null, job posting is not in database
                    if (dbPrice == null)
                    {
                        //Add the job posting to the database
                        db.Prices.Add(SeedPrice);
                        db.SaveChanges();
                    }
                    else //the job posting is in the database - reset all fields except ID and Unique Identifier
                    {
                        dbPrice.TicketType = SeedPrice.TicketType;
                        dbPrice.ticketprice = SeedPrice.ticketprice;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) //throw error if there is a problem in the database
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the job posting with the title: ");
                msg.Append(" (intGenreID: ");
                msg.Append(intPriceID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
