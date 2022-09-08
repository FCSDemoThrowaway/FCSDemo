using FCSDemo.Models;
using System.Linq;

namespace FCSDemo.Stores
{
    //Kinda cheating here for the time-being.
    //This could absolutely be replaced with an actual database.
    //And then you could do nice things, like proper SQL queries. Dapper ftw.
    public class MovieStore : IStore<Movie>
    {
        private List<Movie> _movies { get; set; } = new List<Movie>();
        private int _idTrack = 0;

        public MovieStore()
        {
            Insert(new Movie("Pulp Fiction", new DateTime(1994, 10, 14), "Quentin Tarantino"));
            Insert(new Movie("Independence Day", new DateTime(1996, 7, 3), "Roland Emmerich"));
            Insert(new Movie("True Romance", new DateTime(1993, 09, 10), "Tony Scott"));
            Insert(new Movie("Goodfellas", new DateTime(1990, 9, 19), "Martin Scorsese"));
        }

        public int Insert(Movie movie)
        {
            movie.Id = ++_idTrack;
            _movies.Add(movie);

            return _idTrack;
        }

        public void Delete(int id)
        {
            var record = _movies.FirstOrDefault(x => x.Id == id);
            if(record != null)
            {
                _movies.Remove(record);
            }
        }

        public Movie Select(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Movie> Select(Func<Movie, bool> predicate)
        {
            return _movies.Where(predicate);
        }

        public void Update(Movie movie)
        {
            if (movie.Id == 0)
                throw new InvalidOperationException("No ID associated with record for update! Are you sure it's in the database?");
            else
            {
                var index = _movies.FindIndex(x => x.Id == movie.Id);

                _movies[index] = movie;
            }
        }
    }
}
