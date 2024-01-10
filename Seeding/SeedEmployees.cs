
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

    public static class SeedEmployees
    {
        public async static Task<IdentityResult> SeedAllEmployees(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUSer models
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "michelle@example.com",
                    Email = "michelle@example.com",

                    //add the additional fields:
                    FirstName = "Michelle",
                    LastName = "Banks",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "jVb0Z6",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "toddy@aool.com",
                    Email = "toddy@aool.com",

                    //add the additional fields:
                    FirstName = "Todd",
                    LastName = "Jacobs",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "1PnrBV",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",

                    //add the additional fields:
                    FirstName = "Ernest",
                    LastName = "Lowe",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "v3n5AV",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mclarence@aool.com",
                    Email = "mclarence@aool.com",

                    //add the additional fields:
                    FirstName = "Clarence",
                    LastName = "Martin",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "zBLq3S",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "nelson.Kelly@aool.com",
                    Email = "nelson.Kelly@aool.com",

                    //add the additional fields:
                    FirstName = "Kelly",
                    LastName = "Nelson",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "FSb8rA",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",

                    //add the additional fields:
                    FirstName = "Megan",
                    LastName = "Rhodes",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "1xVfHp",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "sheff44@ggmail.com",
                    Email = "sheff44@ggmail.com",

                    //add the additional fields:
                    FirstName = "Martin",
                    LastName = "Sheffield",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "4XKLsd",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",

                    //add the additional fields:
                    FirstName = "Peter",
                    LastName = "Stump",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "1XdmSV",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "yhuik9.Taylor@aool.com",
                    Email = "yhuik9.Taylor@aool.com",

                    //add the additional fields:
                    FirstName = "Rachel",
                    LastName = "Taylor",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "9yhFS3",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tuck33@ggmail.com",
                    Email = "tuck33@ggmail.com",

                    //add the additional fields:
                    FirstName = "Clent",
                    LastName = "Tucker",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "I6BgsS",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "taylordjay@aool.com",
                    Email = "taylordjay@aool.com",

                    //add the additional fields:
                    FirstName = "Allison",
                    LastName = "Taylor",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "Vjb1wI",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jojoe@ggmail.com",
                    Email = "jojoe@ggmail.com",

                    //add the additional fields:
                    FirstName = "Joe",
                    LastName = "Nguyen",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "xI8Brg",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "hicks43@ggmail.com",
                    Email = "hicks43@ggmail.com",

                    //add the additional fields:
                    FirstName = "Anthony",
                    LastName = "Hicks",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "s33WOz",
                RoleName = "Employee"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",

                    //add the additional fields:
                    FirstName = "Bill",
                    LastName = "O'Reilly",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Employee Street",
                    City = "Emp City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.Active,
                },
                Password = "pS2OJh",
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
