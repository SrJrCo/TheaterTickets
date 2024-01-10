
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

    public static class SeedCustomers
    {
        public async static Task<IdentityResult> SeedAllCustomers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUSer models
            List<AddUserModel> AllUsers = new List<AddUserModel>();



            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "cbaker@example.com",
                    Email = "cbaker@example.com",

                    //add the additional fields:
                    FirstName = "Christopher",
                    LastName = "Baker",
                    
                    Birthday = DateTime.ParseExact("1945-08-02 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "1 David Park",
                    City = "Austin",
                    State = StateType.TX,
                    ZipCode = "78705",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "bookworm",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "banker@longhorn.net",
                    Email = "banker@longhorn.net",

                    //add the additional fields:
                    FirstName = "Michelle",
                    LastName = "Banks",
                    
                    Birthday = DateTime.ParseExact("2000-11-18 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "10117 Swallow Road",
                    City = "Austin",
                    State = StateType.TX,
                    ZipCode = "78712",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "aclfest2017",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "franco@example.com",
                    Email = "franco@example.com",

                    //add the additional fields:
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    
                    Birthday = DateTime.ParseExact("2002-05-02 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "21344 Marcy Avenue",
                    City = "Austin",
                    State = StateType.TX,
                    ZipCode = "78786",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "aggies",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "wchang@example.com",
                    Email = "wchang@example.com",

                    //add the additional fields:
                    FirstName = "Wendy",
                    LastName = "Chang",
                    
                    Birthday = DateTime.ParseExact("1955-08-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "894 Kim Junction",
                    City = "Eagle Pass",
                    State = StateType.TX,
                    ZipCode = "78852",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "alaskaboy",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "limchou@gogle.com",
                    Email = "limchou@gogle.com",

                    //add the additional fields:
                    FirstName = "Lim",
                    LastName = "Chou",
                    
                    Birthday = DateTime.ParseExact("2009-04-06 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "703 Anthes Lane",
                    City = "Austin",
                    State = StateType.TX,
                    ZipCode = "78729",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "allyrally",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "shdixon@aoll.com",
                    Email = "shdixon@aoll.com",

                    //add the additional fields:
                    FirstName = "Shan",
                    LastName = "Dixon",
                    
                    Birthday = DateTime.ParseExact("1989-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "45927 Forest Run Trail",
                    City = "Georgetown",
                    State = StateType.TX,
                    ZipCode = "78628",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "Anchorage",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "j.b.evans@aheca.org",
                    Email = "j.b.evans@aheca.org",

                    //add the additional fields:
                    FirstName = "Jim Bob",
                    LastName = "Evans",
                    
                    Birthday = DateTime.ParseExact("2001-10-08 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "51 Miller Park",
                    City = "Austin",
                    State = StateType.TX,
                    ZipCode = "78705",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "billyboy",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "feeley@penguin.org",
                    Email = "feeley@penguin.org",

                    //add the additional fields:
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    
                    Birthday = DateTime.ParseExact("1966-06-19 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "80686 Ryan Terrace",
                    City = "Austin",
                    State = StateType.TX,
                    ZipCode = "78704",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "bunnyhop",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tfreeley@minnetonka.ci.us",
                    Email = "tfreeley@minnetonka.ci.us",

                    //add the additional fields:
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    
                    Birthday = DateTime.ParseExact("1996-09-12 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "97327 Express Avenue",
                    City = "College Station",
                    State = StateType.TX,
                    ZipCode = "77840",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "dustydusty",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mgarcia@gogle.com",
                    Email = "mgarcia@gogle.com",

                    //add the additional fields:
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    
                    Birthday = DateTime.ParseExact("2002-06-17 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "1 Arrowood Road",
                    City = "Austin",
                    State = StateType.TX,
                    ZipCode = "78756",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "gowest",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",

                    //add the additional fields:
                    FirstName = "Charles",
                    LastName = "Haley",
                    
                    Birthday = DateTime.ParseExact("1998-05-15 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "5035 Dayton Court",
                    City = "Austin",
                    State = StateType.TX,
                    ZipCode = "78746",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "hampton1",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jeffh@sonic.com",
                    Email = "jeffh@sonic.com",

                    //add the additional fields:
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    
                    Birthday = DateTime.ParseExact("2003-04-08 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "90461 Evergreen Place",
                    City = "Austin",
                    State = StateType.TX,
                    ZipCode = "78756",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "hickhickup",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "wjhearniii@umich.org",
                    Email = "wjhearniii@umich.org",

                    //add the additional fields:
                    FirstName = "John",
                    LastName = "Hearn",
                    
                    Birthday = DateTime.ParseExact("2000-09-15 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "973 Stephen Alley",
                    City = "Liberty",
                    State = StateType.TX,
                    ZipCode = "77575",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "ingram2015",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ahick@yaho.com",
                    Email = "ahick@yaho.com",

                    //add the additional fields:
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    
                    Birthday = DateTime.ParseExact("1980-05-07 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "80319 Forster Parkway",
                    City = "San Antonio",
                    State = StateType.TX,
                    ZipCode = "78203",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "jhearn22",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ingram@jack.com",
                    Email = "ingram@jack.com",

                    //add the additional fields:
                    FirstName = "Brad",
                    LastName = "White",
                    
                    Birthday = DateTime.ParseExact("1986-02-06 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "96 Stang Hill",
                    City = "New Braunfels",
                    State = StateType.TX,
                    ZipCode = "78132",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "joejoejoe",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "toddj@yourmom.com",
                    Email = "toddj@yourmom.com",

                    //add the additional fields:
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    
                    Birthday = DateTime.ParseExact("1975-08-29 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "23726 Main Crossing",
                    City = "New York",
                    State = StateType.NY,
                    ZipCode = "10101",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "jrod2017",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "thequeen@aska.net",
                    Email = "thequeen@aska.net",

                    //add the additional fields:
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    
                    Birthday = DateTime.ParseExact("2001-01-29 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "6299 Moland Alley",
                    City = "Lockhart",
                    State = StateType.TX,
                    ZipCode = "78644",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "longhorns",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "linebacker@gogle.com",
                    Email = "linebacker@gogle.com",

                    //add the additional fields:
                    FirstName = "Erik",
                    LastName = "Lineback",
                    
                    Birthday = DateTime.ParseExact("2004-05-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "6 Truax Street",
                    City = "Kingwood",
                    State = StateType.TX,
                    ZipCode = "77325",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "louielouie",
                RoleName = "Employee"
          });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "elowe@netscare.net",
                    Email = "elowe@netscare.net",

                    //add the additional fields:
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    
                    Birthday = DateTime.ParseExact("2001-12-27 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "50883 Heath Park",
                    City = "Beverly Hills",
                    State = StateType.CA,
                    ZipCode = "90210",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "martin1234",
                RoleName = "Employee"
          });

            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + errorFlag, ex);
            }

            return result;
        }
    }
}
