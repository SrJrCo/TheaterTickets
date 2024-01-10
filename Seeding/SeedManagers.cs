
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

    public static class SeedManagers
    {
        public async static Task<IdentityResult> SeedAllManagers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUSer models
            List<AddUserModel> AllUsers = new List<AddUserModel>();



            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",

                    //add the additional fields:
                    FirstName = "Allen",
                    LastName = "Rogers",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Manager Street",
                    City = "Man City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "3wCynC",
                RoleName = "Manager"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "captain@enterprise.net",
                    Email = "captain@enterprise.net",

                    //add the additional fields:
                    FirstName = "Jean Luc",
                    LastName = "Picard",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Manager Street",
                    City = "Man City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "Pbon0r",
                RoleName = "Manager"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "slayer@onegirl.net",
                    Email = "slayer@onegirl.net",

                    //add the additional fields:
                    FirstName = "Buffy",
                    LastName = "Summers",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Manager Street",
                    City = "Man City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "jW5fPP",
                RoleName = "Manager"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "liz@ggmail.com",
                    Email = "liz@ggmail.com",

                    //add the additional fields:
                    FirstName = "Elizabeth",
                    LastName = "Markham",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Manager Street",
                    City = "Man City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "0QyilL",
                RoleName = "Manager"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "twin@deservedbetter.com",
                    Email = "twin@deservedbetter.com",

                    //add the additional fields:
                    FirstName = "Fred",
                    LastName = "Weasley",

                    Birthday = DateTime.ParseExact("2000-10-10 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                    Street = "Manager Street",
                    City = "Man City",
                    State = StateType.TX,
                    ZipCode = "11101",
                    EmployeeStatus = EmployeeStatus.NotEmployee,
                },
                Password = "atLm6W",
                RoleName = "Manager"
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
