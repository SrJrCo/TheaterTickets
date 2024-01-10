
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

    public static class SeedTransactionDetails
    {
        public static void SeedAllTransactionDetails(AppDbContext db)
        {
            //Create a list of AddUSer models
            List<TransactionDetail> AllTransactionDetails = new List<TransactionDetail>();

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
          });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 3,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 4,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 5,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 6,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 7,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 8,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 9,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 1),
                PurchaseID = 10,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A1",
                SeniorDiscount = true,
                TuesdayDiscount = false,
                TicketPrice = 10,
                PopcornPointsGainedOrLost = 10,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A2",
                SeniorDiscount = true,
                TuesdayDiscount = false,
                TicketPrice = 10,
                PopcornPointsGainedOrLost = 10,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 3,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 4,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 5,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 6,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 7,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 8,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 9,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 2),
                PurchaseID = 10,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Secret Life of Walter Mitty" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 16:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 3),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 3),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 4),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 4),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Jurassic Park" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-23 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 5),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 6),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A2",
                SeniorDiscount = true,
                TuesdayDiscount = false,
                TicketPrice = 10,
                PopcornPointsGainedOrLost = 10,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 7),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 8),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 9),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 10),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 11),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 12),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 13),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 14),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 15),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 16),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 17),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 18),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 19),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 20),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 21),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Goonies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-24 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 22),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "D1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 23),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 24),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 25),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 26),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 27),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 28),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 29),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 30),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 31),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 32),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 33),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 34),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 35),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 36),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 37),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 38),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "The Hobbit: The Battle of Five Armies" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 21:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 39),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "D1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 39),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 39),
                PurchaseID = 3,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 40),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 40),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 40),
                PurchaseID = 3,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 40),
                PurchaseID = 4,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 40),
                PurchaseID = 5,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 40),
                PurchaseID = 6,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 41),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 41),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 42),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 42),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 43),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 43),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 43),
                PurchaseID = 3,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 43),
                PurchaseID = 4,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Lord of the Rings: The Return of the King" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 19:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 15,
                PopcornPointsGainedOrLost = 15,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 44),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Titanic: Jack's Revenge" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 44),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Titanic: Jack's Revenge" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 44),
                PurchaseID = 3,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Titanic: Jack's Revenge" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 45),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Titanic: Jack's Revenge" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 46),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Titanic: Jack's Revenge" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 46),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Titanic: Jack's Revenge" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 47),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Titanic: Jack's Revenge" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 47),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Titanic: Jack's Revenge" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 48),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Titanic: Jack's Revenge" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-25 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 49),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Toy Story 7" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-11-25 09:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 12,
                PopcornPointsGainedOrLost = 12,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 50),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Fast and Furious 18: Anger Management" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "A4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 50),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Fast and Furious 18: Anger Management" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E1",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 50),
                PurchaseID = 3,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Fast and Furious 18: Anger Management" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E2",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 50),
                PurchaseID = 4,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Fast and Furious 18: Anger Management" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 50),
                PurchaseID = 5,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Fast and Furious 18: Anger Management" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 50),
                PurchaseID = 6,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Fast and Furious 18: Anger Management" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "E5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 50),
                PurchaseID = 7,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Fast and Furious 18: Anger Management" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 50),
                PurchaseID = 8,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Fast and Furious 18: Anger Management" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 50),
                PurchaseID = 9,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Fast and Furious 18: Anger Management" && s.Theater == "Theater 1" && s.StartTime == (DateTime.ParseExact("2023-11-27 11:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "B5",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 5,
                PopcornPointsGainedOrLost = 5,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 51),
                PurchaseID = 1,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Rocky Horror Picture Show" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-12-04 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C3",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 0,
                PopcornPointsGainedOrLost = -100,
            });

            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(t => t.TransactionID == 51),
                PurchaseID = 2,
                Schedule = db.Schedules.FirstOrDefault(s => s.Movie.Title == "Rocky Horror Picture Show" && s.Theater == "Theater 2" && s.StartTime == (DateTime.ParseExact("2023-12-04 22:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))),
                Seat = "C4",
                SeniorDiscount = false,
                TuesdayDiscount = false,
                TicketPrice = 0,
                PopcornPointsGainedOrLost = -100,
            });


            Int32 intTransactionDetailID = 0;

			//		//loop through the list to add or update the job posting
			try
			{
				foreach (TransactionDetail seedTransactionDetail in AllTransactionDetails)
				{
                    //System.Diagnostics.Debug.Print($"{seedTransactionDetail.Movie.Title}");
                    //update the counters
                    intTransactionDetailID = seedTransactionDetail.TransactionDetailID;

					//see if the job posting is already in the database using the UniqueIdentifier
					TransactionDetail dbTransactionDetail = db.TransactionDetails.FirstOrDefault(m => m.Schedule == seedTransactionDetail.Schedule && m.Seat == seedTransactionDetail.Seat);

					//if job posting is null, job posting is not in database
					if (dbTransactionDetail == null)
					{
						//Add the job posting to the database
						db.TransactionDetails.Add(seedTransactionDetail);
						db.SaveChanges();
					}
					else //the job posting is in the database - reset all fields except ID and Unique Identifier
					{
                        dbTransactionDetail.Seat = seedTransactionDetail.Seat;
                        dbTransactionDetail.SeniorDiscount = seedTransactionDetail.SeniorDiscount;
                        dbTransactionDetail.TuesdayDiscount = seedTransactionDetail.TuesdayDiscount;
                        dbTransactionDetail.PopcornPointsGainedOrLost = seedTransactionDetail.PopcornPointsGainedOrLost;
                        db.SaveChanges();
					}
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the job posting with the title: ");
				msg.Append(" (intTransactionDetailID: ");
				msg.Append(intTransactionDetailID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}



