using FCSDemo.Models;
using FCSDemo.Stores;

namespace FCSDemo.Repositories
{
    //Data access lives here, abstracted from business logic.
    //Again, the CUD methods are super splashy because they
    //never get used, and for all I know they make everything catch fire,
    //but it just doesn't feel right without them...
    //
    public class MovieRepository : IRepository<Movie>
    {
        private IStore<Movie> _movieStore { get; set; }

        public MovieRepository(IStore<Movie> movieStore)
        {
            _movieStore = movieStore;
        }

        //CRUD
        public int Create(Movie record)
        {
            return _movieStore.Insert(record);
        }

        public IEnumerable<Movie> Retrieve()
        {
            return _movieStore.Select(x => true);
        }

        public Movie Retrieve(int id)
        {
            return _movieStore.Select(id);
        }

        public void Update(Movie record)
        {
            _movieStore.Update(record);
        }

        public void Delete(int id)
        {
            _movieStore.Delete(id);
        }
    }
}
