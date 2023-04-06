using FilmAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace FilmAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MovieController : Controller
    {
        private MovieDbContext context;
        public MovieController(MovieDbContext temp)
        {
            context = temp;
        }
        public IEnumerable<Movie> Get()
        {
            var x = context.Movies.ToArray();

            return context.Movies.ToArray();
        }
    }
}
