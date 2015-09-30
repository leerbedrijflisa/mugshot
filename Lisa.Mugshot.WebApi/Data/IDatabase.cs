using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lisa.Mugshot.WebApi
{
    internal interface IDatabase
    {
        IEnumerable<Profile> FetchProfiles();
    }
}
