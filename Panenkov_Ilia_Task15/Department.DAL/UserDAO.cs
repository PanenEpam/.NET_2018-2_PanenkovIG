using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public class UserDAO : IUserDAO
    {
        private int id;
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            user.UserId = id++;
            users.Add(user);
        }

        public void ChangeUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user is null");
            }
            User chenge_user = users.First(ur => ur.UserId == user.UserId);
            chenge_user = user;
        }

        public void RemoveUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user is null");
            }
            users.Remove(user);
        }

        public IEnumerable<User> GetUser()
        {
            return users;
        }  
    }
}
