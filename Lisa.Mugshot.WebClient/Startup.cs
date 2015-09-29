using Microsoft.AspNet.Builder;

namespace Lisa.Mugshot.WebClient
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // Note that you must call UseDefaultFiles() before UseStaticFiles(), otherwise
            // UseDefaultFiles() doesn't work.
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}