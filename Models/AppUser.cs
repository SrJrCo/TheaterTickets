using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace fa23FinalProjectGroup14.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name")]
        [Required]
        public String FirstName { get; set; }

        [Required]
        [Display(Name= "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "User Name:")]
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }

        // email address is auto
        // phone number is auto
        // password is auto
        public DateTime Birthday { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public StateType State { get; set; }


        public String ZipCode { get; set; }

        public Int32 PopcornPoints { get; set; } = 0;

        //FOR EMPLOYEE:
        public EmployeeStatus EmployeeStatus { get; set; }

        //Navigation Props
        public List<Review> Reviews { get; set; }

        public List<Transaction> Transactions { get; set; }

        public AppUser()
        {
            if (Transactions == null)
            {
                Transactions = new List<Transaction>();
            }
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }
        }
    }
}
