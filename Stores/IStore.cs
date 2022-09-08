using FCSDemo.Models;

namespace FCSDemo.Stores
{
    public interface IStore<T> where T : IAggregateRoot
    {
        public int Insert(T record);
        public void Delete(int id);

        public T Select(int id);

        public IEnumerable<T> Select(Func<T, bool> predicate);

        public void Update(T movie);
    }
}
