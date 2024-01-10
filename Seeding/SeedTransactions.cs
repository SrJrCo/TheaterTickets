
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

    public static class SeedTransactions
    {
        public static void SeedAllTransactions(AppDbContext db)
        {
            //Create a list of AddUSer models
            List<Transaction> AllTransactions = new List<Transaction>();


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Michelle Banks"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 54.38m,
                SubTotal = 50.00m,
                SalesTax = 4.38m,
                NumTickets = 10,
                PopcornPoints = 50,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                PurchaseDate = DateTime.ParseExact("2023-11-05 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 126.15m,
                SubTotal = 116.00m,
                SalesTax = 10.15m,
                NumTickets = 10,
                PopcornPoints = 116,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 10.88m,
                SubTotal = 10.00m,
                SalesTax = 0.88m,
                NumTickets = 2,
                PopcornPoints = 10,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Michelle Banks"),
                PurchaseDate = DateTime.ParseExact("2023-11-14 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Franco Broccolo"),
                PurchaseDate = DateTime.ParseExact("2023-11-05 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Wendy Chang"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 10.88m,
                SubTotal = 10.00m,
                SalesTax = 0.88m,
                NumTickets = 1,
                PopcornPoints = 10,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Lim Chou"),
                PurchaseDate = DateTime.ParseExact("2023-11-14 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Shan Dixon"),
                PurchaseDate = DateTime.ParseExact("2023-11-05 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Jim Bob Evans"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Lou Ann Feeley"),
                PurchaseDate = DateTime.ParseExact("2023-11-14 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Victoria Lawrence"),
                PurchaseDate = DateTime.ParseExact("2023-11-05 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Erik Lineback"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Cancelled,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Ernest Lowe"),
                PurchaseDate = DateTime.ParseExact("2023-11-14 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Michelle Banks"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Michelle Banks"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Franco Broccolo"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Wendy Chang"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Lim Chou"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Shan Dixon"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Cancelled,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Jim Bob Evans"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Lou Ann Feeley"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Victoria Lawrence"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Erik Lineback"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Cancelled,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Ernest Lowe"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 16.31m,
                SubTotal = 15.00m,
                SalesTax = 1.31m,
                NumTickets = 1,
                PopcornPoints = 15,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 32.62m,
                SubTotal = 30.00m,
                SalesTax = 2.62m,
                NumTickets = 2,
                PopcornPoints = 30,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 97.88m,
                SubTotal = 90.00m,
                SalesTax = 7.88m,
                NumTickets = 6,
                PopcornPoints = 90,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Michelle Banks"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 32.62m,
                SubTotal = 30.00m,
                SalesTax = 2.62m,
                NumTickets = 2,
                PopcornPoints = 30,
                Status = status.Cancelled,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Jim Bob Evans"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 32.62m,
                SubTotal = 30.00m,
                SalesTax = 2.62m,
                NumTickets = 2,
                PopcornPoints = 30,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Lou Ann Feeley"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 65.25m,
                SubTotal = 60.00m,
                SalesTax = 5.25m,
                NumTickets = 4,
                PopcornPoints = 60,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 39.15m,
                SubTotal = 36.00m,
                SalesTax = 3.15m,
                NumTickets = 3,
                PopcornPoints = 36,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Victoria Lawrence"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Franco Broccolo"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 26.10m,
                SubTotal = 24.00m,
                SalesTax = 2.10m,
                NumTickets = 2,
                PopcornPoints = 24,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Wendy Chang"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 21.75m,
                SubTotal = 20.00m,
                SalesTax = 1.75m,
                NumTickets = 2,
                PopcornPoints = 20,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Christopher Baker"),
                PurchaseDate = DateTime.ParseExact("2023-11-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 10.88m,
                SubTotal = 10.00m,
                SalesTax = 0.88m,
                NumTickets = 1,
                PopcornPoints = 10,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Lim Chou"),
                PurchaseDate = DateTime.ParseExact("2023-11-15 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 13.05m,
                SubTotal = 12.00m,
                SalesTax = 1.05m,
                NumTickets = 1,
                PopcornPoints = 12,
                Status = status.Purchased,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Jim Bob Evans"),
                PurchaseDate = DateTime.ParseExact("2023-11-24 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 48.94m,
                SubTotal = 45.00m,
                SalesTax = 3.94m,
                NumTickets = 9,
                PopcornPoints = 45,
                Status = status.Cancelled,
          });


            AllTransactions.Add(new Transaction()
            {
                TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextTransactionNumber(db),
                User = db.Users.FirstOrDefault(c => c.FirstName + " " + c.LastName == "Brad White"),
                PurchaseDate = DateTime.ParseExact("2023-11-26 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Total = 0.00m,
                SubTotal = 0.00m,
                SalesTax = 0.00m,
                NumTickets = 2,
                PopcornPoints = -200,
                Status = status.Purchased,
          });

    Int32 intTransactionID = 0;

		//loop through the list to add or update the job posting
		try
		{
			foreach (Transaction seedTransaction in AllTransactions)
			{
				//update the counters
				intTransactionID = seedTransaction.TransactionID;
				//see if the job posting is already in the database using the UniqueIdentifier
				Transaction dbTransaction = db.Transactions.FirstOrDefault(m => (m.TransactionID == seedTransaction.TransactionID) && (m.User.FirstName + " " + m.User.LastName == seedTransaction.User.FullName));

					//if job posting is null, job posting is not in database
					if (dbTransaction == null)
					{
						//Add the job posting to the database
						db.Transactions.Add(seedTransaction);
						db.SaveChanges();
					}
					else //the job posting is in the database - reset all fields except ID and Unique Identifier
					{
                        dbTransaction.Total = seedTransaction.Total;
                        dbTransaction.SubTotal = seedTransaction.SubTotal;
                        dbTransaction.SalesTax = seedTransaction.SalesTax;
                        dbTransaction.NumTickets = seedTransaction.NumTickets;
                        dbTransaction.PopcornPoints = seedTransaction.PopcornPoints;
                        dbTransaction.Status = seedTransaction.Status;
						db.SaveChanges();
					}
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the job posting with the title: ");
				msg.Append(" (intTransactionID: ");
				msg.Append(intTransactionID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}
