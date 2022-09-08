using FCSDemo.Models;
using FCSDemo.Repositories;

namespace FCSDemo.Services
{
    public class MovieService : IMovieService
    {
        private IRepository<Movie> _movieRepository { get; set; }

        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<Movie> GetMovies(bool asc)
        {
            var movies =  _movieRepository.Retrieve();
            if(asc)
            {
                return movies.OrderBy(x => x.ReleaseDate);
            }
            else
            {
                return movies.OrderByDescending(x => x.ReleaseDate);
            }
        }

        public Movie GetMovieById(int id)
        {
            return _movieRepository.Retrieve(id);
        }
    }
}
