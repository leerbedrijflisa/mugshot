using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lisa.Mugshot.WebApi
{
    internal class DummyDatabase : IDatabase
    {
        public IEnumerable<Profile> FetchProfiles()
        {
            return new Profile[]
            {
                new Profile { Name = "Peter Snoek", Crime = "tardiness", Reward = 150000 },
                new Profile { Name = "Martijn van Cooten", Crime = "loitering", Reward = 100000 },
                new Profile { Name = "Maarten Nouwen", Crime = "interrupting", Reward = 175000 }
            };
        }
    }
}