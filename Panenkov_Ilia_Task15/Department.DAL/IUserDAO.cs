using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Department.DAL
{
    public interface IUserDAO
    {
        void AddUser(User user);
        void ChangeUser(User user);
        void RemoveUser(User user);
        IEnumerable<User> GetUser();
    }
}
