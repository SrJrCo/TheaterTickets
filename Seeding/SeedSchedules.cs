
using fa23FinalProjectGroup14.DAL;
using fa23FinalProjectGroup14.Models;
using fa23FinalProjectGroup14.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace fa23FinalProjectGroup14.Seeding
{

    public static class SeedSchedules
    {
        public static void SeedAllSchedules(AppDbContext db)
        {
            //Create a list of AddUSer models
            List<Schedule> AllSchedules = new List<Schedule>();

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-11-23 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-23 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-23 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-23 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-23 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-23 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-23 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-11-24 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-11-23 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-24 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-24 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge"),
                StartTime = DateTime.ParseExact("2023-11-24 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-24 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-24 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-24 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-24 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-24 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-24 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-11-24 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-11-24 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-11-25 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge"),
                StartTime = DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey"),
                StartTime = DateTime.ParseExact("2023-11-25 15:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug"),
                StartTime = DateTime.ParseExact("2023-11-25 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                StartTime = DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Special Event"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-25 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-25 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Fellowship of the Ring"),
                StartTime = DateTime.ParseExact("2023-11-25 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Fellowship of the Ring")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers"),
                StartTime = DateTime.ParseExact("2023-11-25 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King"),
                StartTime = DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Special Event"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-11-26 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge"),
                StartTime = DateTime.ParseExact("2023-11-26 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey"),
                StartTime = DateTime.ParseExact("2023-11-26 15:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug"),
                StartTime = DateTime.ParseExact("2023-11-26 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                StartTime = DateTime.ParseExact("2023-11-26 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Special Event"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-26 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-26 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Fellowship of the Ring"),
                StartTime = DateTime.ParseExact("2023-11-26 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Fellowship of the Ring")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers"),
                StartTime = DateTime.ParseExact("2023-11-26 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King"),
                StartTime = DateTime.ParseExact("2023-11-26 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Special Event"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-27 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-11-27 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-27 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-27 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-27 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-27 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-27 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-27 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-27 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-11-27 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-11-27 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-28 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-28 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-11-28 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Discount Tuesday"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-28 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Discount Tuesday"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-28 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-28 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-28 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-28 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-28 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Discount Tuesday"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-28 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Discount Tuesday"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-28 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-11-28 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-11-28 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-29 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-29 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-11-29 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-29 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-29 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-29 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-29 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-29 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-29 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-29 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-29 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-11-29 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-11-29 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-30 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-30 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge"),
                StartTime = DateTime.ParseExact("2023-11-30 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-30 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-30 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-30 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-11-30 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-11-30 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-11-30 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-11-30 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-11-30 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-11-30 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-11-30 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-01 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-01 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge"),
                StartTime = DateTime.ParseExact("2023-12-01 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-01 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-01 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-01 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Special Event"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-01 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-01 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-01 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-01 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-01 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-12-01 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Special Event"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-12-01 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-12-02 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge"),
                StartTime = DateTime.ParseExact("2023-12-02 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey"),
                StartTime = DateTime.ParseExact("2023-12-02 15:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug"),
                StartTime = DateTime.ParseExact("2023-12-02 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                StartTime = DateTime.ParseExact("2023-12-02 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-02 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-02 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Fellowship of the Ring"),
                StartTime = DateTime.ParseExact("2023-12-02 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Fellowship of the Ring")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers"),
                StartTime = DateTime.ParseExact("2023-12-02 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King"),
                StartTime = DateTime.ParseExact("2023-12-02 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-12-03 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge"),
                StartTime = DateTime.ParseExact("2023-12-03 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey"),
                StartTime = DateTime.ParseExact("2023-12-03 15:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug"),
                StartTime = DateTime.ParseExact("2023-12-03 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies"),
                StartTime = DateTime.ParseExact("2023-12-03 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Special Event"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-03 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-03 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Fellowship of the Ring"),
                StartTime = DateTime.ParseExact("2023-12-03 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Fellowship of the Ring")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers"),
                StartTime = DateTime.ParseExact("2023-12-03 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekends"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King"),
                StartTime = DateTime.ParseExact("2023-12-03 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Special Event"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-04 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-04 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-12-04 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-04 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-04 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-04 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-04 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-04 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-04 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-04 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-04 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-12-04 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-12-04 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-05 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-05 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge"),
                StartTime = DateTime.ParseExact("2023-12-05 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Discount Tuesday"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-05 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Discount Tuesday"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-05 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-05 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-05 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-05 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-05 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Discount Tuesday"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-05 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Discount Tuesday"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-05 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-12-05 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-12-05 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-06 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-06 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic"),
                StartTime = DateTime.ParseExact("2023-12-06 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-06 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-06 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-06 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-06 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-06 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-06 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-06 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-06 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-12-06 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-12-06 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-07 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-07 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge"),
                StartTime = DateTime.ParseExact("2023-12-07 13:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-07 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-07 19:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-07 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 1",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7"),
                StartTime = DateTime.ParseExact("2023-12-07 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park"),
                StartTime = DateTime.ParseExact("2023-12-07 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Matinee"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty"),
                StartTime = DateTime.ParseExact("2023-12-07 13:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management"),
                StartTime = DateTime.ParseExact("2023-12-07 15:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies"),
                StartTime = DateTime.ParseExact("2023-12-07 18:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Goonies")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot"),
                StartTime = DateTime.ParseExact("2023-12-07 20:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });

            AllSchedules.Add(new Schedule()
            {
                Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show"),
                StartTime = DateTime.ParseExact("2023-12-07 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("2023-11-23 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddMinutes((db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")).Runtime),
                Theater = "Theater 2",
                Price = db.Prices.FirstOrDefault(p => p.TicketType == "Weekday (Base)"),
                SpecialEvent = false,
          });


			Int32 intScheduleID = 0;

			//		//loop through the list to add or update the job posting
			try
			{
				foreach (Schedule seedSchedule in AllSchedules)
				{
					//update the counters
					intScheduleID = seedSchedule.ScheduleID;

					//see if the job posting is already in the database using the UniqueIdentifier
					Schedule dbSchedule = db.Schedules.FirstOrDefault(m => (m.Theater == seedSchedule.Theater) && (m.Movie == seedSchedule.Movie) && m.StartTime == seedSchedule.StartTime);

					//if job posting is null, job posting is not in database
					if (dbSchedule == null)
					{
						//Add the job posting to the database
						db.Schedules.Add(seedSchedule);
						db.SaveChanges();
					}
					else //the job posting is in the database - reset all fields except ID and Unique Identifier
					{
						dbSchedule.Price = seedSchedule.Price;
						dbSchedule.SpecialEvent = seedSchedule.SpecialEvent;
						db.SaveChanges();
					}
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the job posting with the title: ");
				msg.Append(" (intScheduleID: ");
				msg.Append(intScheduleID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}

