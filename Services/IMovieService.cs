using FCSDemo.Models;

namespace FCSDemo.Services
{
    public interface IMovieService
    {
        public IEnumerable<Movie> GetMovies(bool asc);
        public Movie GetMovieById(int id);
    }
}
