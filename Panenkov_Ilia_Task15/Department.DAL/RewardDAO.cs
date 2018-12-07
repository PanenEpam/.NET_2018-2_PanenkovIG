using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public class RewardDAO : IRewardDAO
    {
        private int id;
        private List<Reward> rewards = new List<Reward>();

        public void AddReward(Reward reward)
        {
            reward.RewardId = id++;
            rewards.Add(reward);
        }

        public void ChangeReward(Reward reward)
        {
            if (reward == null)
            {
                throw new ArgumentNullException("Reward is null");
            }
            Reward chenge_reward = rewards.First(rew => rew.RewardId == reward.RewardId);
            chenge_reward = reward;
        }

        public void RemoveReward(Reward reward)
        {
            if (reward == null)
            {
                throw new ArgumentNullException("Reward is null");
            }
            rewards.Remove(reward);
        }

        public IEnumerable<Reward> GetReward()
        {
            return rewards;
        }

    }
}
