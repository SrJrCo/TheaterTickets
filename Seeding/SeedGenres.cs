
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

    public static class SeedGenres
    {
        public static void SeedAllGenres(AppDbContext db)
        {
            //Create a list of AddUSer models
            List<Genre> AllGenres = new List<Genre>();


            AllGenres.Add(new Genre()
            {
                GenreName = "Drama"
          });


            AllGenres.Add(new Genre()
            {
                GenreName = "Action"
          });


            AllGenres.Add(new Genre()
            {
                GenreName = "Romance"
          });


            AllGenres.Add(new Genre()
            {
                GenreName = "Comedy"
          });


            AllGenres.Add(new Genre()
            {
                GenreName = "Children and Family"
          });


            AllGenres.Add(new Genre()
            {
                GenreName = "Musical"
          });


            AllGenres.Add(new Genre()
            {
                GenreName = "Horror"
          });


            AllGenres.Add(new Genre()
            {
                GenreName = "Science Fiction"
          });

    Int32 intGenreID = 0;

		//loop through the list to add or update the job posting
		try
		{
			foreach (Genre seedGenre in AllGenres)
			{
				//update the counters
				intGenreID = seedGenre.GenreID;
				//see if the job posting is already in the database using the UniqueIdentifier
				Genre dbGenre = db.Genres.FirstOrDefault(m => m.GenreID == seedGenre.GenreID);

					//if job posting is null, job posting is not in database
					if (dbGenre == null)
					{
						//Add the job posting to the database
						db.Genres.Add(seedGenre);
						db.SaveChanges();
					}
					else //the job posting is in the database - reset all fields except ID and Unique Identifier
					{
                        dbGenre.GenreName = seedGenre.GenreName;
						db.SaveChanges();
					}
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the job posting with the title: ");
				msg.Append(" (intGenreID: ");
				msg.Append(intGenreID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}
