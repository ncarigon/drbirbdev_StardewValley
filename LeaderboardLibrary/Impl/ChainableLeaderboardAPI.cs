using System.Collections.Generic;

namespace LeaderboardLibrary
{
    public abstract class ChainableLeaderboardAPI : ILeaderboardAPI
    {
        public abstract ILeaderboardAPI Delegate { get; }

        public virtual int GetLocalRank(string stat)
        {
            return Delegate.GetLocalRank(stat);
        }

        public virtual List<Dictionary<string, string>> GetLocalTopN(string stat, int count)
        {
            return Delegate.GetLocalTopN(stat, count);
        }

        public virtual Dictionary<string, string> GetPersonalBest(string stat)
        {
            return Delegate.GetPersonalBest(stat);
        }

        public virtual int GetRank(string stat)
        {
            return Delegate.GetRank(stat);
        }

        public virtual List<Dictionary<string, string>> GetTopN(string stat, int count)
        {
            return Delegate.GetTopN(stat, count);
        }

        public virtual bool RefreshCache(string stat)
        {
            return Delegate.RefreshCache(stat);
        }

        public virtual bool UploadScore(string stat, int score)
        {
            return Delegate.UploadScore(stat, score);
        }
    }
}
