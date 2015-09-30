using Microsoft.AspNet.Mvc;

namespace Lisa.Mugshot.WebApi
{
    [Route("profiles")]
    public class ProfilesController
    {
        public IActionResult Get()
        {
            var profiles = _db.FetchProfiles();
            return new ObjectResult(profiles);
        }

        private readonly IDatabase _db = new DummyDatabase();
    }
}