using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Department.DAL
{
    public class RewardSqlDAO : IRewardDAO
    {
        private readonly string connectionString;

        public RewardSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddReward(Reward reward)
        {
            if (reward == null)
            {
                throw new ArgumentNullException("Reward is null");
            }
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "AddReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@title", reward.Title);
                command.Parameters.AddWithValue("@description", reward.Description);

                connection.Open();

                command.ExecuteScalar();

                connection.Close();
            }
            
        }

        public void ChangeReward(Reward reward)
        {
            if (reward == null)
            {
                throw new ArgumentNullException("Reward is null");
            }
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "ChangeReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@Id", reward.RewardId);
                command.Parameters.AddWithValue("@title", reward.Title);

                connection.Open();

                command.ExecuteScalar();

            }

        }

        public void RemoveReward(Reward reward)
        {
            if (reward == null)
            {
                throw new ArgumentNullException("Reward is null");
            }
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "RemoveReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", reward.RewardId);

                connection.Open();

                command.ExecuteScalar();

                connection.Close();
            }
        }

        public IEnumerable<Reward> GetReward()
        {
            List<Reward> rewards = new List<Reward>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string title = (string)reader["Title"];
                    string description = (string)reader["Description"];

                    yield return new Reward()
                    {
                        Title = title,
                        Description = description
                    };
                }
            }


        }

    }
}
