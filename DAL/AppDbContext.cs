using System;
using Microsoft.EntityFrameworkCore;

using fa23FinalProjectGroup14.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace fa23FinalProjectGroup14.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TransactionDetail> TransactionDetails { get; set; }

    }
}
