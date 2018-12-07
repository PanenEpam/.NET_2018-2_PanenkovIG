using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IRewardDAO
    {
        void AddReward(Reward reward);
        void ChangeReward(Reward reward);
        void RemoveReward(Reward reward);
        IEnumerable<Reward> GetReward();
    }
}
