using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Department.DAL
{
    public class UserSqlDAO : IUserDAO
    {
        private readonly string connectionString;

        public UserSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User is null");
            }
        
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@Id", user.UserId);
                command.Parameters.AddWithValue("@irstName", user.FirstName);
                command.Parameters.AddWithValue("@secondName", user.LastName);
                command.Parameters.AddWithValue("@birthdate", user.Birthday);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                foreach (var reward in user.UserRewarList)
                {
                    dataTable.Rows.Add(reward.RewardId);
                }

                command.Parameters.AddWithValue("@Id",dataTable).SqlDbType = SqlDbType.Structured;

                connection.Open();
                command.ExecuteScalar();
                connection.Close();
            }
        }

        public void ChangeUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User is null");
            }

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@Id", user.UserId);
                command.Parameters.AddWithValue("@irstName", user.FirstName);
                command.Parameters.AddWithValue("@secondName", user.LastName);
                command.Parameters.AddWithValue("@birthdate", user.Birthday);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                foreach (var reward in user.UserRewarList)
                {
                    dataTable.Rows.Add(reward.RewardId);
                }

                command.Parameters.AddWithValue("@Id", dataTable).SqlDbType = SqlDbType.Structured;

                connection.Open();
                command.ExecuteScalar();
                connection.Close();
            }
        }


        public void RemoveUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User is null");
            }
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "RemoveUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@Id", user.UserId);

                connection.Open();

                command.ExecuteScalar();

                connection.Close();
            }
        }

        public IEnumerable<User> GetUser()
        {
            List<User> users = new List<User>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "GetUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            User user = new User
                            {
                                UserId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Birthday = reader.GetDateTime(3)
                            };

                            var rewards = GetUserRewards(user.UserId);

                            user.UserRewarList = rewards.ToList();

                            users.Add(user);
                        }
                    }

                }
                //connection.Close();
            }
            return users;
        }

        private bool AddUsersRewards(int userId, int rewardId)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "SetUserReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@rewardId", rewardId);
                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();

                command.ExecuteScalar();

                connection.Close();
            }
            return true;
        }

        private List<Reward> GetUserRewards(int id)
        {
            List<Reward> rewards = new List<Reward>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "GetUsersAwards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@ID", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                       Reward reward = new Reward()
                        {
                            RewardId = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Description = reader.GetString(2)
                        };
                        rewards.Add(reward);
                    }
                }

                connection.Close();
            }
            return rewards;
        }
    }
}
