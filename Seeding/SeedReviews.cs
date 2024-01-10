
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

    public static class SeedReviews
    {
        public static void SeedAllReviews(AppDbContext db)
        {
            //Create a list of AddUSer models
            List<Review> AllReviews = new List<Review>();


            AllReviews.Add(new Review()
            {
                Rating = 5.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Michelle Banks"),
                Description = "Best movie I've ever seen.",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 4.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                Description = "Not bad.",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 5.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                Description = "Changed my life",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 5.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Franco Broccolo"),
                Description = "Great family adventure movie",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 4.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Wendy Chang"),
                Description = "Good movie",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 1.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Lim Chou"),
                Description = "Worst thing I've ever seen",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 5.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                Description = "Reminded me of my summers in the NW",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 5.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Shan Dixon"),
                Description = "I love a good treasure hunt!",
                Status = "Needs Review",
            });


            AllReviews.Add(new Review()
            {
                Rating = 3.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Jim Bob Evans"),
                Description = "Meh",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 4.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                Description = "",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 4.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                Description = "",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 5.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Michelle Banks"),
                Description = "",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 5.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Franco Broccolo"),
                Description = "",
                Status = "Approved",
            });


            AllReviews.Add(new Review()
            {
                Rating = 1.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Wendy Chang"),
                Description = "Too long",
                Status = "Needs Review",
            });


            AllReviews.Add(new Review()
            {
                Rating = 2.0m,
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Lim Chou"),
                Description = "Did they really need to drag this out into its own movie?",
                Status = "Needs Review",
            });

            Int32 intReviewID = 0;

            //loop through the list to add or update the job posting
            try
            {
                foreach (Review seedReview in AllReviews)
                {
                    //update the counters
                    intReviewID = seedReview.ReviewID;
                    //see if the job posting is already in the database using the UniqueIdentifier
                    Review dbReview = db.Reviews.FirstOrDefault(m => (m.Movie == seedReview.Movie) && (m.User.FirstName + " " + m.User.LastName == seedReview.User.FullName));

                    //if job posting is null, job posting is not in database
                    if (dbReview == null)
                    {
                        //Add the job posting to the database
                        db.Reviews.Add(seedReview);
                        db.SaveChanges();
                    }
                    else //the job posting is in the database - reset all fields except ID and Unique Identifier
                    {
                        dbReview.Rating = seedReview.Rating;
                        dbReview.Description = seedReview.Description;
                        dbReview.Status = seedReview.Status;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) //throw error if there is a problem in the database
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the job posting with the title: ");
                msg.Append(" (intReviewID: ");
                msg.Append(intReviewID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
