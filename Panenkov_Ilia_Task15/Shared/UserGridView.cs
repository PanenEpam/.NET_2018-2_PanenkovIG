using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class UserGridView
    {
        private DateTime birthdate;

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday
        {
            get
            {
                return birthdate;
            }
            set
                {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Incorrect Birthday");
                }

                if (value < new DateTime(1868, 1, 1))
                {
                    throw new ArgumentException("Incorrect Birthday");
                }
                birthdate = value;
            }
        }
        public int Age {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - Birthday.Year;
                if (Birthday > now.AddYears(-age))
                    age--;
                return age;
            }
        }
        public List<string> UserListrRewards { get; set; }

        public UserGridView(string firstName, string lastName, DateTime birthdata, List<string> userListReward)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthdata;
            UserListrRewards = userListReward;
        }

        public UserGridView(User user)
        {
            // create userGrid from user.
        }
    }
}
