using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Department.DAL;
using System.ComponentModel.DataAnnotations;

namespace Department.BL
{
    public class Logic
    {
        private readonly IUserDAO usersDAO;
        private readonly IRewardDAO rewardDAO;
        readonly string key = ConfigurationManager.AppSettings["context"];

        public Logic()
        {
            if (key == "list")
            {
                usersDAO = new UserDAO();
                rewardDAO = new RewardDAO();
            }
            if (key == "adonet")
            {
                var connectionStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                usersDAO = new UserSqlDAO(connectionStr);
                rewardDAO = new RewardSqlDAO(connectionStr);
            }
        }

        #region Users Metods
        public void AddUser(string firstName, string lastName, DateTime birthdate, List<Reward> rewards)
        {
            User user = new User { FirstName = firstName, LastName = lastName, Birthday = birthdate.Date, UserRewarList = rewards };

            AddUser(user);
        }
        public void AddUser(User user)
        {
            if (user == null)
            {
                throw new AggregateException("user is null");
            }
            usersDAO.AddUser(user);
        }
        public void ChangeUser(User user)
        {
            usersDAO.ChangeUser(user);
        }
        public void RemoveUser(User user)
        {
            usersDAO.RemoveUser(user);
        }
        public IEnumerable<User> GetUsers()
        {
            return usersDAO.GetUser();
        }
        public User GetUserById(int id)
        {
            IEnumerable<User> users = usersDAO.GetUser();
            foreach  (var item  in users)
            {
                if (item.UserId == id)
                {
                    return item;
                }
            }
            throw new Exception("user not found");
        }

        public IEnumerable<User> SortUserByFirstNameAsc() => (from u in GetUsers()
                                                       orderby u.FirstName ascending
                                                       select u);
        public IEnumerable<User> SortUserByFirstNameDes()
        {
            return (from u in GetUsers()
                    orderby u.FirstName descending
                    select u).ToList();
        }
        public IEnumerable<User> SortUserByLastNameAsc()
        {
            return (from u in GetUsers()
                    orderby u.LastName ascending
                    select u);
        }
        public IEnumerable<User> SortUserByLastNameDes()
        {
            return (from u in GetUsers()
                    orderby u.LastName descending
                    select u).ToList();
        }
        public IEnumerable<User> SortUserByBirthdayAsc()
        {
            return (from u in GetUsers()
                    orderby u.Birthday ascending
                    select u);
        }
        public  IEnumerable<User> SortUserByBirthdayDes()
        {
            return (from u in GetUsers()
                    orderby u.Birthday descending
                    select u).ToList();
        }
        #endregion

        #region Rewards Metods
        public void AddReward(string title, string description)
        {
            Reward reward = new Reward { Title = title, Description = description };
            AddReward(reward);
        }
        public void AddReward(Reward reward)
        {
            if (reward == null)
            {
                throw new ArgumentException("Reward is null");
            }
            rewardDAO.AddReward(reward);
        }
        public void ChangeReward(Reward reward)
        {
            rewardDAO.ChangeReward(reward);
        }
        public void RemoveReward(Reward reward)
        {
            rewardDAO.RemoveReward(reward);
        }
        public IEnumerable<Reward> GetRewards()
        {
            return rewardDAO.GetReward();
        }

        public List<Reward> SortRewardByTitleAsc()
        {
            return (from r in GetRewards()
                    orderby r.Title ascending
                    select r).ToList();
        }
        public List<Reward> SortRewardByTitleDes()
        {
            return (from R in GetRewards()
                    orderby R.Title descending
                    select R).ToList();
        }
        public List<Reward> SortRewardByDescriptionAsc()
        {
            return (from r in GetRewards()
                    orderby r.Description ascending
                    select r).ToList();
        }
        public List<Reward> SortRewardByDescriptionDes()
        {
            return (from r in GetRewards()
                    orderby r.Description descending
                    select r).ToList();
        }
        #endregion
    }
}
