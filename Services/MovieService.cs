using FCSDemo.Models;
using FCSDemo.Repositories;

namespace FCSDemo.Services
{
    //Business logic goes here. Abstracted away from our controllers.
    //
    //
    public class MovieService : IMovieService
    {
        private IRepository<Movie> _movieRepository { get; set; }

        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        //If I were doing this properly with a nice database,
        //I'd probably have a more generic sorting system,
        //with the sort order passed down to the query level for efficiency.
        //But as we're going quick and in-mem, we'll sort here.
        //
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
