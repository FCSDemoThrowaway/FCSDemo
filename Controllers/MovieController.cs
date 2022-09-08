using FCSDemo.Models;
using FCSDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace FCSDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService _movieService { get; set; }

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet(Name ="Get By Movie Id")]
        public Movie Get(int id)
        {
            return _movieService.GetMovieById(id);
        }

        [HttpGet(Name = "Get All (Ordered by Release Date)")]
        public IEnumerable<Movie> GetAllByReleaseDate(bool asc = false)
        {
            return _movieService.GetMovies(asc);
        }
    }
}
